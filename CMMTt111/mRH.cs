using System;
using System.Threading;
using System.Net;  //basic function for ip adressing
using System.Net.Sockets; //ne ed to tightly control access to the network. Needed for TcpClient class 
using System.Runtime.Serialization;
using System.IO;
using System.Text;

namespace CMMTt111
{
    public class festoCMMT
    {
        #region About & Changelog
        private string version = "v1.017 - 02/03/2023";
        public string Version { get { return version; } }
        // --------------------------------------------------------------------- 
        // Version v0.9 initial release, beta
        // 04/04/2020
        // modifying source code? Credit to: mRH
        // ---------------------------------------------------------------------
        // Changelog:
        // ---------------------------------------------------------------------
        // Version v1.017
        // 02/03/2023
        // add retryconnection() for ReadmbThread when connected and connectionError are both true
        // add cbEnableDrive = false when festoCMMT.Connected is false 
        // ---------------------------------------------------------------------
        // Version v1.01
        // 20/04/2022
        // Create Log File when
        // - Malfunction active
        // - Disconnected
        // - Exit application
        // Log data for debugging - log.mrh
        // Default modbusTimeOut = 1000 (Previously = 100)
        // Default setReadTimeOut = 100 (Previously = 30)
        // xxx Remove retryconnection delay 5sec xxx
        // 1 Thread for Cycle --> 2 Thread for Read and Write --> to enhance stability
        // add MaxReadmbTime, MaxWritembTime, ActualReadmbTime, ActualWritembTime 
        // ----------------------------------------------------------------------
        // Version v0.99
        // 27/07/2021
        // Fix Stop when homing, add new string response in CmmtControl method, "Homing interrupted"
        // New response in iCmmtStatus = 11203 for "Homing interrupted"
        // New properties:
        //      int SetReadTimeOut {Get, Set}, (ms) Default = 30ms, minimum 10ms, skip read data from cmmt when time out reached
        //      int MaxReadTime {Get, Set}, (ms) to monitor maximum read time
        //      int MaxCycleTime {Get, Set}, (ms) to monitor maximum cycle time
        //      int CounterPass (Get, Set}, to count number of ActualReadTime that exceed SetReadTimeOut
        //      int ActualReadTime {Get}, (ms) to monitor actual read time
        //      int ActualCycleTime {Get}, (ms) to monitor actual cycle time
        //----------------------------------------------------------------------
        // Version v0.98 - debug version
        // 10/07/2021
        // Add: counterPass = how many time data from cmmt does not received (time out)
        //      setReadTime = how long (in ms) to wait for incoming data from cmmt
        //      actualReadTime, actualCycleTime
        //      maxReadTime = record highest actual read time
        //      maxCycleTime = record actual cycle time
        // Detect system time from request data to receive data: setReadTimeOut (default=30ms, min 10ms)
        // --> Check myStream.DataAvailable in answerReadInputRegister, if actualReadTime > setReadTimeOut --> ignore
        // --> Check myStream.DataAvailable in answerWriteHoldingRegister, if actualReadTime > setReadTimeOut --> ignore
        // Additional passive functionality to disconnect when error 391 occurs --> lookfor "Disconnect391"
        // Additional passive functionality to stop retry --> lookfor "NoRetry"
        // ---------------------------------------------------------------------
        // Version v0.97
        // 27/04/2021
        // Add functionality to acommodate new target --> [15303]
        // ---------------------------------------------------------------------
        // Version v0.96
        // 03/11/2020
        // Fix Bug with CMMT firmware version v18
        // --> Write output bQuery[10] & bQuary[11]
        // ---------------------------------------------------------------------
        // Version v0.95
        // 03/06/2020
        // Fix Target position minus value low bit: -65535 must be ommitted
        // ---------------------------------------------------------------------
        // Version v0.94
        // 22/05/2020
        // Add function to change modbus timeout
        // Modbus address: 40401, Default: 100 ms, adjustable: 0 to 10000 ms
        // Write: FC6 offset: 400, Read: FC3 offset: 400
        // Re-arrange variable get set
        // ---------------------------------------------------------------------
        // Version v0.93
        // 06/05/2020
        // Add bit access to POS_STW2 and POS_ZSTW2
        // to enable/disable software & hardware limit switch
        // ---------------------------------------------------------------------
        // Version v0.92
        // 10/04/2020
        // Apply get set for transfering information
        // ---------------------------------------------------------------------
        // Version v0.91
        // 09/04/2020
        // Fix bug status in cmmtcontrol during during continue record position
        // iRetryCounnection do not reset
        // timeout = 0 --> no timeout
        // homingtimeout = 0 --> no homing timeout
        // iCMMTstatus for cmmtcontrol sequence indicator = cmd mode step seq, ex: 11201 --> cmd=1,mode=1,step=20,seq=1 
        // ----------------------------------------------------------------------
        #endregion

        #region Connection variable

        private TcpClient myTcpClient;  //Provides client connections for TCP network services
        private NetworkStream myStream; //Provides the underlying stream of data for network access
        private byte[] bAnswer = new byte[400]; //new byte[400];
        private string myIpAddress = "";
        private byte NoIW = 0; //extended IW
        private byte NoOW = 0; //extended OW
        private bool ThreadStarted = false;
        private bool disconnecting = false;
        private bool exitApplication = false;

        #endregion

        #region transfer data variable

        #region TransactionId
        private int tIDWrite = 1;  //Send data transaction Id
        private int tIDRead = 0;        //Receive data transaction Id
        private int icountWritemb = 1;
        private int icountReadmb = 0;

        public int TIDWrite { get { return tIDWrite; } }
        public int TIDRead { get { return tIDRead; } }
        public int iCountWritemb { get { return icountWritemb; } }
        public int iCountReadmb { get { return icountReadmb; } }

        #endregion

        #region Output word access
        private bool accessOutputWord_STW1 = false;
        private bool accessOutputWord_POS_STW1 = false;
        private bool accessOutputWord_POS_STW2 = false;

        public bool AccessOutputWord_STW1 { get { return accessOutputWord_STW1; } set { accessOutputWord_STW1 = value; } }
        public bool AccessOutputWord_POS_STW1 { get { return accessOutputWord_POS_STW1; } set { accessOutputWord_POS_STW1 = value; } }
        public bool AccessOutputWord_POS_STW2 { get { return accessOutputWord_POS_STW2; } set { accessOutputWord_POS_STW2 = value; } }
        #endregion

        #region Connection
        private bool connected = false;
        private bool connectionError = false;
        private int iretryConnection = 0;
        private int cycleTime = 15;
        private int modbusTimeOut = 1000;
        private int modbusTimeOutCurrent = 0;
        private int setReadTimeOut = 100;
        private int actualReadTime = 0;
        private int actualCycleTime = 0;
        private int actualWritembTime = 0;
        private int actualReadmbTime = 0;
        private int maxReadTime = 0;
        private int maxCycleTime = 0;
        private int maxWritembTime = 0;
        private int maxReadmbTime = 0;
        private int counterPass = 0;
       
        public bool Connected { get { return connected; } }
        public bool ConnectionError { get { return connectionError; } }
        public int iRetryConnection { get { return iretryConnection; } }
        public int CycleTime
        {
            get { return cycleTime; }
            set { if (value >= 1) { cycleTime = value; } else { cycleTime = 15; } }
        }
        public int ModbusTimeOut
        {
            get { return modbusTimeOut; }
            set
            {
                if (value > 10000) { modbusTimeOut = 10000; }
                else if (value < 100) { modbusTimeOut = 100; }
                else { modbusTimeOut = value; }
            }
        }
        public int SetReadTimeOut
        {
            get { return setReadTimeOut; }
            set { if (value >= 10) { setReadTimeOut = value; } else { setReadTimeOut = 10; } }
        }
        public int ActualReadTime { get { return actualReadTime; } }
        public int ActualCycleTime { get { return actualCycleTime; } }
        public int ActualWritembTime { get { return actualWritembTime; } }
        public int ActualReadmbTime { get { return actualReadmbTime; } }
        public int MaxReadTime
        {
            get { return maxReadTime; }
            set { maxReadTime = value; }
        }
        public int MaxCycleTime
        {
            get { return maxCycleTime; }
            set { maxCycleTime = value; }
        }
        public int MaxWritembTime
        {
            get { return maxWritembTime; }
            set { maxWritembTime = value; }
        }
        public int MaxReadmbTime
        {
            get { return maxReadmbTime; }
            set { maxReadmbTime = value; }
        }
        public int CounterPass
        {
            get { return counterPass; }
            set { maxCycleTime = value; }
        }
        
        #endregion

        #region Status
        private string statusRead = "";
        private string statusWrite = "";
        private string status = "";

        public string StatusRead { get { return statusRead; } }
        public string StatusWrite { get { return statusWrite; } }
        public string Status { get { return status; } }
        #endregion

        #region Cmmt Control
        private int timeout = 0; //cycletime * timeout --> cycletime = 100, timeout = 2 sec
        private int timewait = 5;
        private int homingtimeout = 0;
        private int icmmtStatus = 0; //cmd mode step seq

        public int Timeout
        {
            get { return timeout; }
            set { if (value >= 0) { timeout = value; } else { timeout = 0; } }
        }
        public int Timewait
        {
            get { return timewait; }
            set { if (value >= 0) { timewait = value; } else { timewait = 0; } }
        }
        public int Homingtimeout
        {
            get { return homingtimeout; }
            set { if (value >= 0) { homingtimeout = value; } else { homingtimeout = 0; } }
        }
        public int iCmmtStatus { get { return icmmtStatus; } }
        #endregion

        #region IO
        private int[] inW = new int[30]; //new int[12];
        private int[] outW = new int[30]; // new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0 };

        public int[] InW { get { return inW; } }
        public int[] OutW { get { return outW; } set { outW = value; } }
        #endregion

        #region factor gropup
        private float convertPositionInput;
        private float convertVelocityInput;
        private float convertPositionOutput;
        private float convertVelocityOutput;

        public float ConvertPositionInput { get { return convertPositionInput; } set { convertPositionInput = value; } }
        public float ConvertVelocityInput { get { return convertVelocityInput; } set { convertVelocityInput = value; } }
        public float ConvertPositionOutput { get { return convertPositionOutput; } set { convertPositionOutput = value; } }
        public float ConvertVelocityOutput { get { return convertVelocityOutput; } set { convertVelocityOutput = value; } }
        #endregion

        #region CMMT Output 

        #region Output to CMMT
        public int STW1 { get; set; }
        public int POS_STW1 { get; set; }
        public int POS_STW2 { get; set; }
        public int STW2 { get; set; }
        private int iOverride;
        public float Override { get; set; }
        private int MDI_TarPos1;
        private int MDI_TarPos2;
        public float TargetPosition { get; set; }
        private int MDI_Velocity1;
        private int MDI_Velocity2;
        public float TargetVelocity { get; set; }
        private int MDI_ACC;
        public float Acceleration { get; set; }
        private int MDI_DEC;
        public float Deceleration { get; set; }
        #endregion

        #region bit access STW1
        public bool OutputStageEnable { get; set; }
        public bool DriveCoast { get; set; }
        public bool FastStop { get; set; }
        public bool EnableOperation { get; set; }
        public bool RampGenerator { get; set; }          //(NC)
        public bool RejectPositioningTask { get; set; }  //(NC)
        public bool StartRampGenerator { get; set; }     //(NC)    
        public bool IntermediateStop { get; set; }       //(NC)
        public bool RotationalSpeedSetPoint { get; set; }
        public bool ActivatePositioningTask { get; set; }
        public bool AcknowledgeMalfunction { get; set; }
        public bool Jogging1 { get; set; }
        public bool Jogging2 { get; set; }
        public bool PLCMasterControl { get; set; }
        public bool InvertSetPointValue { get; set; }
        public bool StartHoming { get; set; }
        public bool ReleaseHoldingBrake { get; set; }
        public bool StartRecordChange { get; set; }
        #endregion

        #region bit access POS_STW1
        public byte PositioningRecord { get; set; }
        private bool PositioningRecordSelectionBit0;
        private bool PositioningRecordSelectionBit1;
        private bool PositioningRecordSelectionBit2;
        private bool PositioningRecordSelectionBit3;
        private bool PositioningRecordSelectionBit4;
        private bool PositioningRecordSelectionBit5;
        private bool PositioningRecordSelectionBit6;
        public bool RelativePositioning { get; set; }
        public bool AbsolutePositioning { get; set; }
        public bool MDISelection { get; set; }
        #endregion

        #region bit access POS_STW2;
        public bool TrackingMode { get; set; } // bit 0
        public bool CurrentPositionasHome { get; set; } // bit 1
        public bool IncrementalJogging { get; set; } // bit 5: 1=incremental, 0=velocity
        public bool TouchProbeSource { get; set; } // bit 10: 1=secondary, 0=primary
        public bool TouchProbeEdge { get; set; } // bit 11: 1=falling edge, 0=rising edge
        public bool ActivateSoftwareLimitSwitch { get; set; } // bit 14: 1=active, 0=deactive
        public bool ActivateHardwareLimitSwitch { get; set; } // bit 15: 1=active, 0=deactive
        #endregion

        #endregion

        #region CMMT Input 

        #region Input from CMMT
        private int zSW1;
        private int pOS_ZSW1;
        private int pOS_ZSW2;
        private int zSW2;
        private int mELDW;
        private int xIST_A1;
        private int xIST_A2;
        private float actualPosition;
        private int nIST_B1;
        private int nIST_B2;
        private float actualVelocity;
        private int fault_Code;
        private int warn_Code;

        public int ZSW1 { get { return zSW1; } }
        public int POS_ZSW1 { get { return pOS_ZSW1; } }
        public int POS_ZSW2 { get { return pOS_ZSW2; } }
        public int ZSW2 { get { return zSW2; } }
        public int MELDW { get { return mELDW; } }
        public int XIST_A1 { get { return xIST_A1; } }
        public int XIST_A2 { get { return xIST_A2; } }
        public float ActualPosition { get { return actualPosition; } }
        public int NIST_B1 { get { return nIST_B1; } }
        public int NIST_B2 { get { return nIST_B2; } }
        public float ActualVelocity { get { return actualVelocity; } }
        public int Fault_Code { get { return fault_Code; } }
        public int Warn_Code { get { return warn_Code; } }
        #endregion

        #region bit access ZSW1;
        private bool readytobeSwitchOn;
        private bool readyforOperation;
        private bool operationEnabled;
        private bool malfunctionEffective;
        private bool coastingActive;         //(NC)
        private bool fastStopActive;         //(NC)
        private bool switchOnLockActive;
        private bool warningEffective;
        private bool velocityInRange;
        private bool positionInRange;
        private bool guideRequired;
        private bool velocityComparisonValueReached;
        private bool targetPositionReached;
        private bool iMPLimitNotReached;
        private bool referencePointSet;
        private bool holdingBrakeReleased;
        private bool positioningTaskActivated;
        private bool noWarningifMotorOvertemperature;
        private bool driveisStationary;
        private bool motorDirectionofRotation;
        private bool axisAccelerated;
        private bool noPowerUnitOvertemperatureWarning;
        private bool driveDecelerated;

        public bool ReadytobeSwitchOn { get { return readytobeSwitchOn; } }
        public bool ReadyforOperation { get { return readyforOperation; } }
        public bool OperationEnabled { get { return operationEnabled; } }
        public bool MalfunctionEffective { get { return malfunctionEffective; } }
        public bool CoastingActive { get { return coastingActive; } }         //(NC)
        public bool FastStopActive { get { return fastStopActive; } }         //(NC)
        public bool SwitchOnLockActive { get { return switchOnLockActive; } }
        public bool WarningEffective { get { return warningEffective; } }
        public bool VelocityInRange { get { return velocityInRange; } }
        public bool PositionInRange { get { return positionInRange; } }
        public bool GuideRequired { get { return guideRequired; } }
        public bool VelocityComparisonValueReached { get { return velocityComparisonValueReached; } }
        public bool TargetPositionReached { get { return targetPositionReached; } }
        public bool IMPLimitNotReached { get { return iMPLimitNotReached; } }
        public bool ReferencePointSet { get { return referencePointSet; } }
        public bool HoldingBrakeReleased { get { return holdingBrakeReleased; } }
        public bool PositioningTaskActivated { get { return positioningTaskActivated; } }
        public bool NoWarningifMotorOvertemperature { get { return noWarningifMotorOvertemperature; } }
        public bool DriveisStationary { get { return driveisStationary; } }
        public bool MotorDirectionofRotation { get { return motorDirectionofRotation; } }
        public bool AxisAccelerated { get { return axisAccelerated; } }
        public bool NoPowerUnitOvertemperatureWarning { get { return noPowerUnitOvertemperatureWarning; } }
        public bool DriveDecelerated { get { return driveDecelerated; } }
        #endregion

        #region bit access POS_ZSW1;
        private bool activePositioningRecordBit0;
        private bool activePositioningRecordBit1;
        private bool activePositioningRecordBit2;
        private bool activePositioningRecordBit3;
        private bool activePositioningRecordBit4;
        private bool activePositioningRecordBit5;
        private bool activePositioningRecordBit6;
        private byte activePositioningRecord;
        private bool negativeLimitSwitchActive;
        private bool positiveLimitSwitchActive;
        private bool joggingActive;
        private bool homingActive;
        private bool positioningRecordActive;
        private bool mDIActive;

        public bool ActivePositioningRecordBit0 { get { return activePositioningRecordBit0; } }
        public bool ActivePositioningRecordBit1 { get { return activePositioningRecordBit1; } }
        public bool ActivePositioningRecordBit2 { get { return activePositioningRecordBit2; } }
        public bool ActivePositioningRecordBit3 { get { return activePositioningRecordBit3; } }
        public bool ActivePositioningRecordBit4 { get { return activePositioningRecordBit4; } }
        public bool ActivePositioningRecordBit5 { get { return activePositioningRecordBit5; } }
        public bool ActivePositioningRecordBit6 { get { return activePositioningRecordBit6; } }
        public byte ActivePositioningRecord { get { return activePositioningRecord; } }
        public bool NegativeLimitSwitchActive { get { return negativeLimitSwitchActive; } }
        public bool PositiveLimitSwitchActive { get { return positiveLimitSwitchActive; } }
        public bool JoggingActive { get { return joggingActive; } }
        public bool HomingActive { get { return homingActive; } }
        public bool PositioningRecordActive { get { return positioningRecordActive; } }
        public bool MDIActive { get { return mDIActive; } }
        #endregion

        #region bit access POS_ZSW2;
        private bool trackingModeActive; // bit 0
        private bool velocityLimitingActive; // bit 1
        private bool setPointValueStopped; // bit 2
        private bool driveTravelsForward; // bit 4
        private bool driveTravelsBackward; // bit 5
        private bool negativeSoftwareLimitSwitchActive; // bit 6
        private bool positiveSoftwareLimitSwitchActive; // bit 7
        private bool actualPositionLessEqualThanCamSwitch0; // bit 8
        private bool actualPositionLessEqualThanCamSwitch1; // bit 9
        private bool directOutput1ViaPositioningRecord; // bit 10
        private bool directOutput2ViaPositioningRecord; // bit 11
        private bool fixedStopReached; // bit 12
        private bool fixedStopClampingTorqueReached; // bit 13
        private bool travelToFixedStopActive; // bit 14
        private bool positionCommandActive; // bit 15

        public bool TrackingModeActive { get { return trackingModeActive; } }
        public bool VelocityLimitingActive { get { return velocityLimitingActive; } }
        public bool SetPointValueStopped { get { return setPointValueStopped; } }
        public bool DriveTravelsForward { get { return driveTravelsForward; } }
        public bool DriveTravelsBackward { get { return driveTravelsBackward; } }
        public bool NegativeSoftwareLimitSwitchActive { get { return negativeSoftwareLimitSwitchActive; } }
        public bool PositiveSoftwareLimitSwitchActive { get { return positiveSoftwareLimitSwitchActive; } }
        public bool ActualPositionLessEqualThanCamSwitch0 { get { return actualPositionLessEqualThanCamSwitch0; } }
        public bool ActualPositionLessEqualThanCamSwitch1 { get { return actualPositionLessEqualThanCamSwitch1; } }
        public bool DirectOutput1ViaPositioningRecord { get { return directOutput1ViaPositioningRecord; } }
        public bool DirectOutput2ViaPositioningRecord { get { return directOutput2ViaPositioningRecord; } }
        public bool FixedStopReached { get { return fixedStopReached; } }
        public bool FixedStopClampingTorqueReached { get { return fixedStopClampingTorqueReached; } }
        public bool TravelToFixedStopActive { get { return travelToFixedStopActive; } }
        public bool PositionCommandActive { get { return positionCommandActive; } }
        #endregion

        #endregion

        #endregion ---------------------------------------------------------------------------

        #region Function
        public bool GetBitfromInt(int myInt, int bitNumber)
        {
            return (myInt & (1 << bitNumber)) != 0;
        }
        #endregion

        #region Log Data - Debug
        string[] sLogLine = new string[1000];
        int iLogLine = 0;

        private void CreateLogFile()
        {
            //string LogFile = DateTime.Now.ToString("yy") +
            //                 DateTime.Now.ToString("MM") +
            //                 DateTime.Now.ToString("dd") +
            //                 DateTime.Now.ToString("HH") +
            //                 DateTime.Now.ToString("mm") +
            //                 ".mrh";
            string LogFile = "log.mrh";

            try
            {
                // Create log file
                if (!File.Exists(LogFile))
                {
                    // Create a new file     
                    using (FileStream fs = File.Create(LogFile))
                    {
                        // Add some text to file    
                        byte[] created = new UTF8Encoding(true).GetBytes("Log File Created");
                        fs.Write(created, 0, created.Length);
                    }
                }

                // Write file
                sLogLine[iLogLine] = version;
                string sav = string.Join("\r\n", sLogLine);
                using (StreamWriter writer = new StreamWriter(LogFile))
                {
                    writer.WriteLine(sav);
                }

                //Clean variable
                //for (int i = 0; i < 1000; i++)
                //{
                //    sLogLine[i] = "";
                //    iLogLine = 0;
                //}
            }
            catch { }
        }

        private void LogData(string str)
        {
            try
            {
                for (int i = iLogLine; i > 0; i--)
                {
                    sLogLine[i] = sLogLine[i - 1];
                }
                sLogLine[0] = DateTime.Now.ToString("yy/MM/dd HH:mm:ss:ffff") + "  " + str;
                if (iLogLine < 1000) { iLogLine++; }
            }
            catch { }
        }
        #endregion

        #region Main - Connect, Disconnect, ExitAPplication

        int numRegIW = 0;
        int numRegOW = 0;

        public void Connect(string ipAddress, byte IW, byte OW)
        {
            // Try to establish communication with modbus server
            myTcpClient = new TcpClient();
            myIpAddress = ipAddress;

            NoIW = IW; //extended IW
            NoOW = OW; //extended OW

            numRegIW = 12 + NoIW;
            numRegOW = 12 + NoIW;

            IAsyncResult ar = myTcpClient.BeginConnect(myIpAddress, 502, null, null);
            System.Threading.WaitHandle wh = ar.AsyncWaitHandle;
            try
            {
                // 
                status = "Connecting..";
                //LogData(status);

                if (!ar.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(2), false))
                {
                    //Connected = false;
                    throw new TimeoutException("Connection not possible!\nWrong IP-Address? Wrong Port number?");
                }
                myTcpClient.EndConnect(ar);
                myTcpClient.ReceiveTimeout = 20; //Socket timeout
                myTcpClient.SendTimeout = 20; //Socket timeout

                myStream = myTcpClient.GetStream();

                connected = true;
                connectionError = false;

                status = "Connected"; //+ iRetryConnection.ToString();
                LogData(status + "[" + iretryConnection.ToString() + "]");
                iretryConnection2 = 0; //reset retry connection timeout
                
                //activate thread
                #region Create cycle, write and read thread 
                if (!ThreadStarted)
                {
                    //Cycle
                    //Write
                    ThreadStart writembRef = new ThreadStart(WritembThread);
                    Thread writembThd = new Thread(writembRef);
                    writembThd.Start();
                    //Read
                    ThreadStart readmbRef = new ThreadStart(ReadmbThread);
                    Thread readmbThd = new Thread(readmbRef);
                    readmbThd.Start();
                    //--------------------------------------------
                    ThreadStarted = true;
                    LogData("Thread Started");
                }
                #endregion
            }
            catch //(Exception ex)
            {
                if (!connected)
                {
                    status = "Can't connect";
                    LogData(status);
                }          
            }
            finally
            {
                wh.Close();
            }
        }

        public void Disconnect()
        {
            disconnecting = true;
            LogData("Disconnecting..");
        }

        public void ExitApplication()
        {
            exitApplication = true;
            LogData("Exit Application");
            CreateLogFile();
        }

        #endregion

        #region Maintain connection

        int iretryConnection2 = 0;
        private void retryConnection()
        {
            connectionError = true; 
            iretryConnection++;
            iretryConnection2++;
            LogData("AutoConnect[" + iretryConnection + "]");
            bool NoRetry = false; // = false --> Normal, = true --> disconnected when connection error

            if (NoRetry)
            {
                //No retry
                status = "Retry function disabled" + Environment.NewLine;
                try
                {
                    myTcpClient.Close();
                    myStream.Close();
                    myStream.Dispose();
                }
                catch { }
            }
            else
            {
                //With retry
                status = "Connection retry: " + iretryConnection.ToString() + Environment.NewLine;
                try
                {
                    myTcpClient.Close();
                    myStream.Close();
                    myStream.Dispose();
                }
                catch { }
                Connect(myIpAddress, NoIW, NoIW);
                //Reset counter
                icountReadmb = 0;
                icountWritemb = 1;
                MaxRWGap = 0;
                MaxTIDGap = 0;
            }
        }

        #endregion

        #region Supporting function

        private byte GetUpperByte(int data) { return (byte)(data >> 8); }
        private byte GetLowerByte(int data) { return (byte)(data & 0xFF); }
        private string GetHexStringfromArrayByte(byte[] data, int numdata)
        {
            string s = "";
            for (int i = 0; i < numdata; i++)
            {
                s = s + data[i].ToString("X2") + " ";

            }
            return s;
        }
        private int GetWord(byte Upper, byte Lower)
        {
            return Upper * 256 + Lower;
        }

        #endregion

        #region CMMT Sequence Control: Homing, Absolute/Relative Positioning, Record Table
        private byte activeCmd = 0;
        private byte activeMode = 0;
        private int iStep = 0;
        private int icnt = 0;
        private string cmmtstatus = "";
        private bool xMalfucntionEffective = false;

        public string CmmtControl(byte mode, byte cmd)
        {
            // mode: 1 = homing, 2 = move absolute, 3 = move relative, 4 = record selection
            // cmd:  1 = Go, 2 = stop, 3 = clear, 4 = acknowledge

            if (cmd == 4) { iStep = 0; activeCmd = 0; icnt = 0; maxReadTime = 0; maxWritembTime = 0; maxReadmbTime = 0; MaxTIDGap = 0; }  // when pressed ack button
            if (cmd != 0 & activeCmd == 0) { activeCmd = cmd; activeMode = mode; }
            if (!OutputStageEnable & activeCmd != 4) { cmmtstatus = "No Output stage enable"; icmmtStatus = 1; }

            #region acknowledge malfunction and set output stage enable
            if (activeCmd == 4)
            {
                switch (iStep)
                {
                    case 0:
                        // reset all control output
                        OutputStageEnable = false;
                        StartHoming = false;
                        AbsolutePositioning = false;
                        RelativePositioning = false;
                        RejectPositioningTask = false;
                        IntermediateStop = false;
                        MDISelection = false;
                        ActivatePositioningTask = false;

                        iStep = 5;
                        break;
                    case 5:
                        if (icnt >= timeout & timeout != 0)
                        {
                            cmmtstatus = "Unable to reset malfunction";
                            icmmtStatus = 405;
                            iStep = 99;
                        }
                        else if (malfunctionEffective)
                        {
                            AcknowledgeMalfunction = true;
                            icnt++;
                        }
                        else
                        {
                            icnt = 0;
                            iStep = 10;
                        }
                        break;
                    case 10:
                        OutputStageEnable = false;
                        cmmtstatus = "Set Output Stage..";
                        icmmtStatus = 4010;
                        iStep = 20;
                        break;
                    case 20:
                        icnt++;
                        if (icnt >= timewait)
                        {
                            OutputStageEnable = true;
                            icnt = 0;
                            iStep = 30;
                        }
                        break;
                    case 30:
                        if (operationEnabled)
                        {
                            cmmtstatus = "Operation enabled";
                            icmmtStatus = 40301;
                            iStep = 99;
                        }
                        else
                        {
                            icnt++;
                            if (icnt >= timeout & timeout != 0)
                            {
                                cmmtstatus = "Can't enable operation";
                                icmmtStatus = 40302;
                                iStep = 99;
                            }
                        }
                        break;
                    case 99:
                        AcknowledgeMalfunction = false;
                        icnt = 0;
                        activeCmd = 0;
                        iStep = 0;
                        break;
                }
            }
            #endregion

            #region homing
            if (activeCmd == 1 & activeMode == 1)
            {
                switch (iStep)
                {
                    case 0:
                        if (!operationEnabled)
                        {
                            cmmtstatus = "Operation is not enabled";
                            icmmtStatus = 1101;
                            iStep = 99;
                        }
                        else
                        {
                            StartHoming = true;
                            cmmtstatus = "homing...";
                            icmmtStatus = 1102;
                            iStep = 10;
                        }
                        break;
                    case 10:
                        if (icnt >= timewait | !referencePointSet)
                        {
                            iStep = 20;
                        }
                        else
                        {
                            icnt++;
                        }
                        break;
                    case 20:
                        if (icnt >= homingtimeout & homingtimeout != 0)
                        {
                            cmmtstatus = "homing time-out";
                            icmmtStatus = 11201;
                            iStep = 99;
                        }
                        else if (referencePointSet)
                        {
                            cmmtstatus = "Homing done";
                            icmmtStatus = 11202;
                            iStep = 99;
                        }
                        else if (cmd == 2) //Stop
                        {
                            StartHoming = false;
                            cmmtstatus = "Homing interrupted";
                            icmmtStatus = 11203;
                            iStep = 99;
                        }
                        else
                        {
                            icnt++;
                        }
                        break;
                    case 99:
                        StartHoming = false;
                        icnt = 0;
                        activeCmd = 0;
                        iStep = 0;
                        break;
                }
            }
            if (activeCmd == 2 & activeMode == 1) { activeCmd = 0; }
            #endregion

            #region move absolute & relative
            if (activeCmd == 1 & (activeMode == 2 | activeMode == 3)) //--> mode=2+3
            {
                switch (iStep)
                {
                    case 0:
                        if (!operationEnabled)
                        {
                            cmmtstatus = "Operation is not enabled";
                            icmmtStatus = 150;
                            iStep = 99;
                        }
                        else
                        {
                            if (mode == 2)
                            {
                                AbsolutePositioning = true;
                                RelativePositioning = false;
                                //cmmtstatus = "Move Absolute..";
                            }
                            if (mode == 3)
                            {
                                AbsolutePositioning = false;
                                RelativePositioning = true;
                                //cmmtstatus = "Move Relative..";
                            }
                            RejectPositioningTask = true;   //NC, 0 = reject
                            IntermediateStop = true;        //NC, 0 = stop

                            MDISelection = true;
                            iStep = 10;
                        }
                        break;
                    case 10:
                        if (icnt >= timeout & timeout != 0)
                        {
                            cmmtstatus = "time-out";
                            icmmtStatus = 1510;
                            iStep = 99;
                        }
                        else if (mDIActive)
                        {
                            ActivatePositioningTask = true;
                            icnt = 0;
                            iStep = 20;
                        }
                        else
                        {
                            icnt++;
                        }
                        break;
                    case 20:
                        if (icnt >= timewait | !targetPositionReached)
                        {
                            iStep = 30;
                        }
                        else
                        {
                            icnt++;
                        }
                        break;
                    case 30:
                        if (icnt >= timeout & timeout != 0)
                        {
                            cmmtstatus = "time-out";
                            icmmtStatus = 15301;
                            iStep = 99;
                        }
                        else if (targetPositionReached)
                        {
                            cmmtstatus = "Position reached";
                            icmmtStatus = 15302;
                            iStep = 40;
                        }
                        else if (!IntermediateStop)
                        {
                            if (cmd == 1)
                            {
                                IntermediateStop = true;
                            }
                            if (!RejectPositioningTask | (mode != 2 & mode != 3))
                            {
                                iStep = 99;
                            }
                        }
                        else
                        {
                            if (cmd == 1) { ActivatePositioningTask = false; }
                            if (cmd == 0) { ActivatePositioningTask = true; }
                            cmmtstatus = "moving...";
                            icmmtStatus = 15303;
                            icnt++;
                        }
                        break;
                    case 40:
                        ActivatePositioningTask = false;
                        icnt = 0;
                        iStep = 50;
                        break;
                    case 50: // wait for next target
                        if (cmd == 1)
                        {
                            iStep = 0;
                        }
                        if (mode != 2 & mode != 3) // not in positioning mode
                        {
                            iStep = 99;
                        }
                        break;
                    case 99:
                        ActivatePositioningTask = false;
                        AbsolutePositioning = false;
                        RelativePositioning = false;
                        RejectPositioningTask = false;
                        IntermediateStop = false;
                        MDISelection = false;

                        icnt = 0;
                        activeCmd = 0;
                        iStep = 0;
                        break;
                }
            }
            #endregion

            #region position record selection
            if (activeCmd == 1 & activeMode == 4)
            {
                switch (iStep)
                {
                    case 0:
                        if (!operationEnabled)
                        {
                            cmmtstatus = "Operation is not enabled";
                            icmmtStatus = 1401;
                            iStep = 99;
                        }
                        else if (PositioningRecord == 0)
                        {
                            cmmtstatus = "Position record selection is not set";
                            icmmtStatus = 1402;
                            iStep = 99;
                        }
                        else
                        {
                            RejectPositioningTask = true;   //NC, 0 = reject
                            IntermediateStop = true;        //NC, 0 = stop

                            MDISelection = false;
                            iStep = 10;
                        }
                        break;
                    case 10:
                        if (icnt >= timeout & timeout != 0)
                        {
                            cmmtstatus = "time-out";
                            icmmtStatus = 1410;
                            iStep = 99;
                        }
                        else if (!mDIActive) // & PositioningRecordActive)
                        {
                            ActivatePositioningTask = true;
                            //cmmtstatus = "Moving to record position " + PositioningRecord.ToString();
                            icnt = 0;
                            iStep = 20;
                        }
                        else
                        {
                            icnt++;
                        }
                        break;
                    case 20:
                        if (icnt >= timewait | !targetPositionReached)
                        {
                            iStep = 30;
                        }
                        else
                        {
                            icnt++;
                        }
                        break;
                    case 30:
                        if (icnt >= timeout & timeout != 0)
                        {
                            cmmtstatus = "time-out";
                            icmmtStatus = 14301;
                            iStep = 99;
                        }
                        else if (targetPositionReached)
                        {
                            cmmtstatus = "Selection reached: " + PositioningRecord.ToString();
                            icmmtStatus = 14302;
                            iStep = 40;
                        }
                        else if (!IntermediateStop)
                        {
                            if (cmd == 1)
                            {
                                IntermediateStop = true;
                            }
                            if (!RejectPositioningTask | mode != 4)
                            {
                                iStep = 99;
                            }
                        }
                        else
                        {
                            cmmtstatus = "moving to record selection..." + PositioningRecord.ToString();
                            icmmtStatus = 14303;
                            icnt++;
                        }
                        break;
                    case 40:
                        ActivatePositioningTask = false;
                        icnt = 0;
                        iStep = 50;
                        break;
                    case 50: // wait for next target
                        if (cmd == 1)
                        {
                            iStep = 0;
                        }
                        if (mode != 4) // not in record selection mode
                        {
                            iStep = 99;
                        }
                        break;
                    case 99:
                        ActivatePositioningTask = false;
                        RejectPositioningTask = false;
                        IntermediateStop = false;

                        icnt = 0;
                        activeCmd = 0;
                        iStep = 0;
                        break;
                }
            }
            #endregion

            #region cmd stop (cmd == 2) and clear (cmd == 3) (when not homing - mode != 1)

            if (cmd == 2 & activeMode != 1) { IntermediateStop = false; cmmtstatus = "Intermediate Stop executed"; icmmtStatus = 21; }
            if (cmd == 3 & activeMode != 1 & IntermediateStop == false) { RejectPositioningTask = false; cmmtstatus = "Remaining position cleared"; icmmtStatus = 31; }

            #endregion

            if (malfunctionEffective && !xMalfucntionEffective && (fault_Code != 0 || warn_Code != 0))  //add !xMalfunctionEffective 15/4/2022
            {
                cmmtstatus = "Malfunction, fault/warning: " +
                fault_Code.ToString() + " / " + warn_Code.ToString();
                icmmtStatus = 2;
                //LogData("TID Gap = -" + (tIDWrite - tIDRead));
                LogData(cmmtstatus);
                CreateLogFile();
                xMalfucntionEffective = true;
            }
            else if (!malfunctionEffective && xMalfucntionEffective)
            {
                xMalfucntionEffective = false;
                LogData(cmmtstatus);
            }

            return cmmtstatus;
        }
        #endregion
        
        #region Thread Writemb

        DateTime startWritemb = DateTime.Now;
        DateTime endWritemb;
        TimeSpan readWritemb;
     
        private void WritembThread()
        {
            bool xTurn = false;
            //int iWaitRead = 1;
            while (!exitApplication)
            {
                if (connected & !connectionError)
                {

                    if (!xTurn)
                    { 
                        readInput(); 
                    }
                    else
                    {
                        if (!updateModbusTimeOut()) writeOutput();
                    }
                    xTurn = !xTurn;
                    icountWritemb++;
                }

                // the thread is paused for 50 milliseconds
                //iWaitRead = 1 + MaxRWGap / 5; 
                //if ((TIDWrite - TIDRead) < 3)
                //{ iWaitRead = 1; } else { iWaitRead = 2; LogData("Write Time x 2"); }

                //Thread.Sleep(cycleTime * iWaitRead);

                Thread.Sleep(cycleTime);

                #region Disconnecting..
                if (disconnecting & xReadSleep) //only when read thread is a sleep then can disconnect
                {
                    connected = false;
                    connectionError = false;
                    status = "Disconnected";
                    try
                    {
                        myTcpClient.Close();
                        myStream.Close();
                        myStream.Dispose();
                        disconnecting = false;
                        LogData("Disconnected");
                        CreateLogFile();
                    }
                    catch { }
                }
                #endregion

                #region Actual Writemb Time
                endWritemb = DateTime.Now;
                readWritemb = endWritemb - startWritemb;
                actualWritembTime = Convert.ToInt32(readWritemb.TotalMilliseconds);
                if (actualWritembTime > maxWritembTime) { maxWritembTime = actualWritembTime; }

                startWritemb = DateTime.Now;
                #endregion            
            }
        }
        #endregion       

        #region Read Input 
        private void readInput()
        {
            //Read 12 word input + extended process data - start address: 30001, Function Code:4
            try
            {
                if (!connectionError) { queryReadInputRegister(); }
            }
            catch (Exception ex)
            { string ex0 = ex.ToString(); }
        }

        private void queryReadInputRegister()
        {
            #region Data to send
            //Data to send for read input register
            //0  1  2  3  4  5  6  7  8  9  10 11
            //XX XX XX XX XX XX XX XX XX XX XX XX 
            //Tid   Pid   Len   id fn offst #reg

            //Tid   --> 00 01 auto increment
            //Pid   --> 00 00
            //Len   --> 00 06
            //id    --> FF
            //fn    --> 04
            //offst --> 00 00
            //#reg  --> 00 0C (for basic) 
            #endregion

            #region Data Query            
            byte[] bQuery = new byte[12];

            bQuery[0] = GetUpperByte(tIDWrite);                    //Tid-H
            bQuery[1] = GetLowerByte(tIDWrite);                    //Tid-L
            bQuery[2] = 0;                                              //Pid-H
            bQuery[3] = 0;                                              //Pid-L
            bQuery[4] = 0;                                              //Len-H
            bQuery[5] = 6;                                              //Len-L
            bQuery[6] = 255;                                            //id
            bQuery[7] = 4;                                              //fn
            bQuery[8] = 0;                                              //Offset-H
            bQuery[9] = 0;                                              //Offset-L
            bQuery[10] = GetUpperByte(numRegIW);                          //#reg-H
            bQuery[11] = GetLowerByte(numRegIW);                          //#reg-L
            #endregion

            string sQuery = GetHexStringfromArrayByte(bQuery, 12);
            statusRead = "Query read: " + sQuery + Environment.NewLine;

            #region Query & Answer
            try
            {
                myStream.Write(bQuery, 0, 12);                          //12--> send 12 bytes
                //answerReadInputRegister(numRegIW);
            }
            catch //(Exception ex)
            {
                LogData("0-Exception while query read");
                retryConnection();
            }
            #endregion

            #region Transaction Id
            tIDWrite++;
            if (tIDWrite >= 20000) { tIDWrite = 1; }
            #endregion

        }                
        #endregion

        #region Write Output
        private void writeOutput()
        {
            //Write 12 word output +extended process data -start address: 40001, Function Code: 16
            #region bit access STW1
            if (!accessOutputWord_STW1)
            {
                STW1 = 1 * Convert.ToInt32(OutputStageEnable) +
                       2 * Convert.ToInt32(DriveCoast) +
                       4 * Convert.ToInt32(FastStop) +
                       8 * Convert.ToInt32(EnableOperation) +
                       16 * Convert.ToInt32((RampGenerator | RejectPositioningTask)) +
                       32 * Convert.ToInt32((StartRampGenerator | IntermediateStop)) +
                       64 * Convert.ToInt32((RotationalSpeedSetPoint | ActivatePositioningTask)) +
                       128 * Convert.ToInt32(AcknowledgeMalfunction) +
                       256 * Convert.ToInt32(Jogging1) +
                       512 * Convert.ToInt32(Jogging2) +
                       1024 * Convert.ToInt32(PLCMasterControl) +
                       2048 * Convert.ToInt32((InvertSetPointValue | StartHoming)) +
                       4096 * Convert.ToInt32(ReleaseHoldingBrake) +
                       8192 * Convert.ToInt32(StartRecordChange);
            }
            #endregion

            #region bit access POS_STW1
            if (!accessOutputWord_POS_STW1)
            {
                PositioningRecordSelectionBit0 = GetBitfromInt(PositioningRecord, 0);
                PositioningRecordSelectionBit1 = GetBitfromInt(PositioningRecord, 1);
                PositioningRecordSelectionBit2 = GetBitfromInt(PositioningRecord, 2);
                PositioningRecordSelectionBit3 = GetBitfromInt(PositioningRecord, 3);
                PositioningRecordSelectionBit4 = GetBitfromInt(PositioningRecord, 4);
                PositioningRecordSelectionBit5 = GetBitfromInt(PositioningRecord, 5);
                PositioningRecordSelectionBit6 = GetBitfromInt(PositioningRecord, 6);

                POS_STW1 = 1 * Convert.ToInt32(PositioningRecordSelectionBit0) +
                           2 * Convert.ToInt32(PositioningRecordSelectionBit1) +
                           4 * Convert.ToInt32(PositioningRecordSelectionBit2) +
                           8 * Convert.ToInt32(PositioningRecordSelectionBit3) +
                           16 * Convert.ToInt32(PositioningRecordSelectionBit4) +
                           32 * Convert.ToInt32(PositioningRecordSelectionBit5) +
                           64 * Convert.ToInt32(PositioningRecordSelectionBit6) +
                           256 * Convert.ToInt32(AbsolutePositioning) +
                           32768 * Convert.ToInt32(MDISelection);
            }
            #endregion

            #region bit access POS_STW2
            if (!accessOutputWord_POS_STW2)
            {
                POS_STW2 = 1 * Convert.ToInt32(TrackingMode) +
                           2 * Convert.ToInt32(CurrentPositionasHome) +
                           32 * Convert.ToInt32(IncrementalJogging) +
                           1024 * Convert.ToInt32(TouchProbeSource) +
                           2048 * Convert.ToInt32(TouchProbeEdge) +
                           16384 * Convert.ToInt32(ActivateSoftwareLimitSwitch) +
                           32768 * Convert.ToInt32(ActivateHardwareLimitSwitch);
            }
            #endregion         

            #region Output
            try
            {
                iOverride = Convert.ToInt32(Override * 16384) / 100;         //16384 = 100%
                MDI_ACC = Convert.ToInt32(Acceleration * 16384) / 100;
                MDI_DEC = Convert.ToInt32(Deceleration * 16384) / 100;

                // fix v0.95
                if (TargetPosition >= 0)
                {
                    MDI_TarPos1 = Convert.ToInt32(TargetPosition * convertPositionOutput) % 65536; // --> low
                    MDI_TarPos2 = Convert.ToInt32(TargetPosition * convertPositionOutput) / 65536; // --> high
                }
                else
                {
                    MDI_TarPos1 = (Convert.ToInt32(TargetPosition * convertPositionOutput) - 65536) % 65536; // --> low
                    MDI_TarPos2 = (Convert.ToInt32(TargetPosition * convertPositionOutput) - 65536) / 65536; // --> high
                }
                if (TargetVelocity >= 0)
                {
                    MDI_Velocity1 = Convert.ToInt32(TargetVelocity * convertVelocityOutput) % 65536; // --> low
                    MDI_Velocity2 = Convert.ToInt32(TargetVelocity * convertVelocityOutput) / 65536; // --> high
                }
                else
                {
                    MDI_Velocity1 = (Convert.ToInt32(TargetVelocity * convertVelocityOutput) - 65536) % 65536; // --> low
                    MDI_Velocity2 = (Convert.ToInt32(TargetVelocity * convertVelocityOutput) - 65536) / 65536; // --> high         
                }
                //-----------
            }
            catch
            {
                status = "Conversion failed";
            }

            outW[0] = STW1;
            outW[1] = POS_STW1;
            outW[2] = POS_STW2;
            outW[3] = STW2;
            outW[4] = iOverride;
            outW[5] = MDI_TarPos1;
            outW[6] = MDI_TarPos2;
            outW[7] = MDI_Velocity1;
            outW[8] = MDI_Velocity2;
            outW[9] = MDI_ACC;
            outW[10] = MDI_DEC;
            outW[11] = 0;
            #endregion

            writeOutW();
        }

        private void writeOutW()
        {
            try
            {
                if (!connectionError) { queryWriteMultipleRegister(); }
            }
            catch { }
        }

        private void queryWriteMultipleRegister()
        {
            #region Data to send
            //Data to send for write multiple register
            //0  1  2  3  4  5  6  7  8  9  10 11 12 13 14
            //XX XX XX XX XX XX XX XX XX XX XX XX XX XX XX ..
            //Tid   Pid   Len   id fn offst #reg  ln data

            //Tid   --> 00 01 auto increment
            //Pid   --> 00 00
            //Len   --> 00 06
            //id    --> FF
            //fn    --> 10  --> function code 16
            //offst --> 00 00
            //#reg  --> 00 0C (for basic) 
            //ln    --> 18 --> (for basic) 24 byte to send
            //data  --> 24 bytes
            #endregion

            #region Data Query
            byte[] bQuery = new byte[13 + numRegOW * 2];

            // 13 header before data OutW
            bQuery[0] = GetUpperByte(tIDWrite);                    //Tid-H
            bQuery[1] = GetLowerByte(tIDWrite);                    //Tid-L
            bQuery[2] = 0;                                              //Pid-H
            bQuery[3] = 0;                                              //Pid-L
            bQuery[4] = GetUpperByte(7 + numRegOW * 2);                 //Len-H
            bQuery[5] = GetLowerByte(7 + numRegOW * 2);                 //Len-L
            bQuery[6] = 255;                                            //id
            bQuery[7] = 16;                                             //fn
            bQuery[8] = 0;                                              //Offset-H
            bQuery[9] = 0;                                              //Offset-L
            bQuery[10] = GetUpperByte(numRegOW);                        //#reg-H
            bQuery[11] = GetLowerByte(numRegOW);                        //#reg-L
            bQuery[12] = GetLowerByte(numRegOW * 2);                    //data lenght in byte

            int FirstData = 13;
            for (int i = 0; i < numRegOW; i++)
            {
                bQuery[FirstData] = GetUpperByte(outW[i]);
                bQuery[FirstData + 1] = GetLowerByte(outW[i]);
                FirstData = FirstData + 2;
            }
            #endregion

            string sQuery = GetHexStringfromArrayByte(bQuery, 13 + numRegOW * 2);
            statusWrite = "Query write: " + sQuery + Environment.NewLine;

            #region Query & Answer
            try
            {
                myStream.Write(bQuery, 0, Convert.ToInt32(13 + numRegOW * 2));    //13 bytes header + numreg*2 bytes
                //answerWriteHoldingRegister(numRegOW);
            }
            catch //(Exception ex)
            {
                LogData("0-Exception while query write");
                retryConnection();
            }
            #endregion

            #region Transaction Id
            tIDWrite++;
            if (tIDWrite >= 20000) { tIDWrite = 1; }
            #endregion

        }
        #endregion

        #region Update modbus time out

        private bool updateModbusTimeOut()
        {
            if (modbusTimeOutCurrent == 0)
            {
                // read modbus timeout
                queryReadHoldingRegister();
                return true;
            }
            else if (modbusTimeOutCurrent != modbusTimeOut)
            {
                // write modbus timeout
                if (queryWriteSingleRegister() == true)
                {
                    modbusTimeOutCurrent = modbusTimeOut;
                }
                return true;
            }
            return false;
        }

        // to read current modbus time out, Read: FC3 offset: 400
        private void queryReadHoldingRegister()
        {
            #region Data to send
            //Data to send for read holding register
            //0  1  2  3  4  5  6  7  8  9  10 11
            //XX XX XX XX XX XX XX XX XX XX XX XX 
            //Tid   Pid   Len   id fn offst #reg

            //Tid   --> 00 01 auto increment
            //Pid   --> 00 00
            //Len   --> 00 06
            //id    --> FF
            //fn    --> 03
            //offst --> 01 90 --> 400
            //#reg  --> 00 01
            #endregion

            #region Data Query
            byte[] bQuery = new byte[12];
            int numReg = 1;

            bQuery[0] = GetUpperByte(tIDWrite);                    //Tid-H
            bQuery[1] = GetLowerByte(tIDWrite);                    //Tid-L
            bQuery[2] = 0;                                              //Pid-H
            bQuery[3] = 0;                                              //Pid-L
            bQuery[4] = 0;                                              //Len-H
            bQuery[5] = 6;                                              //Len-L
            bQuery[6] = 255;                                            //id
            bQuery[7] = 3;                                              //fn
            bQuery[8] = GetUpperByte(400);                              //Offset-H
            bQuery[9] = GetLowerByte(400);                              //Offset-L
            bQuery[10] = GetUpperByte(numReg);                          //#reg-H
            bQuery[11] = GetLowerByte(numReg);                          //#reg-L
            #endregion

            string sQuery = GetHexStringfromArrayByte(bQuery, 12);
            statusRead = "Query read: " + sQuery + Environment.NewLine;

            #region Query & Answer
            try
            {
                myStream.Write(bQuery, 0, 12);                          //12--> send 12 bytes
                //answerReadHoldingRegister(numReg);
            }
            catch //(Exception ex)
            {
                LogData("0-Exception while query read modbus");
                retryConnection();
            }
            #endregion

            #region Transaction Id
            tIDWrite++;
            if (tIDWrite >= 20000) { tIDWrite = 1; }
            #endregion

        }

        // to write modbus time out, Write: FC6 offset: 400
        private bool queryWriteSingleRegister()
        {
            #region Data to send
            //Data to send for write multiple register
            //0  1  2  3  4  5  6  7  8  9  10 11 
            //XX XX XX XX XX XX XX XX XX XX XX XX ..
            //Tid   Pid   Len   id fn offst data

            //Tid   --> 00 01 auto increment
            //Pid   --> 00 00
            //Len   --> 00 06
            //id    --> FF
            //fn    --> 06  --> function code 6
            //offst --> 01 90 --> 400
            //data1 --> 00 --> 2 bytes
            //data2 --> 00 
            #endregion

            bool isComplete = false;

            #region Data Query

            byte[] bQuery = new byte[12];

            // 13 header before data OutW
            bQuery[0] = GetUpperByte(tIDWrite);                    //Tid-H
            bQuery[1] = GetLowerByte(tIDWrite);                    //Tid-L
            bQuery[2] = 0;                                              //Pid-H
            bQuery[3] = 0;                                              //Pid-L
            bQuery[4] = GetUpperByte(6);                   //Len-H
            bQuery[5] = GetLowerByte(6);                 //Len-L
            bQuery[6] = 255;                                            //id
            bQuery[7] = 06;                                             //fn
            bQuery[8] = GetUpperByte(400);                              //Offset-H
            bQuery[9] = GetLowerByte(400);                              //Offset-L

            int FirstData = 10;
            bQuery[FirstData] = GetUpperByte(modbusTimeOut);
            bQuery[FirstData + 1] = GetLowerByte(modbusTimeOut);

            #endregion


            string sQuery = GetHexStringfromArrayByte(bQuery, 12);
            statusWrite = "Query write: " + sQuery + Environment.NewLine;

            #region Query & Answer
            try
            {
                myStream.Write(bQuery, 0, Convert.ToInt32(12));    //13 bytes header + numreg*2 bytes
                isComplete = true; // answerWriteSingleRegister();
            }
            catch //(Exception ex)
            {
                LogData("0-Exception while query write modbus");
                retryConnection();
            }
            #endregion

            #region Transaction Id
            tIDWrite++;
            if (tIDWrite >= 20000) { tIDWrite = 1; }
            #endregion

            return isComplete;
        }


        #endregion

        #region Thread Readmb

        DateTime startReadmb = DateTime.Now;
        DateTime endReadmb;
        TimeSpan readReadmb;
        int MaxRWGap = 0;
        int MaxTIDGap = 0;
        bool xReadSleep = false;
     
        private void ReadmbThread()
        {
            while (!exitApplication)
            {
                if (connected & !connectionError) /**/
                {
                    readmbResponses();
                    icountReadmb++;
                }
                else if (connected & connectionError)
                {
                    retryConnection();  
                }

                xReadSleep = true;
                // faster cycle time when Gap between Write and read is more than 1
                if ((tIDWrite - tIDRead) > 1)
                {
                    Thread.Sleep(cycleTime/2);
                    LogData("Thread Read 2x");
                }
                else
                {
                    Thread.Sleep(cycleTime);
                }
                xReadSleep = false;

                #region Actual Readmb Time
                endReadmb = DateTime.Now;
                readReadmb = endReadmb - startReadmb;
                actualReadmbTime = Convert.ToInt32(readReadmb.TotalMilliseconds);
                if (actualReadmbTime > maxReadmbTime) { maxReadmbTime = actualReadmbTime; }

                startReadmb = DateTime.Now;
                #endregion
            
            }
        }
        #endregion

        #region Read Modbus Responses
        private void readmbResponses()
        {           
            int i = 0;
            bool xReadTimeOut = false;
            byte[] bAnswer = new byte[400]; //new byte[400];

            #region Check myStream.DataAvailable
            DateTime start = DateTime.Now;
            DateTime end;
            TimeSpan ReadTime;

            while (!myStream.DataAvailable)
            {
                end = DateTime.Now;
                ReadTime = end - start;
                actualReadTime = Convert.ToInt32(ReadTime.TotalMilliseconds);
                if (actualReadTime >= setReadTimeOut)
                {
                    counterPass++;
                    LogData("(Read) Read Time Out: " + setReadTimeOut.ToString()); //+ " | ART:" + actualReadTime.ToString() + " | CNT:" + counterPass.ToString());
                    maxReadTime = 0;
                    retryConnection();
                    xReadTimeOut = true;
                    break;
                }
            }
            if (actualReadTime > maxReadTime) { maxReadTime = actualReadTime; LogData("MRT = " + maxReadTime); }
            #endregion

            #region Read data from CMMT
            if (!xReadTimeOut)
            {
                if (myStream.DataAvailable)
                {
                    //Check incoming data
                    #region Check incoming data
                    try
                    {
                        while (i < 8) //bAnswer[7] = 04 --> read input register --> input
                                      //bAnswer[7] = 10 --> write holding register --> output
                                      //bAnswer[7] = 03 --> read holding register --> modbus time out

                        {
                            i += myStream.Read(bAnswer, i, bAnswer.Length);
                        }
                        end = DateTime.Now;
                        ReadTime = end - start;
                        actualReadTime = Convert.ToInt32(ReadTime.TotalMilliseconds);
                        tIDRead = GetWord(bAnswer[0],bAnswer[1]);
                    }
                    catch
                    {
                        LogData("(Read) ART: " + actualReadTime.ToString() + " | Data Available but Exception");
                        retryConnection();
                    }
                    #endregion 

                    // Read input 
                    #region bAnswer[7] == 04 [hex] --> read input register --> input
                    if (bAnswer[7] == 4)  
                    {
                        #region Data to receive
                        //Data to receive after read input register
                        //0  1  2  3  4  5  6  7  8  9  
                        //XX XX XX XX XX XX XX XX XX XX XX XX ....
                        //Tid   Pid   Len   id fn ln data

                        //Tid   --> 00 01 auto increment
                        //Pid   --> 00 00
                        //Len   --> 00 06
                        //id    --> FF
                        //fn    --> 04
                        //Len   --> 00
                        //data  --> 00 00 ... (as len) 
                        #endregion
                        try
                        {
                            while (i < 9 + numRegIW * 2) //9 = header
                            {
                                i += myStream.Read(bAnswer, i, bAnswer.Length);
                            }
                        }
                        catch //(Exception ex)
                        {
                            LogData("1-Exception while reading input");
                            retryConnection();
                        }

                        string sAnswer = GetHexStringfromArrayByte(bAnswer, i);
                        statusRead = statusRead + "Answer read: " + sAnswer + Environment.NewLine;

                        #region Store data to InW

                        int FirstData = 9; //first data
                        for (byte j = 0; j < bAnswer[8] / 2; j++)
                        {
                            inW[j] = GetWord(bAnswer[FirstData], bAnswer[FirstData + 1]);
                            FirstData = FirstData + 2;
                        }
                        readInW(); //store data to variable

                        #endregion
                    }
                    #endregion

                    //Response from write output 
                    #region bAnswer[7] == 10 [hex] --> write holding register --> output
                    else if (bAnswer[7] == 16)
                    {

                        #region Data to receive
                        //Data to receive after write holding register
                        //0  1  2  3  4  5  6  7  8  9  10 11
                        //XX XX XX XX XX XX XX XX XX XX XX XX ....
                        //Tid   Pid   Len   id fn Offst #reg

                        //Tid   --> 00 01 auto increment
                        //Pid   --> 00 00
                        //Len   --> 00 06
                        //id    --> FF
                        //fn    --> 10      --> function code 16
                        //Offst --> 00 00
                        //#reg  --> 00 0C   --> basic numReg = 12
                        #endregion
                        if (myStream.DataAvailable)
                        {
                            try
                            {
                                while (i < 12) // (i < 12)
                                {
                                    i += myStream.Read(bAnswer, i, bAnswer.Length);
                                }
                                end = DateTime.Now;
                                ReadTime = end - start;
                            }
                            catch //(Exception ex)
                            {
                                LogData("2-Exception while reading response from writing output");
                                retryConnection();
                            }

                            string sAnswer = GetHexStringfromArrayByte(bAnswer, i);
                            statusWrite = statusWrite + "Answer write: " + sAnswer;

                        }
                    }
                    #endregion

                    // Response from read modbus time out
                    #region bAnswer[7] == 03 [hex] --> read holding register --> modbus time out
                    else if (bAnswer[7] == 3) // = 03 [hex] --> read holding register --> modbus time out
                    {
                        #region Data to receive
                        //Data to receive after read input register
                        //0  1  2  3  4  5  6  7  8  9  
                        //XX XX XX XX XX XX XX XX XX XX XX XX ....
                        //Tid   Pid   Len   id fn ln data

                        //Tid   --> 00 01 auto increment
                        //Pid   --> 00 00
                        //Len   --> 00 05
                        //id    --> FF
                        //fn    --> 03
                        //Len   --> 00
                        //data  --> 00 00 ... (as len) 
                        #endregion
                       
                        try
                        {
                            while (i < 11) //9 = header
                            {
                                i += myStream.Read(bAnswer, i, bAnswer.Length);
                            }
                        }
                        catch //(Exception ex)
                        {
                            LogData("3-Exception while reading response from read modbus timeout");
                            retryConnection();
                        }
                        string sAnswer = GetHexStringfromArrayByte(bAnswer, i);
                        statusRead = statusRead + "Answer read: " + sAnswer + Environment.NewLine;

                        #region Store data to modbusTimeOut  
                        
                        int FirstData = 9; //first data
                        modbusTimeOutCurrent = GetWord(bAnswer[FirstData], bAnswer[FirstData + 1]);  
                        
                        #endregion
                    }
                    #endregion

                    // Response from write modbus time out
                    #region bAnswer[7] == 06 [hex] --> write multiple register --> modbus time out
                    else if (bAnswer[7] == 6) // = 06 [hex] --> write multiple register --> modbus time out
                    {
                        #region Data to receive
                        //Data to receive after read input register
                        //0  1  2  3  4  5  6  7  8  9  10 11
                        //XX XX XX XX XX XX XX XX XX XX XX XX ....
                        //Tid   Pid   Len   id fn Offst Data

                        //Tid   --> 00 01 auto incrementData
                        //Pid   --> 00 00
                        //Len   --> 00 06
                        //id    --> FF
                        //fn    --> 06      --> function code 6
                        //Offst --> 00 00
                        //Data  --> 00 01   --> 1 word 
                        #endregion
                
                        try
                        {
                            while (i < 12)
                            {
                                i += myStream.Read(bAnswer, i, bAnswer.Length);
                            }                           
                        }
                        catch //(Exception ex)
                        {
                            LogData("3-Exception while reading response from write modbus timeout");
                            retryConnection();
                        }
                        string sAnswer = GetHexStringfromArrayByte(bAnswer, i);
                        statusWrite = statusWrite + "Answer write: " + sAnswer;                             
                    }
                    #endregion

                    // Retry connection when TIDGap > 1
                    //#region Retry Connection TIDGap > 1
                    //if ((tIDWrite - tIDRead) > 1) 
                    //{
                    //    LogData("TID Gap: -" + (tIDWrite - tIDRead));
                    //    retryConnection(); 
                    //}
                    //#endregion
                }
            }
            #endregion
        }

        private void readInW()
        {
            try
            {
                #region Input
                zSW1 = inW[0];
                pOS_ZSW1 = inW[1];
                pOS_ZSW2 = inW[2];
                zSW2 = inW[3];
                mELDW = inW[4];
                xIST_A1 = inW[5];
                xIST_A2 = inW[6];
                actualPosition = (xIST_A1 + xIST_A2 * 65536) / convertPositionInput;
                nIST_B1 = inW[7];
                nIST_B2 = inW[8];
                actualVelocity = (nIST_B1 + nIST_B2 * 65536) / convertVelocityInput;
                fault_Code = inW[9];
                warn_Code = inW[10];
                #endregion

                #region bit access ZSW1;
                readytobeSwitchOn = GetBitfromInt(zSW1, 0);
                readyforOperation = GetBitfromInt(zSW1, 1);
                operationEnabled = GetBitfromInt(zSW1, 2);
                malfunctionEffective = GetBitfromInt(zSW1, 3);
                coastingActive = GetBitfromInt(zSW1, 4);        //(NC)
                fastStopActive = GetBitfromInt(zSW1, 5);        //(NC)
                switchOnLockActive = GetBitfromInt(zSW1, 6);
                warningEffective = GetBitfromInt(zSW1, 7);
                velocityInRange = GetBitfromInt(zSW1, 8);
                positionInRange = GetBitfromInt(zSW1, 8);
                guideRequired = GetBitfromInt(zSW1, 9);
                velocityComparisonValueReached = GetBitfromInt(zSW1, 10);
                targetPositionReached = velocityComparisonValueReached;
                iMPLimitNotReached = GetBitfromInt(zSW1, 11);
                referencePointSet = iMPLimitNotReached;
                holdingBrakeReleased = GetBitfromInt(zSW1, 12);
                positioningTaskActivated = holdingBrakeReleased;
                noWarningifMotorOvertemperature = GetBitfromInt(zSW1, 13);
                driveisStationary = noWarningifMotorOvertemperature;
                motorDirectionofRotation = GetBitfromInt(zSW1, 14);
                axisAccelerated = motorDirectionofRotation;
                noPowerUnitOvertemperatureWarning = GetBitfromInt(zSW1, 15);
                driveDecelerated = noPowerUnitOvertemperatureWarning;
                #endregion

                #region bit access POS_ZSW1;
                activePositioningRecordBit0 = GetBitfromInt(pOS_ZSW1, 0);
                activePositioningRecordBit1 = GetBitfromInt(pOS_ZSW1, 1);
                activePositioningRecordBit2 = GetBitfromInt(pOS_ZSW1, 2);
                activePositioningRecordBit3 = GetBitfromInt(pOS_ZSW1, 3);
                activePositioningRecordBit4 = GetBitfromInt(pOS_ZSW1, 4);
                activePositioningRecordBit5 = GetBitfromInt(pOS_ZSW1, 5);
                activePositioningRecordBit6 = GetBitfromInt(pOS_ZSW1, 6);
                activePositioningRecord = (byte)(pOS_ZSW1 >> 24);
                negativeLimitSwitchActive = GetBitfromInt(pOS_ZSW1, 8);
                positiveLimitSwitchActive = GetBitfromInt(pOS_ZSW1, 9);
                joggingActive = GetBitfromInt(pOS_ZSW1, 10);
                homingActive = GetBitfromInt(pOS_ZSW1, 11);
                positioningRecordActive = GetBitfromInt(pOS_ZSW1, 13);
                mDIActive = GetBitfromInt(pOS_ZSW1, 15);
                #endregion

                #region bit access POS_ZSW2;
                trackingModeActive = GetBitfromInt(pOS_ZSW2, 0);
                velocityLimitingActive = GetBitfromInt(pOS_ZSW2, 1);
                setPointValueStopped = GetBitfromInt(pOS_ZSW2, 2);
                driveTravelsForward = GetBitfromInt(pOS_ZSW2, 4);
                driveTravelsBackward = GetBitfromInt(pOS_ZSW2, 5);
                negativeSoftwareLimitSwitchActive = GetBitfromInt(pOS_ZSW2, 6);
                positiveSoftwareLimitSwitchActive = GetBitfromInt(pOS_ZSW2, 7);
                actualPositionLessEqualThanCamSwitch0 = GetBitfromInt(pOS_ZSW2, 8);
                actualPositionLessEqualThanCamSwitch1 = GetBitfromInt(pOS_ZSW2, 9);
                directOutput1ViaPositioningRecord = GetBitfromInt(pOS_ZSW2, 10);
                directOutput2ViaPositioningRecord = GetBitfromInt(pOS_ZSW2, 11);
                fixedStopReached = GetBitfromInt(pOS_ZSW2, 12);
                fixedStopClampingTorqueReached = GetBitfromInt(pOS_ZSW2, 13);
                travelToFixedStopActive = GetBitfromInt(pOS_ZSW2, 14);
                positionCommandActive = GetBitfromInt(pOS_ZSW2, 15);
                #endregion

            }
            catch { }
        }
        #endregion 
    }
}


