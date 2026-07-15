using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CMMTt111;

namespace CMMT_EP_ModbusTCP
{
    public partial class frCMMTModbus : Form
    {
        #region general global variable
        //bool debugActive = false;
        string unitpos = "";
        string unitvel = "";
        string CmmtStatus = "";
        //string HomingStatus = "";
        //string MoveAbsoluteStatus = "";
        //string MoveRelativeStatus = "";
        //string RecordSelectionStatus = "";
        public int cycleTime = 10;
        private int iStepTest = 0;
        #endregion

        #region global variable for CMMT
        festoCMMT festoCMMT = new festoCMMT();
        byte ExtendedIW;
        byte ExtendedOW;
        byte Mode = 1;
        byte Cmd = 0;
        bool Jog1 = false;
        bool Jog2 = false;
        #endregion 

        #region global variable for save data
        private string[] savsplit;
        #endregion

        #region function
        bool xbutton = false;
        private byte mouseLeftisDown(bool button)
        {
            bool leftClick = Control.MouseButtons == MouseButtons.Left;

            if (leftClick)
                if (button & !xbutton)
                {
                    xbutton = true;
                    return 1;  // Mouse Is clicked
                }
            if (!leftClick & xbutton)
            {
                if (!button)
                {
                    xbutton = false;
                    return 3;
                }
                else
                {
                    return 2;   // Mouse Is not clicked
                }
            }
            return 0;
        }


        #endregion

        private void FrCMMTModbus_Load(object sender, EventArgs e)
        {
            #region rearrange ui
            this.Width = 834;
            this.Height = 612;

            gbDynamic.Left = 491;
            gbSetting.Left = 491;
            gbDebug.Left = 491;
            gbDynamic.Top = 87;
            gbSetting.Top = 87;
            gbDebug.Top = 87;
            #endregion

            this.Text = "CMMT - xx - EP Modbus " + festoCMMT.Version;
            ReadSavedParameter();
            StoreSavedParameter();
        }

        private void FrCMMTModbus_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Things while closing
            WriteSavedParameter();
            festoCMMT.ExitApplication();
        }

        public frCMMTModbus()
        {
            InitializeComponent();
        }

        private void BtConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (btConnect.Text == "Connect")
                {
                    lbStatus.Text = "Connecting..";
                    ExtendedIW = byte.Parse(txExtendedIW.Text);
                    ExtendedOW = byte.Parse(txExtendedOW.Text);
                    //festoCMMT.cycleTime = cycleTime;

                    festoCMMT.Connect(txIPAddress.Text, ExtendedIW, ExtendedOW);
                    if (festoCMMT.Connected)
                    {
                        lbConnectedSince.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
                        tCycle.Enabled = true;
                    }
                    else
                    {
                        lbStatus.Text = festoCMMT.Status;
                    }
                }
                else
                {
                    festoCMMT.Disconnect();
                }
            }
            catch
            {
                tCycle.Enabled = false;
                lbStatus.Text = "Can't connect";
            }
        }

        private void TCycle_Tick(object sender, EventArgs e)
        {
            if (festoCMMT.Connected)
            {
                #region enable drive
                if (cbEnableDrive.Checked)
                {
                    string status = festoCMMT.CmmtControl(Mode, Cmd);
                    if (Cmd != 0) { Cmd = 0; } // Cmd must be reset after cmmtcontrol execute!
                    CmmtStatus = status;

                    #region Jog+ & Jog-
                    if (mouseLeftisDown(Jog1 | Jog2) == 1) // Mouse Is clicked over Jog1
                    {
                        festoCMMT.Jogging1 = Jog1;
                        festoCMMT.Jogging2 = Jog2;
                    }
                    if (mouseLeftisDown(Jog1 | Jog2) == 2) // Mouse Is not clicked over Jog1
                    {
                        festoCMMT.Jogging1 = false;
                        festoCMMT.Jogging2 = false;
                        Jog1 = false;
                        Jog2 = false;
                    }
                    #endregion                  
                }
                #endregion                                                        
            }
        }  // fast timer for control

        private void TRefresh_Tick(object sender, EventArgs e) // slow timer for display 
        {
            #region Check Connection
            try
            {
                if (festoCMMT.Connected)
                {
                    lbStatus.Text = "Connected";
                    btConnect.Text = "Disconnect";
                    gbTakeControl.Enabled = true;
                }
                else
                {
                    lbStatus.Text = "Not Connected";
                    btConnect.Text = "Connect";
                    gbTakeControl.Enabled = false;
                    cbTakeControl.Checked = false;
                    cbEnableDrive.Checked = false;
                }
            }
            catch { }
            #endregion

            #region Test sequence
            if (btStartTest.Text == "Stop") // start test
            {
                rbMoveAbsolute.Checked = true; // move absolute
                switch (iStepTest)
                {
                    case 0:
                        festoCMMT.TargetPosition = float.Parse(txTargetPosition.Text);
                        Cmd = 1;
                        iStepTest = 10;
                        break;
                    case 10:
                        if (festoCMMT.iCmmtStatus == 15302)
                        {
                            festoCMMT.TargetPosition = 0;
                            Cmd = 1;
                            iStepTest = 20;
                        }
                        break;
                    case 20:
                        if (festoCMMT.iCmmtStatus == 15302)
                        {
                            iStepTest = 0;
                        }
                        break;
                }
            }
            else //stop test
            {
                iStepTest = 0;
            }

            #endregion

            #region Send convertion and dynamic data to .dll
            try
            {
                //convertion data
                festoCMMT.ConvertPositionInput = float.Parse(txPositionInputFG.Text);
                festoCMMT.ConvertVelocityInput = float.Parse(txVelocityInputFG.Text);
                festoCMMT.ConvertPositionOutput = float.Parse(txPositionOutputFG.Text);
                festoCMMT.ConvertVelocityOutput = float.Parse(txVelocityOutputFG.Text);
                //dynamic data
                festoCMMT.Override = float.Parse(txOverride.Text);
                festoCMMT.Acceleration = float.Parse(txAcc.Text);
                festoCMMT.Deceleration = float.Parse(txDec.Text);
                if (btStartTest.Text != "Stop") { festoCMMT.TargetPosition = float.Parse(txTargetPosition.Text); }
                festoCMMT.TargetVelocity = float.Parse(txTargetVelocity.Text);
                festoCMMT.PositioningRecord = byte.Parse(txRecordSelection.Text);
                //time out
                festoCMMT.Timeout = int.Parse(txTimeOut.Text);
                festoCMMT.Timewait = int.Parse(txTimeWait.Text);
                festoCMMT.Homingtimeout = int.Parse(txHomingTimeOut.Text);
                //cycle time
                festoCMMT.CycleTime = cycleTime;
                //modbus time out
                festoCMMT.ModbusTimeOut = int.Parse(txModbusTimeOut.Text);
            }
            catch //(Exception ex)
            {
                lbStatus.Text = "Wrong convertion/dynamic data";
            }
            #endregion

            #region read actual position and velocity data

            lbActualPosition.Text = festoCMMT.ActualPosition.ToString("0.0000") + " " + unitpos;
            lbActualVelocity.Text = festoCMMT.ActualVelocity.ToString("0.0000") + " " + unitvel;

            #endregion

            #region Output stage enable / malfunction effective
            if (!festoCMMT.ReadyforOperation | festoCMMT.MalfunctionEffective)
            {
                ErrorIndicator.Visible = true;
            }
            if (festoCMMT.ReadyforOperation & !festoCMMT.MalfunctionEffective)
            {
                ErrorIndicator.Visible = false;
            }
            #endregion

            #region status
            lbStatus.Text = festoCMMT.Status;
            lbCmmtStatus.Text = "[" + festoCMMT.iCmmtStatus.ToString() + "] " + CmmtStatus;

            if (lbHidden.Visible)
            {
                lbCmmtStatus.Text = lbCmmtStatus.Text +
", CNT: " + festoCMMT.CounterPass +
" | MRT: " + festoCMMT.MaxReadTime +
" | MCTr: " + festoCMMT.MaxReadmbTime +
" | MCTw: " + festoCMMT.MaxWritembTime +
" | ART: " + festoCMMT.ActualReadTime +
" | ACTr: " + festoCMMT.ActualReadmbTime +
" | ACTw: " + festoCMMT.ActualWritembTime +
" (ms)" +
//" | R-W: " + (festoCMMT.iCountReadmb - festoCMMT.iCountWritemb) +
" | TIDGap: " + (festoCMMT.TIDRead - festoCMMT.TIDWrite);
            }
            #endregion

            MonitorIO();

            #region Hidden Setting
            try
            {
                festoCMMT.SetReadTimeOut = Int32.Parse(txHidden.Text);
            }
            catch { }
            #endregion
        }

        private void TxCycleTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(txCycleTime.Text) > 10)
                {
                    cycleTime = Int32.Parse(txCycleTime.Text);
                }
                else
                {
                    cycleTime = 10;
                }
            }
            catch { cycleTime = 10; }

            timeouttime();
            tCycle.Interval = cycleTime;
        }

        #region Monitor I/O 
        private void MonitorIO()
        {
            #region debug Raw I/O
            string sDebug = "";
            for (int i = 0; i < 12 + ExtendedIW; i++)
            {
                sDebug = sDebug + "[" + i.ToString("00") + "] " + festoCMMT.InW[i].ToString() + Environment.NewLine;
            }
            txRawIn.Text = sDebug;
            txRawIn2.Text = sDebug;

            sDebug = "";
            for (int i = 0; i < 12 + ExtendedOW; i++)
            {
                sDebug = sDebug + "[" + i.ToString("00") + "] " + festoCMMT.OutW[i].ToString() + Environment.NewLine;
            }
            txRawOut.Text = sDebug;
            txRawOut2.Text = sDebug + Environment.NewLine +
                             festoCMMT.Version + Environment.NewLine +
                             "Connect[" + festoCMMT.iRetryConnection.ToString() + "]"; ;

            #endregion

            // Output

            #region debug STW1;
            if (!cbSTW1Write.Checked)
            {
                festoCMMT.AccessOutputWord_STW1 = false;
                cbSTW1_0.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 0);
                cbSTW1_1.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 1);
                cbSTW1_2.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 2);
                cbSTW1_3.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 3);
                cbSTW1_4.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 4);
                cbSTW1_5.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 5);
                cbSTW1_6.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 6);
                cbSTW1_7.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 7);
                cbSTW1_8.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 8);
                cbSTW1_9.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 9);
                cbSTW1_10.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 10);
                cbSTW1_11.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 11);
                cbSTW1_12.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 12);
                cbSTW1_13.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 13);
                cbSTW1_14.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 14);
                cbSTW1_15.Checked = festoCMMT.GetBitfromInt(festoCMMT.STW1, 15);
            }
            else
            {
                festoCMMT.AccessOutputWord_STW1 = true;
                festoCMMT.STW1 = 1 * Convert.ToInt32(cbSTW1_0.Checked) +
                                 2 * Convert.ToInt32(cbSTW1_1.Checked) +
                                 4 * Convert.ToInt32(cbSTW1_2.Checked) +
                                 8 * Convert.ToInt32(cbSTW1_3.Checked) +
                                 16 * Convert.ToInt32(cbSTW1_4.Checked) +
                                 32 * Convert.ToInt32(cbSTW1_5.Checked) +
                                 64 * Convert.ToInt32(cbSTW1_6.Checked) +
                                 128 * Convert.ToInt32(cbSTW1_7.Checked) +
                                 256 * Convert.ToInt32(cbSTW1_8.Checked) +
                                 512 * Convert.ToInt32(cbSTW1_9.Checked) +
                                 1024 * Convert.ToInt32(cbSTW1_10.Checked) +
                                 2048 * Convert.ToInt32(cbSTW1_11.Checked) +
                                 4096 * Convert.ToInt32(cbSTW1_12.Checked) +
                                 8192 * Convert.ToInt32(cbSTW1_13.Checked) +
                                 16384 * Convert.ToInt32(cbSTW1_14.Checked) +
                                 32768 * Convert.ToInt32(cbSTW1_15.Checked);
            }
            #endregion

            #region debug POS_STW1;
            if (!cbPSTW1Write.Checked)
            {
                festoCMMT.AccessOutputWord_POS_STW1 = false;
                cbPSTW1_0.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 0);
                cbPSTW1_1.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 1);
                cbPSTW1_2.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 2);
                cbPSTW1_3.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 3);
                cbPSTW1_4.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 4);
                cbPSTW1_5.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 5);
                cbPSTW1_6.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 6);
                cbPSTW1_7.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 7);
                cbPSTW1_8.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 8);
                cbPSTW1_9.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 9);
                cbPSTW1_10.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 10);
                cbPSTW1_11.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 11);
                cbPSTW1_12.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 12);
                cbPSTW1_13.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 13);
                cbPSTW1_14.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 14);
                cbPSTW1_15.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW1, 15);
            }
            else
            {
                festoCMMT.AccessOutputWord_POS_STW1 = true;
                festoCMMT.POS_STW1 = 1 * Convert.ToInt32(cbPSTW1_0.Checked) +
                                     2 * Convert.ToInt32(cbPSTW1_1.Checked) +
                                     4 * Convert.ToInt32(cbPSTW1_2.Checked) +
                                     8 * Convert.ToInt32(cbPSTW1_3.Checked) +
                                     16 * Convert.ToInt32(cbPSTW1_4.Checked) +
                                     32 * Convert.ToInt32(cbPSTW1_5.Checked) +
                                     64 * Convert.ToInt32(cbPSTW1_6.Checked) +
                                     128 * Convert.ToInt32(cbPSTW1_7.Checked) +
                                     256 * Convert.ToInt32(cbPSTW1_8.Checked) +
                                     512 * Convert.ToInt32(cbPSTW1_9.Checked) +
                                     1024 * Convert.ToInt32(cbPSTW1_10.Checked) +
                                     2048 * Convert.ToInt32(cbPSTW1_11.Checked) +
                                     4096 * Convert.ToInt32(cbPSTW1_12.Checked) +
                                     8192 * Convert.ToInt32(cbPSTW1_13.Checked) +
                                     16384 * Convert.ToInt32(cbPSTW1_14.Checked) +
                                     32768 * Convert.ToInt32(cbPSTW1_15.Checked);
            }
            #endregion

            #region debug POS_STW2;
            if (!cbPSTW2Write.Checked)
            {
                festoCMMT.AccessOutputWord_POS_STW2 = false;
                cbPSTW2_0.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 0);
                cbPSTW2_1.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 1);
                cbPSTW2_2.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 2);
                cbPSTW2_3.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 3);
                cbPSTW2_4.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 4);
                cbPSTW2_5.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 5);
                cbPSTW2_6.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 6);
                cbPSTW2_7.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 7);
                cbPSTW2_8.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 8);
                cbPSTW2_9.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 9);
                cbPSTW2_10.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 10);
                cbPSTW2_11.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 11);
                cbPSTW2_12.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 12);
                cbPSTW2_13.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 13);
                cbPSTW2_14.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 14);
                cbPSTW2_15.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_STW2, 15);
            }
            else
            {
                festoCMMT.AccessOutputWord_POS_STW2 = true;
                festoCMMT.POS_STW2 = 1 * Convert.ToInt32(cbPSTW2_0.Checked) +
                                     2 * Convert.ToInt32(cbPSTW2_1.Checked) +
                                     4 * Convert.ToInt32(cbPSTW2_2.Checked) +
                                     8 * Convert.ToInt32(cbPSTW2_3.Checked) +
                                     16 * Convert.ToInt32(cbPSTW2_4.Checked) +
                                     32 * Convert.ToInt32(cbPSTW2_5.Checked) +
                                     64 * Convert.ToInt32(cbPSTW2_6.Checked) +
                                     128 * Convert.ToInt32(cbPSTW2_7.Checked) +
                                     256 * Convert.ToInt32(cbPSTW2_8.Checked) +
                                     512 * Convert.ToInt32(cbPSTW2_9.Checked) +
                                     1024 * Convert.ToInt32(cbPSTW2_10.Checked) +
                                     2048 * Convert.ToInt32(cbPSTW2_11.Checked) +
                                     4096 * Convert.ToInt32(cbPSTW2_12.Checked) +
                                     8192 * Convert.ToInt32(cbPSTW2_13.Checked) +
                                     16384 * Convert.ToInt32(cbPSTW2_14.Checked) +
                                     32768 * Convert.ToInt32(cbPSTW2_15.Checked);
            }
            #endregion          

            // Input

            #region debug ZSW1;
            cbZSW1_0.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 0);
            cbZSW1_1.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 1);
            cbZSW1_2.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 2);
            cbZSW1_3.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 3);
            cbZSW1_4.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 4);
            cbZSW1_5.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 5);
            cbZSW1_6.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 6);
            cbZSW1_7.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 7);
            cbZSW1_8.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 8);
            cbZSW1_9.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 9);
            cbZSW1_10.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 10);
            cbZSW1_11.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 11);
            cbZSW1_12.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 12);
            cbZSW1_13.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 13);
            cbZSW1_14.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 14);
            cbZSW1_15.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 15);
            #endregion

            #region debug POS_ZSW1;
            cbPZSW1_0.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 0);
            cbPZSW1_1.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 1);
            cbPZSW1_2.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 2);
            cbPZSW1_3.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 3);
            cbPZSW1_4.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 4);
            cbPZSW1_5.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 5);
            cbPZSW1_6.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 6);
            cbPZSW1_7.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 7);
            cbPZSW1_8.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 8);
            cbPZSW1_9.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 9);
            cbPZSW1_10.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 10);
            cbPZSW1_11.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 11);
            cbPZSW1_12.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 12);
            cbPZSW1_13.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 13);
            cbPZSW1_14.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 14);
            cbPZSW1_15.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 15);
            #endregion

            #region debug POS_ZSW2;
            cbPZSW2_0.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 0);
            cbPZSW2_1.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 1);
            cbPZSW2_2.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 2);
            cbPZSW2_3.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 3);
            cbPZSW2_4.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 4);
            cbPZSW2_5.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 5);
            cbPZSW2_6.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 6);
            cbPZSW2_7.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 7);
            cbPZSW2_8.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 8);
            cbPZSW2_9.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 9);
            cbPZSW2_10.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 10);
            cbPZSW2_11.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 11);
            cbPZSW2_12.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 12);
            cbPZSW2_13.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 13);
            cbPZSW2_14.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 14);
            cbPZSW2_15.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 15);
            #endregion

            #region debug ZSW1b;
            cbZSW1b_0.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 0);
            cbZSW1b_1.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 1);
            cbZSW1b_2.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 2);
            cbZSW1b_3.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 3);
            cbZSW1b_4.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 4);
            cbZSW1b_5.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 5);
            cbZSW1b_6.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 6);
            cbZSW1b_7.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 7);
            cbZSW1b_8.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 8);
            cbZSW1b_9.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 9);
            cbZSW1b_10.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 10);
            cbZSW1b_11.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 11);
            cbZSW1b_12.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 12);
            cbZSW1b_13.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 13);
            cbZSW1b_14.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 14);
            cbZSW1b_15.Checked = festoCMMT.GetBitfromInt(festoCMMT.ZSW1, 15);
            #endregion

            #region debug POS_ZSW1b;
            cbPZSW1b_0.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 0);
            cbPZSW1b_1.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 1);
            cbPZSW1b_2.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 2);
            cbPZSW1b_3.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 3);
            cbPZSW1b_4.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 4);
            cbPZSW1b_5.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 5);
            cbPZSW1b_6.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 6);
            cbPZSW1b_7.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 7);
            cbPZSW1b_8.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 8);
            cbPZSW1b_9.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 9);
            cbPZSW1b_10.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 10);
            cbPZSW1b_11.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 11);
            cbPZSW1b_12.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 12);
            cbPZSW1b_13.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 13);
            cbPZSW1b_14.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 14);
            cbPZSW1b_15.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW1, 15);
            #endregion

            #region debug POS_ZSW2b;
            cbPZSW2b_0.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 0);
            cbPZSW2b_1.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 1);
            cbPZSW2b_2.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 2);
            cbPZSW2b_3.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 3);
            cbPZSW2b_4.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 4);
            cbPZSW2b_5.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 5);
            cbPZSW2b_6.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 6);
            cbPZSW2b_7.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 7);
            cbPZSW2b_8.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 8);
            cbPZSW2b_9.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 9);
            cbPZSW2b_10.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 10);
            cbPZSW2b_11.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 11);
            cbPZSW2b_12.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 12);
            cbPZSW2b_13.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 13);
            cbPZSW2b_14.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 14);
            cbPZSW2b_15.Checked = festoCMMT.GetBitfromInt(festoCMMT.POS_ZSW2, 15);
            #endregion

            #region Extended Output;
            if (cbExtendedWrite.Checked)
            {
                festoCMMT.OutW[12] = int.Parse(txOW12.Text);
                festoCMMT.OutW[13] = int.Parse(txOW13.Text);
                festoCMMT.OutW[14] = int.Parse(txOW14.Text);
                festoCMMT.OutW[15] = int.Parse(txOW15.Text);
                festoCMMT.OutW[16] = int.Parse(txOW16.Text);
                festoCMMT.OutW[17] = int.Parse(txOW17.Text);
                festoCMMT.OutW[18] = int.Parse(txOW18.Text);
                festoCMMT.OutW[19] = int.Parse(txOW19.Text);
                festoCMMT.OutW[20] = int.Parse(txOW20.Text);
                festoCMMT.OutW[21] = int.Parse(txOW21.Text);
                festoCMMT.OutW[22] = int.Parse(txOW22.Text);
                festoCMMT.OutW[23] = int.Parse(txOW23.Text);
            }
            #endregion
        }
        #endregion

        #region savesettingdata
        private void ReadSavedParameter()
        {
            try
            {
                using (StreamReader readtext = new StreamReader("savcmmt.mrh"))
                {
                    string sav = readtext.ReadToEnd();
                    savsplit = sav.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                }
            }
            catch { }
        }
        private void StoreSavedParameter()
        {
            try
            {
                txIPAddress.Text = savsplit[0];
                txCycleTime.Text = savsplit[1];
                cycleTime = int.Parse(txCycleTime.Text);
                txExtendedIW.Text = savsplit[2];
                txExtendedOW.Text = savsplit[3];
                txPositionInputFG.Text = savsplit[4];
                txVelocityInputFG.Text = savsplit[5];
                txPositionOutputFG.Text = savsplit[6];
                txVelocityOutputFG.Text = savsplit[7];
                txOverride.Text = savsplit[8];
                txAcc.Text = savsplit[9];
                txDec.Text = savsplit[10];
                txUnitPos.Text = savsplit[11];
                lbUnitPos.Text = savsplit[11];
                unitpos = savsplit[11];
                txUnitVel.Text = savsplit[12];
                lbUnitVel.Text = savsplit[12];
                unitvel = savsplit[12];
                txTimeOut.Text = savsplit[13];
                txTimeWait.Text = savsplit[14];
                txHomingTimeOut.Text = savsplit[15];
                txModbusTimeOut.Text = savsplit[16];
                timeouttime();
                tCycle.Interval = cycleTime;
                //cbUploadPath.Checked = bool.Parse(savsplit[16]);
                //cbPath.SelectedIndex = int.Parse(savsplit[17]);            
            }
            catch { }
        }
        private void WriteSavedParameter()
        {
            try
            {
                savsplit[0] = txIPAddress.Text;
                savsplit[1] = txCycleTime.Text;
                savsplit[2] = txExtendedIW.Text;
                savsplit[3] = txExtendedOW.Text;
                savsplit[4] = txPositionInputFG.Text;
                savsplit[5] = txVelocityInputFG.Text;
                savsplit[6] = txPositionOutputFG.Text;
                savsplit[7] = txVelocityOutputFG.Text;
                savsplit[8] = txOverride.Text;
                savsplit[9] = txAcc.Text;
                savsplit[10] = txDec.Text;
                savsplit[11] = txUnitPos.Text;
                savsplit[12] = txUnitVel.Text;
                savsplit[13] = txTimeOut.Text;
                savsplit[14] = txTimeWait.Text;
                savsplit[15] = txHomingTimeOut.Text;
                savsplit[16] = txModbusTimeOut.Text;
                //savsplit[16] = cbCheckLimit.Checked.ToString();
                //savsplit[17] = cbPath.SelectedIndex.ToString();
            }
            catch { }

            string sav = string.Join("\r\n", savsplit);
            using (StreamWriter writer = new StreamWriter("savcmmt.mrh"))
            {
                writer.WriteLine(sav);
            }
        }
        #endregion

        #region choose display
        private void LbDynamicPrev_Click(object sender, EventArgs e)
        {
            gbDynamic.Visible = false;
            gbSetting.Visible = false;
            gbDebug.Visible = true;
            //debugActive = true;
            gbDebug.Left = 491;
        }
        private void LbDynamicNext_Click(object sender, EventArgs e)
        {
            gbDynamic.Visible = false;
            gbSetting.Visible = true;
            gbDebug.Visible = false;
            //debugActive = false;
            gbSetting.Left = 491;
        }

        private void LbSettingPrev_Click(object sender, EventArgs e)
        {
            gbDynamic.Visible = true;
            gbSetting.Visible = false;
            gbDebug.Visible = false;
            //debugActive = false;
            gbDynamic.Left = 491;
        }

        private void LbSettingNext_Click(object sender, EventArgs e)
        {
            gbDynamic.Visible = false;
            gbSetting.Visible = false;
            gbDebug.Visible = true;
        }

        private void LbDebugPrev_Click(object sender, EventArgs e)
        {
            gbDynamic.Visible = false;
            gbSetting.Visible = true;
            gbDebug.Visible = false;
        }

        private void LbDebugNext_Click(object sender, EventArgs e)
        {
            gbDynamic.Visible = true;
            gbSetting.Visible = false;
            gbDebug.Visible = false;
        }

        private void LbExpand_Click(object sender, EventArgs e)
        {
            if (lbExpand.Text == ">>")
            {
                lbExpand.Text = "<<";
                gbMonitorInput.Visible = true;
                this.Width = 1146;
                pbFesto.Left = 969;
                lbCmmtStatus.Width = 762;
                //debugActive = true;
            }
            else
            {
                lbExpand.Text = ">>";
                gbMonitorInput.Visible = false;
                this.Width = 834;
                pbFesto.Left = 633;
                lbCmmtStatus.Width = 450;
            }
        }
        #endregion

        #region unitchange
        private void TxUnitPos_TextChanged(object sender, EventArgs e)
        {
            lbUnitPos.Text = txUnitPos.Text;
            unitpos = lbUnitPos.Text;
        }

        private void TxUnitVel_TextChanged(object sender, EventArgs e)
        {
            lbUnitVel.Text = txUnitVel.Text;
            unitvel = lbUnitVel.Text;
        }


        #endregion

        #region time out change
        private void TxTimeOut_TextChanged(object sender, EventArgs e)
        {
            timeouttime();
        }
        private void TxTimeWait_TextChanged(object sender, EventArgs e)
        {
            timeouttime();
        }
        private void TxHomingTimeOut_TextChanged(object sender, EventArgs e)
        {
            timeouttime();
        }

        private void timeouttime()
        {
            try
            {
                lbTimeOut.Text = ((float.Parse(txTimeOut.Text) * cycleTime) / 1000).ToString("0.0 sec");
                lbTimeWait.Text = ((float.Parse(txTimeWait.Text) * cycleTime) / 1000).ToString("0.0 sec");
                lbHomingTimeOut.Text = ((float.Parse(txHomingTimeOut.Text) * cycleTime) / 1000).ToString("0.0 sec");
            }
            catch { }

        }
        #endregion

        #region buttoon/check box for CMMT Control

        private void CbTakeControl_CheckedChanged(object sender, EventArgs e)
        {
            festoCMMT.PLCMasterControl = cbTakeControl.Checked;
            gbControl.Enabled = cbTakeControl.Checked;
            if (festoCMMT.ZSW1 == 0) { lbCmmtStatus.Text = "Can't read from CMMT"; }
        }

        private void CbEnableDrive_CheckedChanged(object sender, EventArgs e)
        {
            bool enableChecked = cbEnableDrive.Checked;
            festoCMMT.DriveCoast = enableChecked;
            festoCMMT.FastStop = enableChecked;
            festoCMMT.EnableOperation = enableChecked;
            if (!enableChecked) { festoCMMT.OutputStageEnable = false; } //only reset if drive is not enabled

            gbMode.Enabled = enableChecked;
            gbLimit.Enabled = enableChecked;
            gbJog.Enabled = enableChecked;
            gbTest.Enabled = enableChecked;
            btJog1.Enabled = enableChecked;
            btJog2.Enabled = enableChecked;
            btGo.Enabled = enableChecked;
            btStop.Enabled = enableChecked;
            btClear.Enabled = enableChecked;
            btAck.Enabled = enableChecked;
        }

        private void CbSoftware_CheckedChanged(object sender, EventArgs e)
        {
            festoCMMT.ActivateSoftwareLimitSwitch = cbSoftware.Checked;
        }

        private void CbHardware_CheckedChanged(object sender, EventArgs e)
        {
            festoCMMT.ActivateHardwareLimitSwitch = cbHardware.Checked;
        }

        private void BtJog1_MouseDown(object sender, MouseEventArgs e)
        {
            Jog1 = true;
        }

        private void BtJog2_MouseDown(object sender, MouseEventArgs e)
        {
            Jog2 = true;
        }

        private void BtGo_Click(object sender, EventArgs e)
        {
            Cmd = 1;
        }

        private void BtStop_Click(object sender, EventArgs e)
        {
            Cmd = 2;
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            Cmd = 3;
        }

        private void BtAck_Click(object sender, EventArgs e)
        {
            Cmd = 4;
        }

        private void RbHoming_CheckedChanged(object sender, EventArgs e)
        {
            Mode = 1;
        }

        private void RbMoveAbsolute_CheckedChanged(object sender, EventArgs e)
        {
            Mode = 2;
        }

        private void RbMoveRelative_CheckedChanged(object sender, EventArgs e)
        {
            Mode = 3;
        }

        private void RbRecordSelection_CheckedChanged(object sender, EventArgs e)
        {
            Mode = 4;
        }
        #endregion

        private void btStartTest_Click(object sender, EventArgs e)
        {
            if (btStartTest.Text == "Start")
            {
                btStartTest.Text = "Stop";
            }
            else
            {
                btStartTest.Text = "Start";
            }
        }

        frHelp frH = new frHelp();
        private void btHelp_Click(object sender, EventArgs e)
        {
            frH.Show();
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            #region Hidden Setting
            //Show-hide secret setting            
            lbHidden.Visible = !lbHidden.Visible;
            txHidden.Visible = !txHidden.Visible;
            btHidden.Visible = !btHidden.Visible;
            lbConnectedSince.Visible = !lbConnectedSince.Visible;
            #endregion
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btHidden_Click(object sender, EventArgs e)
        {
            festoCMMT.MaxReadmbTime = 0;
            festoCMMT.MaxWritembTime = 0;
            festoCMMT.MaxReadTime = 0;
            festoCMMT.CounterPass = 0;
        }

        private void lbHidden_Click(object sender, EventArgs e)
        {

        }

        private void lbDebug_Click(object sender, EventArgs e)
        {

        }

        private void pbFesto_Click(object sender, EventArgs e)
        {

        }
    }
}

