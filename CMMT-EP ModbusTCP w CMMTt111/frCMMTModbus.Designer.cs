namespace CMMT_EP_ModbusTCP
{
    partial class frCMMTModbus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCMMTModbus));
            this.btConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txExtendedOW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txExtendedIW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txIPAddress = new System.Windows.Forms.TextBox();
            this.tCycle = new System.Windows.Forms.Timer(this.components);
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.lbCmmtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbActualPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbActualVelocity = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbFesto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txRawIn = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txVelocityOutputFG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txPositionOutputFG = new System.Windows.Forms.TextBox();
            this.txVelocityInputFG = new System.Windows.Forms.TextBox();
            this.txPositionInputFG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.lbSettingPrev = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.txModbusTimeOut = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txCycleTime = new System.Windows.Forms.TextBox();
            this.lbSettingNext = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.gbTest = new System.Windows.Forms.GroupBox();
            this.btStartTest = new System.Windows.Forms.Button();
            this.gbLimit = new System.Windows.Forms.GroupBox();
            this.cbSoftware = new System.Windows.Forms.CheckBox();
            this.cbHardware = new System.Windows.Forms.CheckBox();
            this.gbJog = new System.Windows.Forms.GroupBox();
            this.btJog1 = new System.Windows.Forms.Button();
            this.btJog2 = new System.Windows.Forms.Button();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbRecordSelection = new System.Windows.Forms.RadioButton();
            this.rbMoveAbsolute = new System.Windows.Forms.RadioButton();
            this.rbMoveRelative = new System.Windows.Forms.RadioButton();
            this.rbHoming = new System.Windows.Forms.RadioButton();
            this.btAck = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btGo = new System.Windows.Forms.Button();
            this.cbEnableDrive = new System.Windows.Forms.CheckBox();
            this.ErrorIndicator = new System.Windows.Forms.Button();
            this.gbDebug = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSTW1 = new System.Windows.Forms.TabPage();
            this.cbSTW1Write = new System.Windows.Forms.CheckBox();
            this.cbSTW1_15 = new System.Windows.Forms.CheckBox();
            this.cbSTW1_14 = new System.Windows.Forms.CheckBox();
            this.cbSTW1_13 = new System.Windows.Forms.CheckBox();
            this.cbSTW1_12 = new System.Windows.Forms.CheckBox();
            this.cbSTW1_11 = new System.Windows.Forms.CheckBox();
            this.cbSTW1_10 = new System.Windows.Forms.CheckBox();
            this.cbSTW1_9 = new System.Windows.Forms.CheckBox();
            this.cbSTW1_8 = new System.Windows.Forms.CheckBox();
            this.cbSTW1_7 = new System.Windows.Forms.CheckBox();
            this.cbSTW1_6 = new System.Windows.Forms.CheckBox();
            this.cbSTW1_5 = new System.Windows.Forms.CheckBox();
            this.cbSTW1_4 = new System.Windows.Forms.CheckBox();
            this.cbSTW1_3 = new System.Windows.Forms.CheckBox();
            this.cbSTW1_2 = new System.Windows.Forms.CheckBox();
            this.cbSTW1_1 = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbSTW1_0 = new System.Windows.Forms.CheckBox();
            this.tpPSTW1 = new System.Windows.Forms.TabPage();
            this.cbPSTW1Write = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_15 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_14 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_13 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_12 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_11 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_10 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_9 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_8 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_7 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_6 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_5 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_4 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_3 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_2 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_1 = new System.Windows.Forms.CheckBox();
            this.cbPSTW1_0 = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tpPSTW2 = new System.Windows.Forms.TabPage();
            this.cbPSTW2Write = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_15 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_14 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_13 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_12 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_11 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_10 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_9 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_8 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_7 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_6 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_5 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_4 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_3 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_2 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_1 = new System.Windows.Forms.CheckBox();
            this.cbPSTW2_0 = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tpZSW1 = new System.Windows.Forms.TabPage();
            this.cbZSW1_9 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_15 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_14 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_13 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_12 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_10 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_11 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_8 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_7 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_6 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_5 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_4 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_3 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_2 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_1 = new System.Windows.Forms.CheckBox();
            this.cbZSW1_0 = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tpPZSW1 = new System.Windows.Forms.TabPage();
            this.cbPZSW1_15 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_14 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_13 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_12 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_11 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_10 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_9 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_8 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_7 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_6 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_5 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_4 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_3 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_2 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_1 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1_0 = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tpPZSW2 = new System.Windows.Forms.TabPage();
            this.cbPZSW2_15 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_14 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_13 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_12 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_11 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_10 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_9 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_8 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_7 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_6 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_5 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_4 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_3 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_2 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_1 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2_0 = new System.Windows.Forms.CheckBox();
            this.label48 = new System.Windows.Forms.Label();
            this.tpRaw = new System.Windows.Forms.TabPage();
            this.txRawOut = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tpExtOut = new System.Windows.Forms.TabPage();
            this.label44 = new System.Windows.Forms.Label();
            this.txOW23 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txOW20 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txOW22 = new System.Windows.Forms.TextBox();
            this.txOW21 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txOW19 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txOW16 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txOW18 = new System.Windows.Forms.TextBox();
            this.txOW17 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txOW15 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txOW12 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txOW14 = new System.Windows.Forms.TextBox();
            this.txOW13 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.cbExtendedWrite = new System.Windows.Forms.CheckBox();
            this.lbDebugPrev = new System.Windows.Forms.Label();
            this.lbDebugNext = new System.Windows.Forms.Label();
            this.gbDynamic = new System.Windows.Forms.GroupBox();
            this.lbHomingTimeOut = new System.Windows.Forms.Label();
            this.lbTimeWait = new System.Windows.Forms.Label();
            this.lbTimeOut = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txRecordSelection = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txHomingTimeOut = new System.Windows.Forms.TextBox();
            this.lbDynamicPrev = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbDynamicNext = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txTimeWait = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lbUnitVel = new System.Windows.Forms.Label();
            this.txTimeOut = new System.Windows.Forms.TextBox();
            this.lbUnitPos = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txUnitVel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txUnitPos = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txTargetPosition = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txTargetVelocity = new System.Windows.Forms.TextBox();
            this.txOverride = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txDec = new System.Windows.Forms.TextBox();
            this.txAcc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTakeControl = new System.Windows.Forms.CheckBox();
            this.gbConnect = new System.Windows.Forms.GroupBox();
            this.btHelp = new System.Windows.Forms.Button();
            this.gbTakeControl = new System.Windows.Forms.GroupBox();
            this.gbMonitorInput = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbZSW1b_9 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_15 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_14 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_13 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_12 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_10 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_11 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_8 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_7 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_6 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_5 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_4 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_3 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_2 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_1 = new System.Windows.Forms.CheckBox();
            this.cbZSW1b_0 = new System.Windows.Forms.CheckBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cbPZSW1b_15 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_14 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_13 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_12 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_11 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_10 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_9 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_8 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_7 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_6 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_5 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_4 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_3 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_2 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_1 = new System.Windows.Forms.CheckBox();
            this.cbPZSW1b_0 = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbPZSW2b_15 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_14 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_13 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_12 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_11 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_10 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_9 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_8 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_7 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_6 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_5 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_4 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_3 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_2 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_1 = new System.Windows.Forms.CheckBox();
            this.cbPZSW2b_0 = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txRawOut2 = new System.Windows.Forms.TextBox();
            this.txRawIn2 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lbExpand = new System.Windows.Forms.Label();
            this.tRefresh = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txHidden = new System.Windows.Forms.TextBox();
            this.lbHidden = new System.Windows.Forms.Label();
            this.btHidden = new System.Windows.Forms.Button();
            this.lbConnectedSince = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFesto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbSetting.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbTest.SuspendLayout();
            this.gbLimit.SuspendLayout();
            this.gbJog.SuspendLayout();
            this.gbMode.SuspendLayout();
            this.gbDebug.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpSTW1.SuspendLayout();
            this.tpPSTW1.SuspendLayout();
            this.tpPSTW2.SuspendLayout();
            this.tpZSW1.SuspendLayout();
            this.tpPZSW1.SuspendLayout();
            this.tpPZSW2.SuspendLayout();
            this.tpRaw.SuspendLayout();
            this.tpExtOut.SuspendLayout();
            this.gbDynamic.SuspendLayout();
            this.gbConnect.SuspendLayout();
            this.gbTakeControl.SuspendLayout();
            this.gbMonitorInput.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.BackColor = System.Drawing.SystemColors.Control;
            this.btConnect.Location = new System.Drawing.Point(56, 34);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(115, 42);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txExtendedOW);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txExtendedIW);
            this.groupBox2.Location = new System.Drawing.Point(21, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 89);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extended Parameter";
            // 
            // txExtendedOW
            // 
            this.txExtendedOW.Location = new System.Drawing.Point(144, 55);
            this.txExtendedOW.Name = "txExtendedOW";
            this.txExtendedOW.Size = new System.Drawing.Size(96, 24);
            this.txExtendedOW.TabIndex = 5;
            this.txExtendedOW.Text = "0";
            this.txExtendedOW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output Word:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input Word:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txExtendedIW
            // 
            this.txExtendedIW.Location = new System.Drawing.Point(144, 24);
            this.txExtendedIW.Name = "txExtendedIW";
            this.txExtendedIW.Size = new System.Drawing.Size(96, 24);
            this.txExtendedIW.TabIndex = 2;
            this.txExtendedIW.Text = "0";
            this.txExtendedIW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txIPAddress
            // 
            this.txIPAddress.Location = new System.Drawing.Point(144, 34);
            this.txIPAddress.Name = "txIPAddress";
            this.txIPAddress.Size = new System.Drawing.Size(96, 24);
            this.txIPAddress.TabIndex = 2;
            this.txIPAddress.Text = "127.0.0.1";
            this.txIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tCycle
            // 
            this.tCycle.Interval = 50;
            this.tCycle.Tick += new System.EventHandler(this.TCycle_Tick);
            // 
            // ssStatus
            // 
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbCmmtStatus,
            this.lbActualPosition,
            this.lbActualVelocity,
            this.lbStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 539);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(1166, 26);
            this.ssStatus.TabIndex = 5;
            this.ssStatus.Text = "statusStrip1";
            // 
            // lbCmmtStatus
            // 
            this.lbCmmtStatus.AutoSize = false;
            this.lbCmmtStatus.Name = "lbCmmtStatus";
            this.lbCmmtStatus.Size = new System.Drawing.Size(450, 20);
            this.lbCmmtStatus.Text = "CMMT status";
            this.lbCmmtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbActualPosition
            // 
            this.lbActualPosition.AutoSize = false;
            this.lbActualPosition.Name = "lbActualPosition";
            this.lbActualPosition.Size = new System.Drawing.Size(100, 20);
            this.lbActualPosition.Text = "Position";
            // 
            // lbActualVelocity
            // 
            this.lbActualVelocity.AutoSize = false;
            this.lbActualVelocity.Name = "lbActualVelocity";
            this.lbActualVelocity.Size = new System.Drawing.Size(100, 20);
            this.lbActualVelocity.Text = "Velocity";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = false;
            this.lbStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(150, 20);
            this.lbStatus.Text = "Connection Status";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbFesto
            // 
            this.pbFesto.Image = ((System.Drawing.Image)(resources.GetObject("pbFesto.Image")));
            this.pbFesto.Location = new System.Drawing.Point(653, 15);
            this.pbFesto.Name = "pbFesto";
            this.pbFesto.Size = new System.Drawing.Size(142, 53);
            this.pbFesto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFesto.TabIndex = 6;
            this.pbFesto.TabStop = false;
            this.pbFesto.Click += new System.EventHandler(this.pbFesto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(541, 42);
            this.label4.TabIndex = 5;
            this.label4.Text = "CMMT-xx-EP Modbus Control";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.DoubleClick += new System.EventHandler(this.label4_DoubleClick);
            // 
            // txRawIn
            // 
            this.txRawIn.Location = new System.Drawing.Point(6, 42);
            this.txRawIn.Multiline = true;
            this.txRawIn.Name = "txRawIn";
            this.txRawIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txRawIn.Size = new System.Drawing.Size(122, 316);
            this.txRawIn.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txVelocityOutputFG);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txPositionOutputFG);
            this.groupBox3.Controls.Add(this.txVelocityInputFG);
            this.groupBox3.Controls.Add(this.txPositionInputFG);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(21, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 161);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Factor Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Velocity Output:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txVelocityOutputFG
            // 
            this.txVelocityOutputFG.Location = new System.Drawing.Point(144, 61);
            this.txVelocityOutputFG.Name = "txVelocityOutputFG";
            this.txVelocityOutputFG.Size = new System.Drawing.Size(96, 24);
            this.txVelocityOutputFG.TabIndex = 12;
            this.txVelocityOutputFG.Text = "1000";
            this.txVelocityOutputFG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Velocity Input:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Position Output:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txPositionOutputFG
            // 
            this.txPositionOutputFG.Location = new System.Drawing.Point(144, 31);
            this.txPositionOutputFG.Name = "txPositionOutputFG";
            this.txPositionOutputFG.Size = new System.Drawing.Size(96, 24);
            this.txPositionOutputFG.TabIndex = 8;
            this.txPositionOutputFG.Text = "1000000";
            this.txPositionOutputFG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txVelocityInputFG
            // 
            this.txVelocityInputFG.Location = new System.Drawing.Point(144, 123);
            this.txVelocityInputFG.Name = "txVelocityInputFG";
            this.txVelocityInputFG.Size = new System.Drawing.Size(96, 24);
            this.txVelocityInputFG.TabIndex = 10;
            this.txVelocityInputFG.Text = "20000000";
            this.txVelocityInputFG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txPositionInputFG
            // 
            this.txPositionInputFG.Location = new System.Drawing.Point(144, 93);
            this.txPositionInputFG.Name = "txPositionInputFG";
            this.txPositionInputFG.Size = new System.Drawing.Size(96, 24);
            this.txPositionInputFG.TabIndex = 6;
            this.txPositionInputFG.Text = "1000000";
            this.txPositionInputFG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Position Input:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbSetting
            // 
            this.gbSetting.Controls.Add(this.lbSettingPrev);
            this.gbSetting.Controls.Add(this.groupBox4);
            this.gbSetting.Controls.Add(this.lbSettingNext);
            this.gbSetting.Controls.Add(this.groupBox2);
            this.gbSetting.Controls.Add(this.groupBox3);
            this.gbSetting.Location = new System.Drawing.Point(491, 87);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(304, 444);
            this.gbSetting.TabIndex = 9;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "Setting";
            // 
            // lbSettingPrev
            // 
            this.lbSettingPrev.AutoSize = true;
            this.lbSettingPrev.Location = new System.Drawing.Point(244, 21);
            this.lbSettingPrev.Name = "lbSettingPrev";
            this.lbSettingPrev.Size = new System.Drawing.Size(26, 18);
            this.lbSettingPrev.TabIndex = 35;
            this.lbSettingPrev.Text = "<<";
            this.lbSettingPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSettingPrev.Click += new System.EventHandler(this.LbSettingPrev_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label51);
            this.groupBox4.Controls.Add(this.label50);
            this.groupBox4.Controls.Add(this.txModbusTimeOut);
            this.groupBox4.Controls.Add(this.label49);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txCycleTime);
            this.groupBox4.Controls.Add(this.txIPAddress);
            this.groupBox4.Location = new System.Drawing.Point(21, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 131);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connection";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(216, 96);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(29, 18);
            this.label51.TabIndex = 11;
            this.label51.Text = "ms";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(216, 67);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(29, 18);
            this.label50.TabIndex = 10;
            this.label50.Text = "ms";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txModbusTimeOut
            // 
            this.txModbusTimeOut.Location = new System.Drawing.Point(144, 94);
            this.txModbusTimeOut.Name = "txModbusTimeOut";
            this.txModbusTimeOut.Size = new System.Drawing.Size(66, 24);
            this.txModbusTimeOut.TabIndex = 9;
            this.txModbusTimeOut.Text = "100";
            this.txModbusTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(14, 96);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(124, 18);
            this.label49.TabIndex = 8;
            this.label49.Text = "Modbus Timeout:";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cycle Time:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txCycleTime
            // 
            this.txCycleTime.Location = new System.Drawing.Point(144, 64);
            this.txCycleTime.Name = "txCycleTime";
            this.txCycleTime.Size = new System.Drawing.Size(66, 24);
            this.txCycleTime.TabIndex = 6;
            this.txCycleTime.Text = "50";
            this.txCycleTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txCycleTime.TextChanged += new System.EventHandler(this.TxCycleTime_TextChanged);
            // 
            // lbSettingNext
            // 
            this.lbSettingNext.AutoSize = true;
            this.lbSettingNext.Location = new System.Drawing.Point(268, 21);
            this.lbSettingNext.Name = "lbSettingNext";
            this.lbSettingNext.Size = new System.Drawing.Size(26, 18);
            this.lbSettingNext.TabIndex = 34;
            this.lbSettingNext.Text = ">>";
            this.lbSettingNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSettingNext.Click += new System.EventHandler(this.LbSettingNext_Click);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.gbTest);
            this.gbControl.Controls.Add(this.gbLimit);
            this.gbControl.Controls.Add(this.gbJog);
            this.gbControl.Controls.Add(this.gbMode);
            this.gbControl.Controls.Add(this.btAck);
            this.gbControl.Controls.Add(this.btClear);
            this.gbControl.Controls.Add(this.btStop);
            this.gbControl.Controls.Add(this.btGo);
            this.gbControl.Controls.Add(this.cbEnableDrive);
            this.gbControl.Controls.Add(this.ErrorIndicator);
            this.gbControl.Enabled = false;
            this.gbControl.Location = new System.Drawing.Point(20, 185);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(465, 346);
            this.gbControl.TabIndex = 3;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // gbTest
            // 
            this.gbTest.Controls.Add(this.btStartTest);
            this.gbTest.Enabled = false;
            this.gbTest.Location = new System.Drawing.Point(354, 143);
            this.gbTest.Name = "gbTest";
            this.gbTest.Size = new System.Drawing.Size(98, 86);
            this.gbTest.TabIndex = 47;
            this.gbTest.TabStop = false;
            this.gbTest.Text = "Test";
            // 
            // btStartTest
            // 
            this.btStartTest.BackColor = System.Drawing.SystemColors.Control;
            this.btStartTest.Location = new System.Drawing.Point(24, 20);
            this.btStartTest.Name = "btStartTest";
            this.btStartTest.Size = new System.Drawing.Size(54, 54);
            this.btStartTest.TabIndex = 19;
            this.btStartTest.Text = "Start";
            this.btStartTest.UseVisualStyleBackColor = true;
            this.btStartTest.Click += new System.EventHandler(this.btStartTest_Click);
            // 
            // gbLimit
            // 
            this.gbLimit.Controls.Add(this.cbSoftware);
            this.gbLimit.Controls.Add(this.cbHardware);
            this.gbLimit.Enabled = false;
            this.gbLimit.Location = new System.Drawing.Point(201, 61);
            this.gbLimit.Name = "gbLimit";
            this.gbLimit.Size = new System.Drawing.Size(251, 76);
            this.gbLimit.TabIndex = 19;
            this.gbLimit.TabStop = false;
            this.gbLimit.Text = "Position limit switch";
            // 
            // cbSoftware
            // 
            this.cbSoftware.AutoSize = true;
            this.cbSoftware.Location = new System.Drawing.Point(35, 35);
            this.cbSoftware.Name = "cbSoftware";
            this.cbSoftware.Size = new System.Drawing.Size(89, 22);
            this.cbSoftware.TabIndex = 18;
            this.cbSoftware.Text = "Software";
            this.cbSoftware.UseVisualStyleBackColor = true;
            this.cbSoftware.CheckedChanged += new System.EventHandler(this.CbSoftware_CheckedChanged);
            // 
            // cbHardware
            // 
            this.cbHardware.AutoSize = true;
            this.cbHardware.Location = new System.Drawing.Point(133, 36);
            this.cbHardware.Name = "cbHardware";
            this.cbHardware.Size = new System.Drawing.Size(94, 22);
            this.cbHardware.TabIndex = 17;
            this.cbHardware.Text = "Hardware";
            this.cbHardware.UseVisualStyleBackColor = true;
            this.cbHardware.CheckedChanged += new System.EventHandler(this.CbHardware_CheckedChanged);
            // 
            // gbJog
            // 
            this.gbJog.Controls.Add(this.btJog1);
            this.gbJog.Controls.Add(this.btJog2);
            this.gbJog.Enabled = false;
            this.gbJog.Location = new System.Drawing.Point(201, 143);
            this.gbJog.Name = "gbJog";
            this.gbJog.Size = new System.Drawing.Size(147, 87);
            this.gbJog.TabIndex = 16;
            this.gbJog.TabStop = false;
            this.gbJog.Text = "Jog";
            // 
            // btJog1
            // 
            this.btJog1.BackColor = System.Drawing.SystemColors.Control;
            this.btJog1.Enabled = false;
            this.btJog1.Location = new System.Drawing.Point(78, 20);
            this.btJog1.Name = "btJog1";
            this.btJog1.Size = new System.Drawing.Size(54, 54);
            this.btJog1.TabIndex = 18;
            this.btJog1.Text = "Jog +";
            this.btJog1.UseVisualStyleBackColor = true;
            this.btJog1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtJog1_MouseDown);
            // 
            // btJog2
            // 
            this.btJog2.BackColor = System.Drawing.SystemColors.Control;
            this.btJog2.Enabled = false;
            this.btJog2.Location = new System.Drawing.Point(18, 20);
            this.btJog2.Name = "btJog2";
            this.btJog2.Size = new System.Drawing.Size(54, 54);
            this.btJog2.TabIndex = 17;
            this.btJog2.Text = "Jog -";
            this.btJog2.UseVisualStyleBackColor = true;
            this.btJog2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtJog2_MouseDown);
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbRecordSelection);
            this.gbMode.Controls.Add(this.rbMoveAbsolute);
            this.gbMode.Controls.Add(this.rbMoveRelative);
            this.gbMode.Controls.Add(this.rbHoming);
            this.gbMode.Enabled = false;
            this.gbMode.Location = new System.Drawing.Point(14, 61);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(181, 169);
            this.gbMode.TabIndex = 15;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Mode";
            // 
            // rbRecordSelection
            // 
            this.rbRecordSelection.AutoSize = true;
            this.rbRecordSelection.Location = new System.Drawing.Point(27, 116);
            this.rbRecordSelection.Name = "rbRecordSelection";
            this.rbRecordSelection.Size = new System.Drawing.Size(141, 22);
            this.rbRecordSelection.TabIndex = 14;
            this.rbRecordSelection.Text = "Record selection";
            this.rbRecordSelection.UseVisualStyleBackColor = true;
            this.rbRecordSelection.CheckedChanged += new System.EventHandler(this.RbRecordSelection_CheckedChanged);
            // 
            // rbMoveAbsolute
            // 
            this.rbMoveAbsolute.AutoSize = true;
            this.rbMoveAbsolute.Location = new System.Drawing.Point(27, 62);
            this.rbMoveAbsolute.Name = "rbMoveAbsolute";
            this.rbMoveAbsolute.Size = new System.Drawing.Size(126, 22);
            this.rbMoveAbsolute.TabIndex = 12;
            this.rbMoveAbsolute.Text = "Move absolute";
            this.rbMoveAbsolute.UseVisualStyleBackColor = true;
            this.rbMoveAbsolute.CheckedChanged += new System.EventHandler(this.RbMoveAbsolute_CheckedChanged);
            // 
            // rbMoveRelative
            // 
            this.rbMoveRelative.AutoSize = true;
            this.rbMoveRelative.Location = new System.Drawing.Point(27, 89);
            this.rbMoveRelative.Name = "rbMoveRelative";
            this.rbMoveRelative.Size = new System.Drawing.Size(116, 22);
            this.rbMoveRelative.TabIndex = 13;
            this.rbMoveRelative.Text = "Move relative";
            this.rbMoveRelative.UseVisualStyleBackColor = true;
            this.rbMoveRelative.CheckedChanged += new System.EventHandler(this.RbMoveRelative_CheckedChanged);
            // 
            // rbHoming
            // 
            this.rbHoming.AutoSize = true;
            this.rbHoming.Checked = true;
            this.rbHoming.Location = new System.Drawing.Point(27, 35);
            this.rbHoming.Name = "rbHoming";
            this.rbHoming.Size = new System.Drawing.Size(81, 22);
            this.rbHoming.TabIndex = 11;
            this.rbHoming.TabStop = true;
            this.rbHoming.Text = "Homing";
            this.rbHoming.UseVisualStyleBackColor = true;
            this.rbHoming.CheckedChanged += new System.EventHandler(this.RbHoming_CheckedChanged);
            // 
            // btAck
            // 
            this.btAck.BackColor = System.Drawing.SystemColors.Control;
            this.btAck.Enabled = false;
            this.btAck.Location = new System.Drawing.Point(347, 236);
            this.btAck.Name = "btAck";
            this.btAck.Size = new System.Drawing.Size(105, 98);
            this.btAck.TabIndex = 10;
            this.btAck.Text = "Ack";
            this.btAck.UseVisualStyleBackColor = true;
            this.btAck.Click += new System.EventHandler(this.BtAck_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.Control;
            this.btClear.Enabled = false;
            this.btClear.Location = new System.Drawing.Point(236, 236);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(105, 98);
            this.btClear.TabIndex = 9;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.SystemColors.Control;
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(125, 236);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(105, 98);
            this.btStop.TabIndex = 8;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // btGo
            // 
            this.btGo.BackColor = System.Drawing.SystemColors.Control;
            this.btGo.Enabled = false;
            this.btGo.Location = new System.Drawing.Point(14, 236);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(105, 98);
            this.btGo.TabIndex = 7;
            this.btGo.Text = "Go";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.BtGo_Click);
            // 
            // cbEnableDrive
            // 
            this.cbEnableDrive.AutoSize = true;
            this.cbEnableDrive.Location = new System.Drawing.Point(14, 26);
            this.cbEnableDrive.Name = "cbEnableDrive";
            this.cbEnableDrive.Size = new System.Drawing.Size(110, 22);
            this.cbEnableDrive.TabIndex = 3;
            this.cbEnableDrive.Text = "Enable drive";
            this.cbEnableDrive.UseVisualStyleBackColor = true;
            this.cbEnableDrive.CheckedChanged += new System.EventHandler(this.CbEnableDrive_CheckedChanged);
            // 
            // ErrorIndicator
            // 
            this.ErrorIndicator.BackColor = System.Drawing.Color.Coral;
            this.ErrorIndicator.Location = new System.Drawing.Point(342, 231);
            this.ErrorIndicator.Name = "ErrorIndicator";
            this.ErrorIndicator.Size = new System.Drawing.Size(115, 108);
            this.ErrorIndicator.TabIndex = 14;
            this.ErrorIndicator.UseVisualStyleBackColor = false;
            this.ErrorIndicator.Visible = false;
            // 
            // gbDebug
            // 
            this.gbDebug.Controls.Add(this.tabControl1);
            this.gbDebug.Controls.Add(this.lbDebugPrev);
            this.gbDebug.Controls.Add(this.lbDebugNext);
            this.gbDebug.Location = new System.Drawing.Point(894, 33);
            this.gbDebug.Name = "gbDebug";
            this.gbDebug.Size = new System.Drawing.Size(304, 444);
            this.gbDebug.TabIndex = 9;
            this.gbDebug.TabStop = false;
            this.gbDebug.Text = "Monitor I/O";
            this.gbDebug.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSTW1);
            this.tabControl1.Controls.Add(this.tpPSTW1);
            this.tabControl1.Controls.Add(this.tpPSTW2);
            this.tabControl1.Controls.Add(this.tpZSW1);
            this.tabControl1.Controls.Add(this.tpPZSW1);
            this.tabControl1.Controls.Add(this.tpPZSW2);
            this.tabControl1.Controls.Add(this.tpRaw);
            this.tabControl1.Controls.Add(this.tpExtOut);
            this.tabControl1.Location = new System.Drawing.Point(20, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(266, 391);
            this.tabControl1.TabIndex = 14;
            // 
            // tpSTW1
            // 
            this.tpSTW1.Controls.Add(this.cbSTW1Write);
            this.tpSTW1.Controls.Add(this.cbSTW1_15);
            this.tpSTW1.Controls.Add(this.cbSTW1_14);
            this.tpSTW1.Controls.Add(this.cbSTW1_13);
            this.tpSTW1.Controls.Add(this.cbSTW1_12);
            this.tpSTW1.Controls.Add(this.cbSTW1_11);
            this.tpSTW1.Controls.Add(this.cbSTW1_10);
            this.tpSTW1.Controls.Add(this.cbSTW1_9);
            this.tpSTW1.Controls.Add(this.cbSTW1_8);
            this.tpSTW1.Controls.Add(this.cbSTW1_7);
            this.tpSTW1.Controls.Add(this.cbSTW1_6);
            this.tpSTW1.Controls.Add(this.cbSTW1_5);
            this.tpSTW1.Controls.Add(this.cbSTW1_4);
            this.tpSTW1.Controls.Add(this.cbSTW1_3);
            this.tpSTW1.Controls.Add(this.cbSTW1_2);
            this.tpSTW1.Controls.Add(this.cbSTW1_1);
            this.tpSTW1.Controls.Add(this.label22);
            this.tpSTW1.Controls.Add(this.cbSTW1_0);
            this.tpSTW1.Location = new System.Drawing.Point(4, 27);
            this.tpSTW1.Name = "tpSTW1";
            this.tpSTW1.Padding = new System.Windows.Forms.Padding(3);
            this.tpSTW1.Size = new System.Drawing.Size(258, 360);
            this.tpSTW1.TabIndex = 1;
            this.tpSTW1.Text = "STW1";
            this.tpSTW1.UseVisualStyleBackColor = true;
            // 
            // cbSTW1Write
            // 
            this.cbSTW1Write.AutoSize = true;
            this.cbSTW1Write.Location = new System.Drawing.Point(22, 8);
            this.cbSTW1Write.Name = "cbSTW1Write";
            this.cbSTW1Write.Size = new System.Drawing.Size(65, 22);
            this.cbSTW1Write.TabIndex = 69;
            this.cbSTW1Write.Text = "Write";
            this.cbSTW1Write.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_15
            // 
            this.cbSTW1_15.AutoSize = true;
            this.cbSTW1_15.Location = new System.Drawing.Point(22, 328);
            this.cbSTW1_15.Name = "cbSTW1_15";
            this.cbSTW1_15.Size = new System.Drawing.Size(35, 22);
            this.cbSTW1_15.TabIndex = 68;
            this.cbSTW1_15.Text = "-";
            this.cbSTW1_15.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_14
            // 
            this.cbSTW1_14.AutoSize = true;
            this.cbSTW1_14.Location = new System.Drawing.Point(22, 309);
            this.cbSTW1_14.Name = "cbSTW1_14";
            this.cbSTW1_14.Size = new System.Drawing.Size(35, 22);
            this.cbSTW1_14.TabIndex = 67;
            this.cbSTW1_14.Text = "-";
            this.cbSTW1_14.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_13
            // 
            this.cbSTW1_13.AutoSize = true;
            this.cbSTW1_13.Location = new System.Drawing.Point(22, 290);
            this.cbSTW1_13.Name = "cbSTW1_13";
            this.cbSTW1_13.Size = new System.Drawing.Size(160, 22);
            this.cbSTW1_13.TabIndex = 66;
            this.cbSTW1_13.Text = "Start record change";
            this.cbSTW1_13.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_12
            // 
            this.cbSTW1_12.AutoSize = true;
            this.cbSTW1_12.Location = new System.Drawing.Point(22, 271);
            this.cbSTW1_12.Name = "cbSTW1_12";
            this.cbSTW1_12.Size = new System.Drawing.Size(176, 22);
            this.cbSTW1_12.TabIndex = 65;
            this.cbSTW1_12.Text = "Release holding brake";
            this.cbSTW1_12.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_11
            // 
            this.cbSTW1_11.AutoSize = true;
            this.cbSTW1_11.Location = new System.Drawing.Point(22, 252);
            this.cbSTW1_11.Name = "cbSTW1_11";
            this.cbSTW1_11.Size = new System.Drawing.Size(217, 22);
            this.cbSTW1_11.TabIndex = 64;
            this.cbSTW1_11.Text = "Invert setpoint / Start homing";
            this.cbSTW1_11.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_10
            // 
            this.cbSTW1_10.AutoSize = true;
            this.cbSTW1_10.Location = new System.Drawing.Point(22, 233);
            this.cbSTW1_10.Name = "cbSTW1_10";
            this.cbSTW1_10.Size = new System.Drawing.Size(159, 22);
            this.cbSTW1_10.TabIndex = 63;
            this.cbSTW1_10.Text = "PLC master control";
            this.cbSTW1_10.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_9
            // 
            this.cbSTW1_9.AutoSize = true;
            this.cbSTW1_9.Location = new System.Drawing.Point(22, 214);
            this.cbSTW1_9.Name = "cbSTW1_9";
            this.cbSTW1_9.Size = new System.Drawing.Size(91, 22);
            this.cbSTW1_9.TabIndex = 62;
            this.cbSTW1_9.Text = "Jogging -";
            this.cbSTW1_9.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_8
            // 
            this.cbSTW1_8.AutoSize = true;
            this.cbSTW1_8.Location = new System.Drawing.Point(22, 195);
            this.cbSTW1_8.Name = "cbSTW1_8";
            this.cbSTW1_8.Size = new System.Drawing.Size(95, 22);
            this.cbSTW1_8.TabIndex = 61;
            this.cbSTW1_8.Text = "Jogging +";
            this.cbSTW1_8.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_7
            // 
            this.cbSTW1_7.AutoSize = true;
            this.cbSTW1_7.Location = new System.Drawing.Point(22, 175);
            this.cbSTW1_7.Name = "cbSTW1_7";
            this.cbSTW1_7.Size = new System.Drawing.Size(198, 22);
            this.cbSTW1_7.TabIndex = 52;
            this.cbSTW1_7.Text = "Acknowledge malfunction";
            this.cbSTW1_7.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_6
            // 
            this.cbSTW1_6.AutoSize = true;
            this.cbSTW1_6.Location = new System.Drawing.Point(22, 156);
            this.cbSTW1_6.Name = "cbSTW1_6";
            this.cbSTW1_6.Size = new System.Drawing.Size(220, 22);
            this.cbSTW1_6.TabIndex = 50;
            this.cbSTW1_6.Text = "Speed set / Activate pos task";
            this.cbSTW1_6.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_5
            // 
            this.cbSTW1_5.AutoSize = true;
            this.cbSTW1_5.Location = new System.Drawing.Point(22, 137);
            this.cbSTW1_5.Name = "cbSTW1_5";
            this.cbSTW1_5.Size = new System.Drawing.Size(224, 22);
            this.cbSTW1_5.TabIndex = 48;
            this.cbSTW1_5.Text = "Start ramp / Intermediate stop";
            this.cbSTW1_5.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_4
            // 
            this.cbSTW1_4.AutoSize = true;
            this.cbSTW1_4.Location = new System.Drawing.Point(22, 118);
            this.cbSTW1_4.Name = "cbSTW1_4";
            this.cbSTW1_4.Size = new System.Drawing.Size(213, 22);
            this.cbSTW1_4.TabIndex = 46;
            this.cbSTW1_4.Text = "Ramp gen / Reject pos task";
            this.cbSTW1_4.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_3
            // 
            this.cbSTW1_3.AutoSize = true;
            this.cbSTW1_3.Location = new System.Drawing.Point(22, 99);
            this.cbSTW1_3.Name = "cbSTW1_3";
            this.cbSTW1_3.Size = new System.Drawing.Size(141, 22);
            this.cbSTW1_3.TabIndex = 44;
            this.cbSTW1_3.Text = "Enable operation";
            this.cbSTW1_3.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_2
            // 
            this.cbSTW1_2.AutoSize = true;
            this.cbSTW1_2.Location = new System.Drawing.Point(22, 80);
            this.cbSTW1_2.Name = "cbSTW1_2";
            this.cbSTW1_2.Size = new System.Drawing.Size(94, 22);
            this.cbSTW1_2.TabIndex = 42;
            this.cbSTW1_2.Text = "Fast Stop";
            this.cbSTW1_2.UseVisualStyleBackColor = true;
            // 
            // cbSTW1_1
            // 
            this.cbSTW1_1.AutoSize = true;
            this.cbSTW1_1.Location = new System.Drawing.Point(22, 61);
            this.cbSTW1_1.Name = "cbSTW1_1";
            this.cbSTW1_1.Size = new System.Drawing.Size(105, 22);
            this.cbSTW1_1.TabIndex = 40;
            this.cbSTW1_1.Text = "Drive coast";
            this.cbSTW1_1.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(195, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 18);
            this.label22.TabIndex = 38;
            this.label22.Text = "Output";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSTW1_0
            // 
            this.cbSTW1_0.AutoSize = true;
            this.cbSTW1_0.Location = new System.Drawing.Point(22, 42);
            this.cbSTW1_0.Name = "cbSTW1_0";
            this.cbSTW1_0.Size = new System.Drawing.Size(161, 22);
            this.cbSTW1_0.TabIndex = 0;
            this.cbSTW1_0.Text = "Output stage enable";
            this.cbSTW1_0.UseVisualStyleBackColor = true;
            // 
            // tpPSTW1
            // 
            this.tpPSTW1.Controls.Add(this.cbPSTW1Write);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_15);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_14);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_13);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_12);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_11);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_10);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_9);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_8);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_7);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_6);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_5);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_4);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_3);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_2);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_1);
            this.tpPSTW1.Controls.Add(this.cbPSTW1_0);
            this.tpPSTW1.Controls.Add(this.label24);
            this.tpPSTW1.Location = new System.Drawing.Point(4, 27);
            this.tpPSTW1.Name = "tpPSTW1";
            this.tpPSTW1.Size = new System.Drawing.Size(258, 360);
            this.tpPSTW1.TabIndex = 3;
            this.tpPSTW1.Text = "PSTW1";
            this.tpPSTW1.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1Write
            // 
            this.cbPSTW1Write.AutoSize = true;
            this.cbPSTW1Write.Location = new System.Drawing.Point(22, 8);
            this.cbPSTW1Write.Name = "cbPSTW1Write";
            this.cbPSTW1Write.Size = new System.Drawing.Size(65, 22);
            this.cbPSTW1Write.TabIndex = 85;
            this.cbPSTW1Write.Text = "Write";
            this.cbPSTW1Write.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_15
            // 
            this.cbPSTW1_15.AutoSize = true;
            this.cbPSTW1_15.Location = new System.Drawing.Point(22, 328);
            this.cbPSTW1_15.Name = "cbPSTW1_15";
            this.cbPSTW1_15.Size = new System.Drawing.Size(120, 22);
            this.cbPSTW1_15.TabIndex = 84;
            this.cbPSTW1_15.Text = "MDI selection";
            this.cbPSTW1_15.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_14
            // 
            this.cbPSTW1_14.AutoSize = true;
            this.cbPSTW1_14.Location = new System.Drawing.Point(22, 309);
            this.cbPSTW1_14.Name = "cbPSTW1_14";
            this.cbPSTW1_14.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW1_14.TabIndex = 83;
            this.cbPSTW1_14.Text = "-";
            this.cbPSTW1_14.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_13
            // 
            this.cbPSTW1_13.AutoSize = true;
            this.cbPSTW1_13.Location = new System.Drawing.Point(22, 290);
            this.cbPSTW1_13.Name = "cbPSTW1_13";
            this.cbPSTW1_13.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW1_13.TabIndex = 82;
            this.cbPSTW1_13.Text = "-";
            this.cbPSTW1_13.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_12
            // 
            this.cbPSTW1_12.AutoSize = true;
            this.cbPSTW1_12.Location = new System.Drawing.Point(22, 271);
            this.cbPSTW1_12.Name = "cbPSTW1_12";
            this.cbPSTW1_12.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW1_12.TabIndex = 81;
            this.cbPSTW1_12.Text = "-";
            this.cbPSTW1_12.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_11
            // 
            this.cbPSTW1_11.AutoSize = true;
            this.cbPSTW1_11.Location = new System.Drawing.Point(22, 252);
            this.cbPSTW1_11.Name = "cbPSTW1_11";
            this.cbPSTW1_11.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW1_11.TabIndex = 80;
            this.cbPSTW1_11.Text = "-";
            this.cbPSTW1_11.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_10
            // 
            this.cbPSTW1_10.AutoSize = true;
            this.cbPSTW1_10.Location = new System.Drawing.Point(22, 233);
            this.cbPSTW1_10.Name = "cbPSTW1_10";
            this.cbPSTW1_10.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW1_10.TabIndex = 79;
            this.cbPSTW1_10.Text = "-";
            this.cbPSTW1_10.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_9
            // 
            this.cbPSTW1_9.AutoSize = true;
            this.cbPSTW1_9.Location = new System.Drawing.Point(22, 214);
            this.cbPSTW1_9.Name = "cbPSTW1_9";
            this.cbPSTW1_9.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW1_9.TabIndex = 78;
            this.cbPSTW1_9.Text = "-";
            this.cbPSTW1_9.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_8
            // 
            this.cbPSTW1_8.AutoSize = true;
            this.cbPSTW1_8.Location = new System.Drawing.Point(22, 195);
            this.cbPSTW1_8.Name = "cbPSTW1_8";
            this.cbPSTW1_8.Size = new System.Drawing.Size(182, 22);
            this.cbPSTW1_8.TabIndex = 77;
            this.cbPSTW1_8.Text = "Relative / Absolute (=1)";
            this.cbPSTW1_8.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_7
            // 
            this.cbPSTW1_7.AutoSize = true;
            this.cbPSTW1_7.Location = new System.Drawing.Point(22, 175);
            this.cbPSTW1_7.Name = "cbPSTW1_7";
            this.cbPSTW1_7.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW1_7.TabIndex = 76;
            this.cbPSTW1_7.Text = "-";
            this.cbPSTW1_7.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_6
            // 
            this.cbPSTW1_6.AutoSize = true;
            this.cbPSTW1_6.Location = new System.Drawing.Point(22, 156);
            this.cbPSTW1_6.Name = "cbPSTW1_6";
            this.cbPSTW1_6.Size = new System.Drawing.Size(181, 22);
            this.cbPSTW1_6.TabIndex = 75;
            this.cbPSTW1_6.Text = "Positioning record bit 6";
            this.cbPSTW1_6.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_5
            // 
            this.cbPSTW1_5.AutoSize = true;
            this.cbPSTW1_5.Location = new System.Drawing.Point(22, 137);
            this.cbPSTW1_5.Name = "cbPSTW1_5";
            this.cbPSTW1_5.Size = new System.Drawing.Size(181, 22);
            this.cbPSTW1_5.TabIndex = 74;
            this.cbPSTW1_5.Text = "Positioning record bit 5";
            this.cbPSTW1_5.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_4
            // 
            this.cbPSTW1_4.AutoSize = true;
            this.cbPSTW1_4.Location = new System.Drawing.Point(22, 118);
            this.cbPSTW1_4.Name = "cbPSTW1_4";
            this.cbPSTW1_4.Size = new System.Drawing.Size(181, 22);
            this.cbPSTW1_4.TabIndex = 73;
            this.cbPSTW1_4.Text = "Positioning record bit 4";
            this.cbPSTW1_4.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_3
            // 
            this.cbPSTW1_3.AutoSize = true;
            this.cbPSTW1_3.Location = new System.Drawing.Point(22, 99);
            this.cbPSTW1_3.Name = "cbPSTW1_3";
            this.cbPSTW1_3.Size = new System.Drawing.Size(181, 22);
            this.cbPSTW1_3.TabIndex = 72;
            this.cbPSTW1_3.Text = "Positioning record bit 3";
            this.cbPSTW1_3.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_2
            // 
            this.cbPSTW1_2.AutoSize = true;
            this.cbPSTW1_2.Location = new System.Drawing.Point(22, 80);
            this.cbPSTW1_2.Name = "cbPSTW1_2";
            this.cbPSTW1_2.Size = new System.Drawing.Size(181, 22);
            this.cbPSTW1_2.TabIndex = 71;
            this.cbPSTW1_2.Text = "Positioning record bit 2";
            this.cbPSTW1_2.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_1
            // 
            this.cbPSTW1_1.AutoSize = true;
            this.cbPSTW1_1.Location = new System.Drawing.Point(22, 61);
            this.cbPSTW1_1.Name = "cbPSTW1_1";
            this.cbPSTW1_1.Size = new System.Drawing.Size(181, 22);
            this.cbPSTW1_1.TabIndex = 70;
            this.cbPSTW1_1.Text = "Positioning record bit 1";
            this.cbPSTW1_1.UseVisualStyleBackColor = true;
            // 
            // cbPSTW1_0
            // 
            this.cbPSTW1_0.AutoSize = true;
            this.cbPSTW1_0.Location = new System.Drawing.Point(22, 42);
            this.cbPSTW1_0.Name = "cbPSTW1_0";
            this.cbPSTW1_0.Size = new System.Drawing.Size(181, 22);
            this.cbPSTW1_0.TabIndex = 69;
            this.cbPSTW1_0.Text = "Positioning record bit 0";
            this.cbPSTW1_0.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(195, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 18);
            this.label24.TabIndex = 39;
            this.label24.Text = "Output";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tpPSTW2
            // 
            this.tpPSTW2.Controls.Add(this.cbPSTW2Write);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_15);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_14);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_13);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_12);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_11);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_10);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_9);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_8);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_7);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_6);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_5);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_4);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_3);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_2);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_1);
            this.tpPSTW2.Controls.Add(this.cbPSTW2_0);
            this.tpPSTW2.Controls.Add(this.label25);
            this.tpPSTW2.Location = new System.Drawing.Point(4, 27);
            this.tpPSTW2.Name = "tpPSTW2";
            this.tpPSTW2.Size = new System.Drawing.Size(258, 360);
            this.tpPSTW2.TabIndex = 5;
            this.tpPSTW2.Text = "PSTW2";
            this.tpPSTW2.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2Write
            // 
            this.cbPSTW2Write.AutoSize = true;
            this.cbPSTW2Write.Location = new System.Drawing.Point(22, 8);
            this.cbPSTW2Write.Name = "cbPSTW2Write";
            this.cbPSTW2Write.Size = new System.Drawing.Size(65, 22);
            this.cbPSTW2Write.TabIndex = 85;
            this.cbPSTW2Write.Text = "Write";
            this.cbPSTW2Write.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_15
            // 
            this.cbPSTW2_15.AutoSize = true;
            this.cbPSTW2_15.Location = new System.Drawing.Point(22, 328);
            this.cbPSTW2_15.Name = "cbPSTW2_15";
            this.cbPSTW2_15.Size = new System.Drawing.Size(222, 22);
            this.cbPSTW2_15.TabIndex = 84;
            this.cbPSTW2_15.Text = "Activate hardware limit switch";
            this.cbPSTW2_15.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_14
            // 
            this.cbPSTW2_14.AutoSize = true;
            this.cbPSTW2_14.Location = new System.Drawing.Point(22, 309);
            this.cbPSTW2_14.Name = "cbPSTW2_14";
            this.cbPSTW2_14.Size = new System.Drawing.Size(218, 22);
            this.cbPSTW2_14.TabIndex = 83;
            this.cbPSTW2_14.Text = "Activate software limit switch";
            this.cbPSTW2_14.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_13
            // 
            this.cbPSTW2_13.AutoSize = true;
            this.cbPSTW2_13.Location = new System.Drawing.Point(22, 290);
            this.cbPSTW2_13.Name = "cbPSTW2_13";
            this.cbPSTW2_13.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW2_13.TabIndex = 82;
            this.cbPSTW2_13.Text = "-";
            this.cbPSTW2_13.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_12
            // 
            this.cbPSTW2_12.AutoSize = true;
            this.cbPSTW2_12.Location = new System.Drawing.Point(22, 271);
            this.cbPSTW2_12.Name = "cbPSTW2_12";
            this.cbPSTW2_12.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW2_12.TabIndex = 81;
            this.cbPSTW2_12.Text = "-";
            this.cbPSTW2_12.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_11
            // 
            this.cbPSTW2_11.AutoSize = true;
            this.cbPSTW2_11.Location = new System.Drawing.Point(22, 252);
            this.cbPSTW2_11.Name = "cbPSTW2_11";
            this.cbPSTW2_11.Size = new System.Drawing.Size(150, 22);
            this.cbPSTW2_11.TabIndex = 80;
            this.cbPSTW2_11.Text = "Touch probe edge";
            this.cbPSTW2_11.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_10
            // 
            this.cbPSTW2_10.AutoSize = true;
            this.cbPSTW2_10.Location = new System.Drawing.Point(22, 233);
            this.cbPSTW2_10.Name = "cbPSTW2_10";
            this.cbPSTW2_10.Size = new System.Drawing.Size(164, 22);
            this.cbPSTW2_10.TabIndex = 79;
            this.cbPSTW2_10.Text = "Touch probe source";
            this.cbPSTW2_10.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_9
            // 
            this.cbPSTW2_9.AutoSize = true;
            this.cbPSTW2_9.Location = new System.Drawing.Point(22, 214);
            this.cbPSTW2_9.Name = "cbPSTW2_9";
            this.cbPSTW2_9.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW2_9.TabIndex = 78;
            this.cbPSTW2_9.Text = "-";
            this.cbPSTW2_9.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_8
            // 
            this.cbPSTW2_8.AutoSize = true;
            this.cbPSTW2_8.Location = new System.Drawing.Point(22, 195);
            this.cbPSTW2_8.Name = "cbPSTW2_8";
            this.cbPSTW2_8.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW2_8.TabIndex = 77;
            this.cbPSTW2_8.Text = "-";
            this.cbPSTW2_8.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_7
            // 
            this.cbPSTW2_7.AutoSize = true;
            this.cbPSTW2_7.Location = new System.Drawing.Point(22, 175);
            this.cbPSTW2_7.Name = "cbPSTW2_7";
            this.cbPSTW2_7.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW2_7.TabIndex = 76;
            this.cbPSTW2_7.Text = "-";
            this.cbPSTW2_7.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_6
            // 
            this.cbPSTW2_6.AutoSize = true;
            this.cbPSTW2_6.Location = new System.Drawing.Point(22, 156);
            this.cbPSTW2_6.Name = "cbPSTW2_6";
            this.cbPSTW2_6.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW2_6.TabIndex = 75;
            this.cbPSTW2_6.Text = "-";
            this.cbPSTW2_6.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_5
            // 
            this.cbPSTW2_5.AutoSize = true;
            this.cbPSTW2_5.Location = new System.Drawing.Point(22, 137);
            this.cbPSTW2_5.Name = "cbPSTW2_5";
            this.cbPSTW2_5.Size = new System.Drawing.Size(157, 22);
            this.cbPSTW2_5.TabIndex = 74;
            this.cbPSTW2_5.Text = "Incremental jogging";
            this.cbPSTW2_5.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_4
            // 
            this.cbPSTW2_4.AutoSize = true;
            this.cbPSTW2_4.Location = new System.Drawing.Point(22, 118);
            this.cbPSTW2_4.Name = "cbPSTW2_4";
            this.cbPSTW2_4.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW2_4.TabIndex = 73;
            this.cbPSTW2_4.Text = "-";
            this.cbPSTW2_4.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_3
            // 
            this.cbPSTW2_3.AutoSize = true;
            this.cbPSTW2_3.Location = new System.Drawing.Point(22, 99);
            this.cbPSTW2_3.Name = "cbPSTW2_3";
            this.cbPSTW2_3.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW2_3.TabIndex = 72;
            this.cbPSTW2_3.Text = "-";
            this.cbPSTW2_3.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_2
            // 
            this.cbPSTW2_2.AutoSize = true;
            this.cbPSTW2_2.Location = new System.Drawing.Point(22, 80);
            this.cbPSTW2_2.Name = "cbPSTW2_2";
            this.cbPSTW2_2.Size = new System.Drawing.Size(35, 22);
            this.cbPSTW2_2.TabIndex = 71;
            this.cbPSTW2_2.Text = "-";
            this.cbPSTW2_2.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_1
            // 
            this.cbPSTW2_1.AutoSize = true;
            this.cbPSTW2_1.Location = new System.Drawing.Point(22, 61);
            this.cbPSTW2_1.Name = "cbPSTW2_1";
            this.cbPSTW2_1.Size = new System.Drawing.Size(197, 22);
            this.cbPSTW2_1.TabIndex = 70;
            this.cbPSTW2_1.Text = "Current position as home";
            this.cbPSTW2_1.UseVisualStyleBackColor = true;
            // 
            // cbPSTW2_0
            // 
            this.cbPSTW2_0.AutoSize = true;
            this.cbPSTW2_0.Location = new System.Drawing.Point(22, 42);
            this.cbPSTW2_0.Name = "cbPSTW2_0";
            this.cbPSTW2_0.Size = new System.Drawing.Size(129, 22);
            this.cbPSTW2_0.TabIndex = 69;
            this.cbPSTW2_0.Text = "Tracking mode";
            this.cbPSTW2_0.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(195, 8);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 18);
            this.label25.TabIndex = 39;
            this.label25.Text = "Output";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tpZSW1
            // 
            this.tpZSW1.Controls.Add(this.cbZSW1_9);
            this.tpZSW1.Controls.Add(this.cbZSW1_15);
            this.tpZSW1.Controls.Add(this.cbZSW1_14);
            this.tpZSW1.Controls.Add(this.cbZSW1_13);
            this.tpZSW1.Controls.Add(this.cbZSW1_12);
            this.tpZSW1.Controls.Add(this.cbZSW1_10);
            this.tpZSW1.Controls.Add(this.cbZSW1_11);
            this.tpZSW1.Controls.Add(this.cbZSW1_8);
            this.tpZSW1.Controls.Add(this.cbZSW1_7);
            this.tpZSW1.Controls.Add(this.cbZSW1_6);
            this.tpZSW1.Controls.Add(this.cbZSW1_5);
            this.tpZSW1.Controls.Add(this.cbZSW1_4);
            this.tpZSW1.Controls.Add(this.cbZSW1_3);
            this.tpZSW1.Controls.Add(this.cbZSW1_2);
            this.tpZSW1.Controls.Add(this.cbZSW1_1);
            this.tpZSW1.Controls.Add(this.cbZSW1_0);
            this.tpZSW1.Controls.Add(this.label23);
            this.tpZSW1.Location = new System.Drawing.Point(4, 27);
            this.tpZSW1.Name = "tpZSW1";
            this.tpZSW1.Size = new System.Drawing.Size(258, 360);
            this.tpZSW1.TabIndex = 2;
            this.tpZSW1.Text = "ZSW1";
            this.tpZSW1.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_9
            // 
            this.cbZSW1_9.AutoSize = true;
            this.cbZSW1_9.Location = new System.Drawing.Point(22, 214);
            this.cbZSW1_9.Name = "cbZSW1_9";
            this.cbZSW1_9.Size = new System.Drawing.Size(126, 22);
            this.cbZSW1_9.TabIndex = 84;
            this.cbZSW1_9.Text = "Guide required";
            this.cbZSW1_9.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_15
            // 
            this.cbZSW1_15.AutoSize = true;
            this.cbZSW1_15.Location = new System.Drawing.Point(22, 328);
            this.cbZSW1_15.Name = "cbZSW1_15";
            this.cbZSW1_15.Size = new System.Drawing.Size(230, 22);
            this.cbZSW1_15.TabIndex = 83;
            this.cbZSW1_15.Text = "No temp warning / decelerated";
            this.cbZSW1_15.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_14
            // 
            this.cbZSW1_14.AutoSize = true;
            this.cbZSW1_14.Location = new System.Drawing.Point(22, 309);
            this.cbZSW1_14.Name = "cbZSW1_14";
            this.cbZSW1_14.Size = new System.Drawing.Size(218, 22);
            this.cbZSW1_14.TabIndex = 82;
            this.cbZSW1_14.Text = "Motor direction / accelerated";
            this.cbZSW1_14.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_13
            // 
            this.cbZSW1_13.AutoSize = true;
            this.cbZSW1_13.Location = new System.Drawing.Point(22, 290);
            this.cbZSW1_13.Name = "cbZSW1_13";
            this.cbZSW1_13.Size = new System.Drawing.Size(225, 22);
            this.cbZSW1_13.TabIndex = 81;
            this.cbZSW1_13.Text = "No overheat / Drive stationary";
            this.cbZSW1_13.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_12
            // 
            this.cbZSW1_12.AutoSize = true;
            this.cbZSW1_12.Location = new System.Drawing.Point(22, 271);
            this.cbZSW1_12.Name = "cbZSW1_12";
            this.cbZSW1_12.Size = new System.Drawing.Size(185, 22);
            this.cbZSW1_12.TabIndex = 80;
            this.cbZSW1_12.Text = "Positioning task actived";
            this.cbZSW1_12.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_10
            // 
            this.cbZSW1_10.AutoSize = true;
            this.cbZSW1_10.Location = new System.Drawing.Point(22, 233);
            this.cbZSW1_10.Name = "cbZSW1_10";
            this.cbZSW1_10.Size = new System.Drawing.Size(188, 22);
            this.cbZSW1_10.TabIndex = 79;
            this.cbZSW1_10.Text = "Target vel / pos reached";
            this.cbZSW1_10.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_11
            // 
            this.cbZSW1_11.AutoSize = true;
            this.cbZSW1_11.Location = new System.Drawing.Point(22, 252);
            this.cbZSW1_11.Name = "cbZSW1_11";
            this.cbZSW1_11.Size = new System.Drawing.Size(229, 22);
            this.cbZSW1_11.TabIndex = 78;
            this.cbZSW1_11.Text = "IMP limit not reached / Homed";
            this.cbZSW1_11.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_8
            // 
            this.cbZSW1_8.AutoSize = true;
            this.cbZSW1_8.Location = new System.Drawing.Point(22, 195);
            this.cbZSW1_8.Name = "cbZSW1_8";
            this.cbZSW1_8.Size = new System.Drawing.Size(203, 22);
            this.cbZSW1_8.TabIndex = 77;
            this.cbZSW1_8.Text = "Velocity / Position in range";
            this.cbZSW1_8.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_7
            // 
            this.cbZSW1_7.AutoSize = true;
            this.cbZSW1_7.Location = new System.Drawing.Point(22, 175);
            this.cbZSW1_7.Name = "cbZSW1_7";
            this.cbZSW1_7.Size = new System.Drawing.Size(143, 22);
            this.cbZSW1_7.TabIndex = 76;
            this.cbZSW1_7.Text = "Warning effective";
            this.cbZSW1_7.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_6
            // 
            this.cbZSW1_6.AutoSize = true;
            this.cbZSW1_6.Location = new System.Drawing.Point(22, 156);
            this.cbZSW1_6.Name = "cbZSW1_6";
            this.cbZSW1_6.Size = new System.Drawing.Size(169, 22);
            this.cbZSW1_6.TabIndex = 75;
            this.cbZSW1_6.Text = "Switch on lock active";
            this.cbZSW1_6.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_5
            // 
            this.cbZSW1_5.AutoSize = true;
            this.cbZSW1_5.Location = new System.Drawing.Point(22, 137);
            this.cbZSW1_5.Name = "cbZSW1_5";
            this.cbZSW1_5.Size = new System.Drawing.Size(170, 22);
            this.cbZSW1_5.TabIndex = 74;
            this.cbZSW1_5.Text = "Fast stop active (NC)";
            this.cbZSW1_5.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_4
            // 
            this.cbZSW1_4.AutoSize = true;
            this.cbZSW1_4.Location = new System.Drawing.Point(22, 118);
            this.cbZSW1_4.Name = "cbZSW1_4";
            this.cbZSW1_4.Size = new System.Drawing.Size(167, 22);
            this.cbZSW1_4.TabIndex = 73;
            this.cbZSW1_4.Text = "Coasting active (NC)";
            this.cbZSW1_4.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_3
            // 
            this.cbZSW1_3.AutoSize = true;
            this.cbZSW1_3.Location = new System.Drawing.Point(22, 99);
            this.cbZSW1_3.Name = "cbZSW1_3";
            this.cbZSW1_3.Size = new System.Drawing.Size(164, 22);
            this.cbZSW1_3.TabIndex = 72;
            this.cbZSW1_3.Text = "Mulfunction effective";
            this.cbZSW1_3.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_2
            // 
            this.cbZSW1_2.AutoSize = true;
            this.cbZSW1_2.Location = new System.Drawing.Point(22, 80);
            this.cbZSW1_2.Name = "cbZSW1_2";
            this.cbZSW1_2.Size = new System.Drawing.Size(150, 22);
            this.cbZSW1_2.TabIndex = 71;
            this.cbZSW1_2.Text = "Operation enabled";
            this.cbZSW1_2.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_1
            // 
            this.cbZSW1_1.AutoSize = true;
            this.cbZSW1_1.Location = new System.Drawing.Point(22, 61);
            this.cbZSW1_1.Name = "cbZSW1_1";
            this.cbZSW1_1.Size = new System.Drawing.Size(160, 22);
            this.cbZSW1_1.TabIndex = 70;
            this.cbZSW1_1.Text = "Ready for operation";
            this.cbZSW1_1.UseVisualStyleBackColor = true;
            // 
            // cbZSW1_0
            // 
            this.cbZSW1_0.AutoSize = true;
            this.cbZSW1_0.Location = new System.Drawing.Point(22, 42);
            this.cbZSW1_0.Name = "cbZSW1_0";
            this.cbZSW1_0.Size = new System.Drawing.Size(192, 22);
            this.cbZSW1_0.TabIndex = 69;
            this.cbZSW1_0.Text = "Ready to be switched on";
            this.cbZSW1_0.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(197, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 18);
            this.label23.TabIndex = 38;
            this.label23.Text = "Input";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tpPZSW1
            // 
            this.tpPZSW1.Controls.Add(this.cbPZSW1_15);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_14);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_13);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_12);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_11);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_10);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_9);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_8);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_7);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_6);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_5);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_4);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_3);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_2);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_1);
            this.tpPZSW1.Controls.Add(this.cbPZSW1_0);
            this.tpPZSW1.Controls.Add(this.label26);
            this.tpPZSW1.Location = new System.Drawing.Point(4, 27);
            this.tpPZSW1.Name = "tpPZSW1";
            this.tpPZSW1.Size = new System.Drawing.Size(258, 360);
            this.tpPZSW1.TabIndex = 4;
            this.tpPZSW1.Text = "PZSW1";
            this.tpPZSW1.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_15
            // 
            this.cbPZSW1_15.AutoSize = true;
            this.cbPZSW1_15.Location = new System.Drawing.Point(22, 328);
            this.cbPZSW1_15.Name = "cbPZSW1_15";
            this.cbPZSW1_15.Size = new System.Drawing.Size(99, 22);
            this.cbPZSW1_15.TabIndex = 84;
            this.cbPZSW1_15.Text = "MDI active";
            this.cbPZSW1_15.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_14
            // 
            this.cbPZSW1_14.AutoSize = true;
            this.cbPZSW1_14.Location = new System.Drawing.Point(22, 309);
            this.cbPZSW1_14.Name = "cbPZSW1_14";
            this.cbPZSW1_14.Size = new System.Drawing.Size(35, 22);
            this.cbPZSW1_14.TabIndex = 83;
            this.cbPZSW1_14.Text = "-";
            this.cbPZSW1_14.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_13
            // 
            this.cbPZSW1_13.AutoSize = true;
            this.cbPZSW1_13.Location = new System.Drawing.Point(22, 290);
            this.cbPZSW1_13.Name = "cbPZSW1_13";
            this.cbPZSW1_13.Size = new System.Drawing.Size(192, 22);
            this.cbPZSW1_13.TabIndex = 82;
            this.cbPZSW1_13.Text = "Positioning record active";
            this.cbPZSW1_13.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_12
            // 
            this.cbPZSW1_12.AutoSize = true;
            this.cbPZSW1_12.Location = new System.Drawing.Point(22, 271);
            this.cbPZSW1_12.Name = "cbPZSW1_12";
            this.cbPZSW1_12.Size = new System.Drawing.Size(35, 22);
            this.cbPZSW1_12.TabIndex = 81;
            this.cbPZSW1_12.Text = "-";
            this.cbPZSW1_12.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_11
            // 
            this.cbPZSW1_11.AutoSize = true;
            this.cbPZSW1_11.Location = new System.Drawing.Point(22, 252);
            this.cbPZSW1_11.Name = "cbPZSW1_11";
            this.cbPZSW1_11.Size = new System.Drawing.Size(124, 22);
            this.cbPZSW1_11.TabIndex = 80;
            this.cbPZSW1_11.Text = "Homing active";
            this.cbPZSW1_11.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_10
            // 
            this.cbPZSW1_10.AutoSize = true;
            this.cbPZSW1_10.Location = new System.Drawing.Point(22, 233);
            this.cbPZSW1_10.Name = "cbPZSW1_10";
            this.cbPZSW1_10.Size = new System.Drawing.Size(124, 22);
            this.cbPZSW1_10.TabIndex = 79;
            this.cbPZSW1_10.Text = "Jogging active";
            this.cbPZSW1_10.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_9
            // 
            this.cbPZSW1_9.AutoSize = true;
            this.cbPZSW1_9.Location = new System.Drawing.Point(22, 214);
            this.cbPZSW1_9.Name = "cbPZSW1_9";
            this.cbPZSW1_9.Size = new System.Drawing.Size(215, 22);
            this.cbPZSW1_9.TabIndex = 78;
            this.cbPZSW1_9.Text = "Positive limit switch reached";
            this.cbPZSW1_9.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_8
            // 
            this.cbPZSW1_8.AutoSize = true;
            this.cbPZSW1_8.Location = new System.Drawing.Point(22, 195);
            this.cbPZSW1_8.Name = "cbPZSW1_8";
            this.cbPZSW1_8.Size = new System.Drawing.Size(220, 22);
            this.cbPZSW1_8.TabIndex = 77;
            this.cbPZSW1_8.Text = "Negative limit switch reached";
            this.cbPZSW1_8.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_7
            // 
            this.cbPZSW1_7.AutoSize = true;
            this.cbPZSW1_7.Location = new System.Drawing.Point(22, 175);
            this.cbPZSW1_7.Name = "cbPZSW1_7";
            this.cbPZSW1_7.Size = new System.Drawing.Size(35, 22);
            this.cbPZSW1_7.TabIndex = 76;
            this.cbPZSW1_7.Text = "-";
            this.cbPZSW1_7.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_6
            // 
            this.cbPZSW1_6.AutoSize = true;
            this.cbPZSW1_6.Location = new System.Drawing.Point(22, 156);
            this.cbPZSW1_6.Name = "cbPZSW1_6";
            this.cbPZSW1_6.Size = new System.Drawing.Size(226, 22);
            this.cbPZSW1_6.TabIndex = 75;
            this.cbPZSW1_6.Text = "Active positioning record bit  6";
            this.cbPZSW1_6.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_5
            // 
            this.cbPZSW1_5.AutoSize = true;
            this.cbPZSW1_5.Location = new System.Drawing.Point(22, 137);
            this.cbPZSW1_5.Name = "cbPZSW1_5";
            this.cbPZSW1_5.Size = new System.Drawing.Size(226, 22);
            this.cbPZSW1_5.TabIndex = 74;
            this.cbPZSW1_5.Text = "Active positioning record bit  5";
            this.cbPZSW1_5.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_4
            // 
            this.cbPZSW1_4.AutoSize = true;
            this.cbPZSW1_4.Location = new System.Drawing.Point(22, 118);
            this.cbPZSW1_4.Name = "cbPZSW1_4";
            this.cbPZSW1_4.Size = new System.Drawing.Size(226, 22);
            this.cbPZSW1_4.TabIndex = 73;
            this.cbPZSW1_4.Text = "Active positioning record bit  4";
            this.cbPZSW1_4.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_3
            // 
            this.cbPZSW1_3.AutoSize = true;
            this.cbPZSW1_3.Location = new System.Drawing.Point(22, 99);
            this.cbPZSW1_3.Name = "cbPZSW1_3";
            this.cbPZSW1_3.Size = new System.Drawing.Size(226, 22);
            this.cbPZSW1_3.TabIndex = 72;
            this.cbPZSW1_3.Text = "Active positioning record bit  3";
            this.cbPZSW1_3.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_2
            // 
            this.cbPZSW1_2.AutoSize = true;
            this.cbPZSW1_2.Location = new System.Drawing.Point(22, 80);
            this.cbPZSW1_2.Name = "cbPZSW1_2";
            this.cbPZSW1_2.Size = new System.Drawing.Size(226, 22);
            this.cbPZSW1_2.TabIndex = 71;
            this.cbPZSW1_2.Text = "Active positioning record bit  2";
            this.cbPZSW1_2.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_1
            // 
            this.cbPZSW1_1.AutoSize = true;
            this.cbPZSW1_1.Location = new System.Drawing.Point(22, 61);
            this.cbPZSW1_1.Name = "cbPZSW1_1";
            this.cbPZSW1_1.Size = new System.Drawing.Size(226, 22);
            this.cbPZSW1_1.TabIndex = 70;
            this.cbPZSW1_1.Text = "Active positioning record bit  1";
            this.cbPZSW1_1.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1_0
            // 
            this.cbPZSW1_0.AutoSize = true;
            this.cbPZSW1_0.Location = new System.Drawing.Point(22, 42);
            this.cbPZSW1_0.Name = "cbPZSW1_0";
            this.cbPZSW1_0.Size = new System.Drawing.Size(226, 22);
            this.cbPZSW1_0.TabIndex = 69;
            this.cbPZSW1_0.Text = "Active positioning record bit  0";
            this.cbPZSW1_0.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(197, 8);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 18);
            this.label26.TabIndex = 39;
            this.label26.Text = "Input";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tpPZSW2
            // 
            this.tpPZSW2.Controls.Add(this.cbPZSW2_15);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_14);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_13);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_12);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_11);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_10);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_9);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_8);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_7);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_6);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_5);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_4);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_3);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_2);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_1);
            this.tpPZSW2.Controls.Add(this.cbPZSW2_0);
            this.tpPZSW2.Controls.Add(this.label48);
            this.tpPZSW2.Location = new System.Drawing.Point(4, 27);
            this.tpPZSW2.Name = "tpPZSW2";
            this.tpPZSW2.Size = new System.Drawing.Size(258, 360);
            this.tpPZSW2.TabIndex = 7;
            this.tpPZSW2.Text = "PZSW2";
            this.tpPZSW2.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_15
            // 
            this.cbPZSW2_15.AutoSize = true;
            this.cbPZSW2_15.Location = new System.Drawing.Point(22, 328);
            this.cbPZSW2_15.Name = "cbPZSW2_15";
            this.cbPZSW2_15.Size = new System.Drawing.Size(197, 22);
            this.cbPZSW2_15.TabIndex = 118;
            this.cbPZSW2_15.Text = "Position command active";
            this.cbPZSW2_15.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_14
            // 
            this.cbPZSW2_14.AutoSize = true;
            this.cbPZSW2_14.Location = new System.Drawing.Point(22, 309);
            this.cbPZSW2_14.Name = "cbPZSW2_14";
            this.cbPZSW2_14.Size = new System.Drawing.Size(196, 22);
            this.cbPZSW2_14.TabIndex = 117;
            this.cbPZSW2_14.Text = "Travel to fixed stop active";
            this.cbPZSW2_14.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_13
            // 
            this.cbPZSW2_13.AutoSize = true;
            this.cbPZSW2_13.Location = new System.Drawing.Point(22, 290);
            this.cbPZSW2_13.Name = "cbPZSW2_13";
            this.cbPZSW2_13.Size = new System.Drawing.Size(264, 22);
            this.cbPZSW2_13.TabIndex = 116;
            this.cbPZSW2_13.Text = "Fixed stop clamping torque reached";
            this.cbPZSW2_13.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_12
            // 
            this.cbPZSW2_12.AutoSize = true;
            this.cbPZSW2_12.Location = new System.Drawing.Point(22, 271);
            this.cbPZSW2_12.Name = "cbPZSW2_12";
            this.cbPZSW2_12.Size = new System.Drawing.Size(155, 22);
            this.cbPZSW2_12.TabIndex = 115;
            this.cbPZSW2_12.Text = "Fixed stop reached";
            this.cbPZSW2_12.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_11
            // 
            this.cbPZSW2_11.AutoSize = true;
            this.cbPZSW2_11.Location = new System.Drawing.Point(22, 252);
            this.cbPZSW2_11.Name = "cbPZSW2_11";
            this.cbPZSW2_11.Size = new System.Drawing.Size(270, 22);
            this.cbPZSW2_11.TabIndex = 114;
            this.cbPZSW2_11.Text = "Direct output 2 via positioning record";
            this.cbPZSW2_11.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_10
            // 
            this.cbPZSW2_10.AutoSize = true;
            this.cbPZSW2_10.Location = new System.Drawing.Point(22, 233);
            this.cbPZSW2_10.Name = "cbPZSW2_10";
            this.cbPZSW2_10.Size = new System.Drawing.Size(270, 22);
            this.cbPZSW2_10.TabIndex = 113;
            this.cbPZSW2_10.Text = "Direct output 1 via positioning record";
            this.cbPZSW2_10.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_9
            // 
            this.cbPZSW2_9.AutoSize = true;
            this.cbPZSW2_9.Location = new System.Drawing.Point(22, 214);
            this.cbPZSW2_9.Name = "cbPZSW2_9";
            this.cbPZSW2_9.Size = new System.Drawing.Size(242, 22);
            this.cbPZSW2_9.TabIndex = 112;
            this.cbPZSW2_9.Text = "Actual position <= Cam switch 1";
            this.cbPZSW2_9.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_8
            // 
            this.cbPZSW2_8.AutoSize = true;
            this.cbPZSW2_8.Location = new System.Drawing.Point(22, 195);
            this.cbPZSW2_8.Name = "cbPZSW2_8";
            this.cbPZSW2_8.Size = new System.Drawing.Size(242, 22);
            this.cbPZSW2_8.TabIndex = 111;
            this.cbPZSW2_8.Text = "Actual position <= Cam switch 0";
            this.cbPZSW2_8.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_7
            // 
            this.cbPZSW2_7.AutoSize = true;
            this.cbPZSW2_7.Location = new System.Drawing.Point(22, 175);
            this.cbPZSW2_7.Name = "cbPZSW2_7";
            this.cbPZSW2_7.Size = new System.Drawing.Size(261, 22);
            this.cbPZSW2_7.TabIndex = 110;
            this.cbPZSW2_7.Text = "Positive software limit switch active";
            this.cbPZSW2_7.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_6
            // 
            this.cbPZSW2_6.AutoSize = true;
            this.cbPZSW2_6.Location = new System.Drawing.Point(22, 156);
            this.cbPZSW2_6.Name = "cbPZSW2_6";
            this.cbPZSW2_6.Size = new System.Drawing.Size(266, 22);
            this.cbPZSW2_6.TabIndex = 109;
            this.cbPZSW2_6.Text = "Negative software limit switch active";
            this.cbPZSW2_6.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_5
            // 
            this.cbPZSW2_5.AutoSize = true;
            this.cbPZSW2_5.Location = new System.Drawing.Point(22, 137);
            this.cbPZSW2_5.Name = "cbPZSW2_5";
            this.cbPZSW2_5.Size = new System.Drawing.Size(179, 22);
            this.cbPZSW2_5.TabIndex = 108;
            this.cbPZSW2_5.Text = "Drive travels backward";
            this.cbPZSW2_5.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_4
            // 
            this.cbPZSW2_4.AutoSize = true;
            this.cbPZSW2_4.Location = new System.Drawing.Point(22, 118);
            this.cbPZSW2_4.Name = "cbPZSW2_4";
            this.cbPZSW2_4.Size = new System.Drawing.Size(165, 22);
            this.cbPZSW2_4.TabIndex = 107;
            this.cbPZSW2_4.Text = "Drive travels forward";
            this.cbPZSW2_4.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_3
            // 
            this.cbPZSW2_3.AutoSize = true;
            this.cbPZSW2_3.Location = new System.Drawing.Point(22, 99);
            this.cbPZSW2_3.Name = "cbPZSW2_3";
            this.cbPZSW2_3.Size = new System.Drawing.Size(35, 22);
            this.cbPZSW2_3.TabIndex = 106;
            this.cbPZSW2_3.Text = "-";
            this.cbPZSW2_3.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_2
            // 
            this.cbPZSW2_2.AutoSize = true;
            this.cbPZSW2_2.Location = new System.Drawing.Point(22, 80);
            this.cbPZSW2_2.Name = "cbPZSW2_2";
            this.cbPZSW2_2.Size = new System.Drawing.Size(179, 22);
            this.cbPZSW2_2.TabIndex = 105;
            this.cbPZSW2_2.Text = "Setpoint value stopped";
            this.cbPZSW2_2.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_1
            // 
            this.cbPZSW2_1.AutoSize = true;
            this.cbPZSW2_1.Location = new System.Drawing.Point(22, 61);
            this.cbPZSW2_1.Name = "cbPZSW2_1";
            this.cbPZSW2_1.Size = new System.Drawing.Size(172, 22);
            this.cbPZSW2_1.TabIndex = 104;
            this.cbPZSW2_1.Text = "Velocity limiting active";
            this.cbPZSW2_1.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2_0
            // 
            this.cbPZSW2_0.AutoSize = true;
            this.cbPZSW2_0.Location = new System.Drawing.Point(22, 42);
            this.cbPZSW2_0.Name = "cbPZSW2_0";
            this.cbPZSW2_0.Size = new System.Drawing.Size(171, 22);
            this.cbPZSW2_0.TabIndex = 103;
            this.cbPZSW2_0.Text = "Tracking mode active";
            this.cbPZSW2_0.UseVisualStyleBackColor = true;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(197, 8);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(39, 18);
            this.label48.TabIndex = 102;
            this.label48.Text = "Input";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tpRaw
            // 
            this.tpRaw.Controls.Add(this.txRawOut);
            this.tpRaw.Controls.Add(this.label18);
            this.tpRaw.Controls.Add(this.label17);
            this.tpRaw.Controls.Add(this.txRawIn);
            this.tpRaw.Location = new System.Drawing.Point(4, 27);
            this.tpRaw.Name = "tpRaw";
            this.tpRaw.Padding = new System.Windows.Forms.Padding(3);
            this.tpRaw.Size = new System.Drawing.Size(258, 360);
            this.tpRaw.TabIndex = 0;
            this.tpRaw.Text = "Raw";
            this.tpRaw.UseVisualStyleBackColor = true;
            // 
            // txRawOut
            // 
            this.txRawOut.Location = new System.Drawing.Point(134, 42);
            this.txRawOut.Multiline = true;
            this.txRawOut.Name = "txRawOut";
            this.txRawOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txRawOut.Size = new System.Drawing.Size(118, 316);
            this.txRawOut.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(131, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 18);
            this.label18.TabIndex = 36;
            this.label18.Text = "Output:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 18);
            this.label17.TabIndex = 34;
            this.label17.Text = "Input:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tpExtOut
            // 
            this.tpExtOut.Controls.Add(this.label44);
            this.tpExtOut.Controls.Add(this.txOW23);
            this.tpExtOut.Controls.Add(this.label45);
            this.tpExtOut.Controls.Add(this.txOW20);
            this.tpExtOut.Controls.Add(this.label46);
            this.tpExtOut.Controls.Add(this.txOW22);
            this.tpExtOut.Controls.Add(this.txOW21);
            this.tpExtOut.Controls.Add(this.label47);
            this.tpExtOut.Controls.Add(this.label40);
            this.tpExtOut.Controls.Add(this.txOW19);
            this.tpExtOut.Controls.Add(this.label41);
            this.tpExtOut.Controls.Add(this.txOW16);
            this.tpExtOut.Controls.Add(this.label42);
            this.tpExtOut.Controls.Add(this.txOW18);
            this.tpExtOut.Controls.Add(this.txOW17);
            this.tpExtOut.Controls.Add(this.label43);
            this.tpExtOut.Controls.Add(this.label35);
            this.tpExtOut.Controls.Add(this.txOW15);
            this.tpExtOut.Controls.Add(this.label37);
            this.tpExtOut.Controls.Add(this.txOW12);
            this.tpExtOut.Controls.Add(this.label38);
            this.tpExtOut.Controls.Add(this.txOW14);
            this.tpExtOut.Controls.Add(this.txOW13);
            this.tpExtOut.Controls.Add(this.label39);
            this.tpExtOut.Controls.Add(this.cbExtendedWrite);
            this.tpExtOut.Location = new System.Drawing.Point(4, 27);
            this.tpExtOut.Name = "tpExtOut";
            this.tpExtOut.Padding = new System.Windows.Forms.Padding(3);
            this.tpExtOut.Size = new System.Drawing.Size(258, 360);
            this.tpExtOut.TabIndex = 6;
            this.tpExtOut.Text = "Extended";
            this.tpExtOut.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            this.label44.Location = new System.Drawing.Point(85, 328);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(68, 17);
            this.label44.TabIndex = 91;
            this.label44.Text = "Out[23]:";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txOW23
            // 
            this.txOW23.Location = new System.Drawing.Point(159, 324);
            this.txOW23.Name = "txOW23";
            this.txOW23.Size = new System.Drawing.Size(79, 24);
            this.txOW23.TabIndex = 95;
            this.txOW23.Text = "0";
            this.txOW23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(85, 246);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(68, 17);
            this.label45.TabIndex = 88;
            this.label45.Text = "Out[20]:";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txOW20
            // 
            this.txOW20.Location = new System.Drawing.Point(159, 243);
            this.txOW20.Name = "txOW20";
            this.txOW20.Size = new System.Drawing.Size(79, 24);
            this.txOW20.TabIndex = 92;
            this.txOW20.Text = "0";
            this.txOW20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label46
            // 
            this.label46.Location = new System.Drawing.Point(85, 273);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(68, 17);
            this.label46.TabIndex = 90;
            this.label46.Text = "Out[21]:";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txOW22
            // 
            this.txOW22.Location = new System.Drawing.Point(159, 297);
            this.txOW22.Name = "txOW22";
            this.txOW22.Size = new System.Drawing.Size(79, 24);
            this.txOW22.TabIndex = 94;
            this.txOW22.Text = "0";
            this.txOW22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txOW21
            // 
            this.txOW21.Location = new System.Drawing.Point(159, 270);
            this.txOW21.Name = "txOW21";
            this.txOW21.Size = new System.Drawing.Size(79, 24);
            this.txOW21.TabIndex = 93;
            this.txOW21.Text = "0";
            this.txOW21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(85, 301);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(68, 17);
            this.label47.TabIndex = 89;
            this.label47.Text = "Out[22]:";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label40
            // 
            this.label40.Location = new System.Drawing.Point(85, 220);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(68, 17);
            this.label40.TabIndex = 83;
            this.label40.Text = "Out[19]:";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txOW19
            // 
            this.txOW19.Location = new System.Drawing.Point(159, 216);
            this.txOW19.Name = "txOW19";
            this.txOW19.Size = new System.Drawing.Size(79, 24);
            this.txOW19.TabIndex = 87;
            this.txOW19.Text = "0";
            this.txOW19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(85, 138);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(68, 17);
            this.label41.TabIndex = 80;
            this.label41.Text = "Out[16]:";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txOW16
            // 
            this.txOW16.Location = new System.Drawing.Point(159, 135);
            this.txOW16.Name = "txOW16";
            this.txOW16.Size = new System.Drawing.Size(79, 24);
            this.txOW16.TabIndex = 84;
            this.txOW16.Text = "0";
            this.txOW16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(85, 165);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(68, 17);
            this.label42.TabIndex = 82;
            this.label42.Text = "Out[17]:";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txOW18
            // 
            this.txOW18.Location = new System.Drawing.Point(159, 189);
            this.txOW18.Name = "txOW18";
            this.txOW18.Size = new System.Drawing.Size(79, 24);
            this.txOW18.TabIndex = 86;
            this.txOW18.Text = "0";
            this.txOW18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txOW17
            // 
            this.txOW17.Location = new System.Drawing.Point(159, 162);
            this.txOW17.Name = "txOW17";
            this.txOW17.Size = new System.Drawing.Size(79, 24);
            this.txOW17.TabIndex = 85;
            this.txOW17.Text = "0";
            this.txOW17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(85, 193);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(68, 17);
            this.label43.TabIndex = 81;
            this.label43.Text = "Out[18]:";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(85, 111);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(68, 17);
            this.label35.TabIndex = 75;
            this.label35.Text = "Out[15]:";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txOW15
            // 
            this.txOW15.Location = new System.Drawing.Point(159, 107);
            this.txOW15.Name = "txOW15";
            this.txOW15.Size = new System.Drawing.Size(79, 24);
            this.txOW15.TabIndex = 79;
            this.txOW15.Text = "0";
            this.txOW15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(85, 29);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(68, 17);
            this.label37.TabIndex = 72;
            this.label37.Text = "Out[12]:";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txOW12
            // 
            this.txOW12.Location = new System.Drawing.Point(159, 26);
            this.txOW12.Name = "txOW12";
            this.txOW12.Size = new System.Drawing.Size(79, 24);
            this.txOW12.TabIndex = 76;
            this.txOW12.Text = "0";
            this.txOW12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(85, 56);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(68, 17);
            this.label38.TabIndex = 74;
            this.label38.Text = "Out[13]:";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txOW14
            // 
            this.txOW14.Location = new System.Drawing.Point(159, 80);
            this.txOW14.Name = "txOW14";
            this.txOW14.Size = new System.Drawing.Size(79, 24);
            this.txOW14.TabIndex = 78;
            this.txOW14.Text = "0";
            this.txOW14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txOW13
            // 
            this.txOW13.Location = new System.Drawing.Point(159, 53);
            this.txOW13.Name = "txOW13";
            this.txOW13.Size = new System.Drawing.Size(79, 24);
            this.txOW13.TabIndex = 77;
            this.txOW13.Text = "0";
            this.txOW13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label39
            // 
            this.label39.Location = new System.Drawing.Point(85, 84);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(68, 17);
            this.label39.TabIndex = 73;
            this.label39.Text = "Out[14]:";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbExtendedWrite
            // 
            this.cbExtendedWrite.AutoSize = true;
            this.cbExtendedWrite.Location = new System.Drawing.Point(22, 8);
            this.cbExtendedWrite.Name = "cbExtendedWrite";
            this.cbExtendedWrite.Size = new System.Drawing.Size(65, 22);
            this.cbExtendedWrite.TabIndex = 71;
            this.cbExtendedWrite.Text = "Write";
            this.cbExtendedWrite.UseVisualStyleBackColor = true;
            // 
            // lbDebugPrev
            // 
            this.lbDebugPrev.AutoSize = true;
            this.lbDebugPrev.Location = new System.Drawing.Point(244, 21);
            this.lbDebugPrev.Name = "lbDebugPrev";
            this.lbDebugPrev.Size = new System.Drawing.Size(26, 18);
            this.lbDebugPrev.TabIndex = 37;
            this.lbDebugPrev.Text = "<<";
            this.lbDebugPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDebugPrev.Click += new System.EventHandler(this.LbDebugPrev_Click);
            // 
            // lbDebugNext
            // 
            this.lbDebugNext.AutoSize = true;
            this.lbDebugNext.Location = new System.Drawing.Point(268, 21);
            this.lbDebugNext.Name = "lbDebugNext";
            this.lbDebugNext.Size = new System.Drawing.Size(26, 18);
            this.lbDebugNext.TabIndex = 36;
            this.lbDebugNext.Text = ">>";
            this.lbDebugNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDebugNext.Click += new System.EventHandler(this.LbDebugNext_Click);
            // 
            // gbDynamic
            // 
            this.gbDynamic.Controls.Add(this.lbHomingTimeOut);
            this.gbDynamic.Controls.Add(this.lbTimeWait);
            this.gbDynamic.Controls.Add(this.lbTimeOut);
            this.gbDynamic.Controls.Add(this.label30);
            this.gbDynamic.Controls.Add(this.txRecordSelection);
            this.gbDynamic.Controls.Add(this.label27);
            this.gbDynamic.Controls.Add(this.txHomingTimeOut);
            this.gbDynamic.Controls.Add(this.lbDynamicPrev);
            this.gbDynamic.Controls.Add(this.label29);
            this.gbDynamic.Controls.Add(this.lbDynamicNext);
            this.gbDynamic.Controls.Add(this.label21);
            this.gbDynamic.Controls.Add(this.txTimeWait);
            this.gbDynamic.Controls.Add(this.label20);
            this.gbDynamic.Controls.Add(this.label19);
            this.gbDynamic.Controls.Add(this.label28);
            this.gbDynamic.Controls.Add(this.lbUnitVel);
            this.gbDynamic.Controls.Add(this.txTimeOut);
            this.gbDynamic.Controls.Add(this.lbUnitPos);
            this.gbDynamic.Controls.Add(this.label16);
            this.gbDynamic.Controls.Add(this.txUnitVel);
            this.gbDynamic.Controls.Add(this.label15);
            this.gbDynamic.Controls.Add(this.txUnitPos);
            this.gbDynamic.Controls.Add(this.label14);
            this.gbDynamic.Controls.Add(this.label10);
            this.gbDynamic.Controls.Add(this.txTargetPosition);
            this.gbDynamic.Controls.Add(this.label13);
            this.gbDynamic.Controls.Add(this.txTargetVelocity);
            this.gbDynamic.Controls.Add(this.txOverride);
            this.gbDynamic.Controls.Add(this.label11);
            this.gbDynamic.Controls.Add(this.txDec);
            this.gbDynamic.Controls.Add(this.txAcc);
            this.gbDynamic.Controls.Add(this.label12);
            this.gbDynamic.Location = new System.Drawing.Point(850, 64);
            this.gbDynamic.Name = "gbDynamic";
            this.gbDynamic.Size = new System.Drawing.Size(304, 444);
            this.gbDynamic.TabIndex = 4;
            this.gbDynamic.TabStop = false;
            this.gbDynamic.Text = "Dynamic";
            this.gbDynamic.Visible = false;
            // 
            // lbHomingTimeOut
            // 
            this.lbHomingTimeOut.Location = new System.Drawing.Point(227, 412);
            this.lbHomingTimeOut.Name = "lbHomingTimeOut";
            this.lbHomingTimeOut.Size = new System.Drawing.Size(60, 17);
            this.lbHomingTimeOut.TabIndex = 45;
            this.lbHomingTimeOut.Text = "-";
            this.lbHomingTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTimeWait
            // 
            this.lbTimeWait.Location = new System.Drawing.Point(227, 382);
            this.lbTimeWait.Name = "lbTimeWait";
            this.lbTimeWait.Size = new System.Drawing.Size(60, 17);
            this.lbTimeWait.TabIndex = 44;
            this.lbTimeWait.Text = "-";
            this.lbTimeWait.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTimeOut
            // 
            this.lbTimeOut.Location = new System.Drawing.Point(227, 355);
            this.lbTimeOut.Name = "lbTimeOut";
            this.lbTimeOut.Size = new System.Drawing.Size(60, 17);
            this.lbTimeOut.TabIndex = 43;
            this.lbTimeOut.Text = "-";
            this.lbTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(6, 410);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(130, 21);
            this.label30.TabIndex = 42;
            this.label30.Text = "Homing time-out:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txRecordSelection
            // 
            this.txRecordSelection.Location = new System.Drawing.Point(142, 119);
            this.txRecordSelection.Name = "txRecordSelection";
            this.txRecordSelection.Size = new System.Drawing.Size(79, 24);
            this.txRecordSelection.TabIndex = 24;
            this.txRecordSelection.Text = "1";
            this.txRecordSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(15, 122);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(121, 18);
            this.label27.TabIndex = 35;
            this.label27.Text = "Record selection:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txHomingTimeOut
            // 
            this.txHomingTimeOut.Location = new System.Drawing.Point(142, 408);
            this.txHomingTimeOut.Name = "txHomingTimeOut";
            this.txHomingTimeOut.Size = new System.Drawing.Size(79, 24);
            this.txHomingTimeOut.TabIndex = 32;
            this.txHomingTimeOut.Text = "100";
            this.txHomingTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txHomingTimeOut.TextChanged += new System.EventHandler(this.TxHomingTimeOut_TextChanged);
            // 
            // lbDynamicPrev
            // 
            this.lbDynamicPrev.AutoSize = true;
            this.lbDynamicPrev.Location = new System.Drawing.Point(244, 21);
            this.lbDynamicPrev.Name = "lbDynamicPrev";
            this.lbDynamicPrev.Size = new System.Drawing.Size(26, 18);
            this.lbDynamicPrev.TabIndex = 33;
            this.lbDynamicPrev.Text = "<<";
            this.lbDynamicPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDynamicPrev.Click += new System.EventHandler(this.LbDynamicPrev_Click);
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(68, 382);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 17);
            this.label29.TabIndex = 40;
            this.label29.Text = "Wait:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDynamicNext
            // 
            this.lbDynamicNext.AutoSize = true;
            this.lbDynamicNext.Location = new System.Drawing.Point(268, 21);
            this.lbDynamicNext.Name = "lbDynamicNext";
            this.lbDynamicNext.Size = new System.Drawing.Size(26, 18);
            this.lbDynamicNext.TabIndex = 4;
            this.lbDynamicNext.Text = ">>";
            this.lbDynamicNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDynamicNext.Click += new System.EventHandler(this.LbDynamicNext_Click);
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(227, 176);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 17);
            this.label21.TabIndex = 32;
            this.label21.Text = "%";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txTimeWait
            // 
            this.txTimeWait.Location = new System.Drawing.Point(142, 378);
            this.txTimeWait.Name = "txTimeWait";
            this.txTimeWait.Size = new System.Drawing.Size(79, 24);
            this.txTimeWait.TabIndex = 31;
            this.txTimeWait.Text = "5";
            this.txTimeWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txTimeWait.TextChanged += new System.EventHandler(this.TxTimeWait_TextChanged);
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(227, 237);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 17);
            this.label20.TabIndex = 31;
            this.label20.Text = "%";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(227, 207);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 17);
            this.label19.TabIndex = 30;
            this.label19.Text = "%";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(46, 350);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(90, 21);
            this.label28.TabIndex = 38;
            this.label28.Text = "Time-out:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbUnitVel
            // 
            this.lbUnitVel.Location = new System.Drawing.Point(227, 93);
            this.lbUnitVel.Name = "lbUnitVel";
            this.lbUnitVel.Size = new System.Drawing.Size(60, 17);
            this.lbUnitVel.TabIndex = 29;
            this.lbUnitVel.Text = "unit";
            this.lbUnitVel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txTimeOut
            // 
            this.txTimeOut.Location = new System.Drawing.Point(142, 348);
            this.txTimeOut.Name = "txTimeOut";
            this.txTimeOut.Size = new System.Drawing.Size(79, 24);
            this.txTimeOut.TabIndex = 30;
            this.txTimeOut.Text = "20";
            this.txTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txTimeOut.TextChanged += new System.EventHandler(this.TxTimeOut_TextChanged);
            // 
            // lbUnitPos
            // 
            this.lbUnitPos.Location = new System.Drawing.Point(227, 63);
            this.lbUnitPos.Name = "lbUnitPos";
            this.lbUnitPos.Size = new System.Drawing.Size(60, 17);
            this.lbUnitPos.TabIndex = 28;
            this.lbUnitPos.Text = "unit";
            this.lbUnitPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(42, 296);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 17);
            this.label16.TabIndex = 27;
            this.label16.Text = "Velocity unit:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txUnitVel
            // 
            this.txUnitVel.Location = new System.Drawing.Point(142, 292);
            this.txUnitVel.Name = "txUnitVel";
            this.txUnitVel.Size = new System.Drawing.Size(79, 24);
            this.txUnitVel.TabIndex = 29;
            this.txUnitVel.Text = "mm/s";
            this.txUnitVel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txUnitVel.TextChanged += new System.EventHandler(this.TxUnitVel_TextChanged);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(43, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Position unit:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txUnitPos
            // 
            this.txUnitPos.Location = new System.Drawing.Point(142, 262);
            this.txUnitPos.Name = "txUnitPos";
            this.txUnitPos.Size = new System.Drawing.Size(79, 24);
            this.txUnitPos.TabIndex = 28;
            this.txUnitPos.Text = "mm";
            this.txUnitPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txUnitPos.TextChanged += new System.EventHandler(this.TxUnitPos_TextChanged);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(27, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Target position:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(27, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Target velocity:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txTargetPosition
            // 
            this.txTargetPosition.Location = new System.Drawing.Point(142, 59);
            this.txTargetPosition.Name = "txTargetPosition";
            this.txTargetPosition.Size = new System.Drawing.Size(79, 24);
            this.txTargetPosition.TabIndex = 22;
            this.txTargetPosition.Text = "0";
            this.txTargetPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(68, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Override:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txTargetVelocity
            // 
            this.txTargetVelocity.Location = new System.Drawing.Point(142, 89);
            this.txTargetVelocity.Name = "txTargetVelocity";
            this.txTargetVelocity.Size = new System.Drawing.Size(79, 24);
            this.txTargetVelocity.TabIndex = 23;
            this.txTargetVelocity.Text = "0";
            this.txTargetVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txOverride
            // 
            this.txOverride.Location = new System.Drawing.Point(142, 173);
            this.txOverride.Name = "txOverride";
            this.txOverride.Size = new System.Drawing.Size(79, 24);
            this.txOverride.TabIndex = 25;
            this.txOverride.Text = "100";
            this.txOverride.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(42, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Acceleration:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txDec
            // 
            this.txDec.Location = new System.Drawing.Point(142, 233);
            this.txDec.Name = "txDec";
            this.txDec.Size = new System.Drawing.Size(79, 24);
            this.txDec.TabIndex = 27;
            this.txDec.Text = "100";
            this.txDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txAcc
            // 
            this.txAcc.Location = new System.Drawing.Point(142, 203);
            this.txAcc.Name = "txAcc";
            this.txAcc.Size = new System.Drawing.Size(79, 24);
            this.txAcc.TabIndex = 26;
            this.txAcc.Text = "100";
            this.txAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(41, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Deceleration:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbTakeControl
            // 
            this.cbTakeControl.AutoSize = true;
            this.cbTakeControl.Location = new System.Drawing.Point(30, 41);
            this.cbTakeControl.Name = "cbTakeControl";
            this.cbTakeControl.Size = new System.Drawing.Size(193, 22);
            this.cbTakeControl.TabIndex = 2;
            this.cbTakeControl.Text = "Take control via modbus";
            this.cbTakeControl.UseVisualStyleBackColor = true;
            this.cbTakeControl.CheckedChanged += new System.EventHandler(this.CbTakeControl_CheckedChanged);
            // 
            // gbConnect
            // 
            this.gbConnect.Controls.Add(this.btHelp);
            this.gbConnect.Controls.Add(this.btConnect);
            this.gbConnect.Location = new System.Drawing.Point(20, 87);
            this.gbConnect.Name = "gbConnect";
            this.gbConnect.Size = new System.Drawing.Size(224, 92);
            this.gbConnect.TabIndex = 1;
            this.gbConnect.TabStop = false;
            this.gbConnect.Text = "Connect";
            // 
            // btHelp
            // 
            this.btHelp.Location = new System.Drawing.Point(195, 12);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(23, 23);
            this.btHelp.TabIndex = 47;
            this.btHelp.Text = "?";
            this.btHelp.UseVisualStyleBackColor = true;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // gbTakeControl
            // 
            this.gbTakeControl.Controls.Add(this.cbTakeControl);
            this.gbTakeControl.Enabled = false;
            this.gbTakeControl.Location = new System.Drawing.Point(250, 87);
            this.gbTakeControl.Name = "gbTakeControl";
            this.gbTakeControl.Size = new System.Drawing.Size(235, 92);
            this.gbTakeControl.TabIndex = 2;
            this.gbTakeControl.TabStop = false;
            this.gbTakeControl.Text = "Take Control";
            // 
            // gbMonitorInput
            // 
            this.gbMonitorInput.Controls.Add(this.tabControl2);
            this.gbMonitorInput.Location = new System.Drawing.Point(807, 87);
            this.gbMonitorInput.Name = "gbMonitorInput";
            this.gbMonitorInput.Size = new System.Drawing.Size(304, 444);
            this.gbMonitorInput.TabIndex = 10;
            this.gbMonitorInput.TabStop = false;
            this.gbMonitorInput.Text = "Monitor Input";
            this.gbMonitorInput.Visible = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Location = new System.Drawing.Point(20, 34);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(266, 391);
            this.tabControl2.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbZSW1b_9);
            this.tabPage3.Controls.Add(this.cbZSW1b_15);
            this.tabPage3.Controls.Add(this.cbZSW1b_14);
            this.tabPage3.Controls.Add(this.cbZSW1b_13);
            this.tabPage3.Controls.Add(this.cbZSW1b_12);
            this.tabPage3.Controls.Add(this.cbZSW1b_10);
            this.tabPage3.Controls.Add(this.cbZSW1b_11);
            this.tabPage3.Controls.Add(this.cbZSW1b_8);
            this.tabPage3.Controls.Add(this.cbZSW1b_7);
            this.tabPage3.Controls.Add(this.cbZSW1b_6);
            this.tabPage3.Controls.Add(this.cbZSW1b_5);
            this.tabPage3.Controls.Add(this.cbZSW1b_4);
            this.tabPage3.Controls.Add(this.cbZSW1b_3);
            this.tabPage3.Controls.Add(this.cbZSW1b_2);
            this.tabPage3.Controls.Add(this.cbZSW1b_1);
            this.tabPage3.Controls.Add(this.cbZSW1b_0);
            this.tabPage3.Controls.Add(this.label34);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(258, 360);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ZSW1";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_9
            // 
            this.cbZSW1b_9.AutoSize = true;
            this.cbZSW1b_9.Location = new System.Drawing.Point(22, 214);
            this.cbZSW1b_9.Name = "cbZSW1b_9";
            this.cbZSW1b_9.Size = new System.Drawing.Size(126, 22);
            this.cbZSW1b_9.TabIndex = 84;
            this.cbZSW1b_9.Text = "Guide required";
            this.cbZSW1b_9.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_15
            // 
            this.cbZSW1b_15.AutoSize = true;
            this.cbZSW1b_15.Location = new System.Drawing.Point(22, 328);
            this.cbZSW1b_15.Name = "cbZSW1b_15";
            this.cbZSW1b_15.Size = new System.Drawing.Size(230, 22);
            this.cbZSW1b_15.TabIndex = 83;
            this.cbZSW1b_15.Text = "No temp warning / decelerated";
            this.cbZSW1b_15.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_14
            // 
            this.cbZSW1b_14.AutoSize = true;
            this.cbZSW1b_14.Location = new System.Drawing.Point(22, 309);
            this.cbZSW1b_14.Name = "cbZSW1b_14";
            this.cbZSW1b_14.Size = new System.Drawing.Size(218, 22);
            this.cbZSW1b_14.TabIndex = 82;
            this.cbZSW1b_14.Text = "Motor direction / accelerated";
            this.cbZSW1b_14.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_13
            // 
            this.cbZSW1b_13.AutoSize = true;
            this.cbZSW1b_13.Location = new System.Drawing.Point(22, 290);
            this.cbZSW1b_13.Name = "cbZSW1b_13";
            this.cbZSW1b_13.Size = new System.Drawing.Size(225, 22);
            this.cbZSW1b_13.TabIndex = 81;
            this.cbZSW1b_13.Text = "No overheat / Drive stationary";
            this.cbZSW1b_13.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_12
            // 
            this.cbZSW1b_12.AutoSize = true;
            this.cbZSW1b_12.Location = new System.Drawing.Point(22, 271);
            this.cbZSW1b_12.Name = "cbZSW1b_12";
            this.cbZSW1b_12.Size = new System.Drawing.Size(185, 22);
            this.cbZSW1b_12.TabIndex = 80;
            this.cbZSW1b_12.Text = "Positioning task actived";
            this.cbZSW1b_12.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_10
            // 
            this.cbZSW1b_10.AutoSize = true;
            this.cbZSW1b_10.Location = new System.Drawing.Point(22, 233);
            this.cbZSW1b_10.Name = "cbZSW1b_10";
            this.cbZSW1b_10.Size = new System.Drawing.Size(188, 22);
            this.cbZSW1b_10.TabIndex = 79;
            this.cbZSW1b_10.Text = "Target vel / pos reached";
            this.cbZSW1b_10.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_11
            // 
            this.cbZSW1b_11.AutoSize = true;
            this.cbZSW1b_11.Location = new System.Drawing.Point(22, 252);
            this.cbZSW1b_11.Name = "cbZSW1b_11";
            this.cbZSW1b_11.Size = new System.Drawing.Size(229, 22);
            this.cbZSW1b_11.TabIndex = 78;
            this.cbZSW1b_11.Text = "IMP limit not reached / Homed";
            this.cbZSW1b_11.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_8
            // 
            this.cbZSW1b_8.AutoSize = true;
            this.cbZSW1b_8.Location = new System.Drawing.Point(22, 195);
            this.cbZSW1b_8.Name = "cbZSW1b_8";
            this.cbZSW1b_8.Size = new System.Drawing.Size(203, 22);
            this.cbZSW1b_8.TabIndex = 77;
            this.cbZSW1b_8.Text = "Velocity / Position in range";
            this.cbZSW1b_8.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_7
            // 
            this.cbZSW1b_7.AutoSize = true;
            this.cbZSW1b_7.Location = new System.Drawing.Point(22, 175);
            this.cbZSW1b_7.Name = "cbZSW1b_7";
            this.cbZSW1b_7.Size = new System.Drawing.Size(143, 22);
            this.cbZSW1b_7.TabIndex = 76;
            this.cbZSW1b_7.Text = "Warning effective";
            this.cbZSW1b_7.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_6
            // 
            this.cbZSW1b_6.AutoSize = true;
            this.cbZSW1b_6.Location = new System.Drawing.Point(22, 156);
            this.cbZSW1b_6.Name = "cbZSW1b_6";
            this.cbZSW1b_6.Size = new System.Drawing.Size(169, 22);
            this.cbZSW1b_6.TabIndex = 75;
            this.cbZSW1b_6.Text = "Switch on lock active";
            this.cbZSW1b_6.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_5
            // 
            this.cbZSW1b_5.AutoSize = true;
            this.cbZSW1b_5.Location = new System.Drawing.Point(22, 137);
            this.cbZSW1b_5.Name = "cbZSW1b_5";
            this.cbZSW1b_5.Size = new System.Drawing.Size(170, 22);
            this.cbZSW1b_5.TabIndex = 74;
            this.cbZSW1b_5.Text = "Fast stop active (NC)";
            this.cbZSW1b_5.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_4
            // 
            this.cbZSW1b_4.AutoSize = true;
            this.cbZSW1b_4.Location = new System.Drawing.Point(22, 118);
            this.cbZSW1b_4.Name = "cbZSW1b_4";
            this.cbZSW1b_4.Size = new System.Drawing.Size(167, 22);
            this.cbZSW1b_4.TabIndex = 73;
            this.cbZSW1b_4.Text = "Coasting active (NC)";
            this.cbZSW1b_4.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_3
            // 
            this.cbZSW1b_3.AutoSize = true;
            this.cbZSW1b_3.Location = new System.Drawing.Point(22, 99);
            this.cbZSW1b_3.Name = "cbZSW1b_3";
            this.cbZSW1b_3.Size = new System.Drawing.Size(164, 22);
            this.cbZSW1b_3.TabIndex = 72;
            this.cbZSW1b_3.Text = "Mulfunction effective";
            this.cbZSW1b_3.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_2
            // 
            this.cbZSW1b_2.AutoSize = true;
            this.cbZSW1b_2.Location = new System.Drawing.Point(22, 80);
            this.cbZSW1b_2.Name = "cbZSW1b_2";
            this.cbZSW1b_2.Size = new System.Drawing.Size(150, 22);
            this.cbZSW1b_2.TabIndex = 71;
            this.cbZSW1b_2.Text = "Operation enabled";
            this.cbZSW1b_2.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_1
            // 
            this.cbZSW1b_1.AutoSize = true;
            this.cbZSW1b_1.Location = new System.Drawing.Point(22, 61);
            this.cbZSW1b_1.Name = "cbZSW1b_1";
            this.cbZSW1b_1.Size = new System.Drawing.Size(160, 22);
            this.cbZSW1b_1.TabIndex = 70;
            this.cbZSW1b_1.Text = "Ready for operation";
            this.cbZSW1b_1.UseVisualStyleBackColor = true;
            // 
            // cbZSW1b_0
            // 
            this.cbZSW1b_0.AutoSize = true;
            this.cbZSW1b_0.Location = new System.Drawing.Point(22, 42);
            this.cbZSW1b_0.Name = "cbZSW1b_0";
            this.cbZSW1b_0.Size = new System.Drawing.Size(192, 22);
            this.cbZSW1b_0.TabIndex = 69;
            this.cbZSW1b_0.Text = "Ready to be switched on";
            this.cbZSW1b_0.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(197, 8);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(39, 18);
            this.label34.TabIndex = 38;
            this.label34.Text = "Input";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cbPZSW1b_15);
            this.tabPage5.Controls.Add(this.cbPZSW1b_14);
            this.tabPage5.Controls.Add(this.cbPZSW1b_13);
            this.tabPage5.Controls.Add(this.cbPZSW1b_12);
            this.tabPage5.Controls.Add(this.cbPZSW1b_11);
            this.tabPage5.Controls.Add(this.cbPZSW1b_10);
            this.tabPage5.Controls.Add(this.cbPZSW1b_9);
            this.tabPage5.Controls.Add(this.cbPZSW1b_8);
            this.tabPage5.Controls.Add(this.cbPZSW1b_7);
            this.tabPage5.Controls.Add(this.cbPZSW1b_6);
            this.tabPage5.Controls.Add(this.cbPZSW1b_5);
            this.tabPage5.Controls.Add(this.cbPZSW1b_4);
            this.tabPage5.Controls.Add(this.cbPZSW1b_3);
            this.tabPage5.Controls.Add(this.cbPZSW1b_2);
            this.tabPage5.Controls.Add(this.cbPZSW1b_1);
            this.tabPage5.Controls.Add(this.cbPZSW1b_0);
            this.tabPage5.Controls.Add(this.label36);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(258, 360);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "PZSW1";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_15
            // 
            this.cbPZSW1b_15.AutoSize = true;
            this.cbPZSW1b_15.Location = new System.Drawing.Point(22, 328);
            this.cbPZSW1b_15.Name = "cbPZSW1b_15";
            this.cbPZSW1b_15.Size = new System.Drawing.Size(99, 22);
            this.cbPZSW1b_15.TabIndex = 84;
            this.cbPZSW1b_15.Text = "MDI active";
            this.cbPZSW1b_15.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_14
            // 
            this.cbPZSW1b_14.AutoSize = true;
            this.cbPZSW1b_14.Location = new System.Drawing.Point(22, 309);
            this.cbPZSW1b_14.Name = "cbPZSW1b_14";
            this.cbPZSW1b_14.Size = new System.Drawing.Size(35, 22);
            this.cbPZSW1b_14.TabIndex = 83;
            this.cbPZSW1b_14.Text = "-";
            this.cbPZSW1b_14.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_13
            // 
            this.cbPZSW1b_13.AutoSize = true;
            this.cbPZSW1b_13.Location = new System.Drawing.Point(22, 290);
            this.cbPZSW1b_13.Name = "cbPZSW1b_13";
            this.cbPZSW1b_13.Size = new System.Drawing.Size(192, 22);
            this.cbPZSW1b_13.TabIndex = 82;
            this.cbPZSW1b_13.Text = "Positioning record active";
            this.cbPZSW1b_13.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_12
            // 
            this.cbPZSW1b_12.AutoSize = true;
            this.cbPZSW1b_12.Location = new System.Drawing.Point(22, 271);
            this.cbPZSW1b_12.Name = "cbPZSW1b_12";
            this.cbPZSW1b_12.Size = new System.Drawing.Size(35, 22);
            this.cbPZSW1b_12.TabIndex = 81;
            this.cbPZSW1b_12.Text = "-";
            this.cbPZSW1b_12.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_11
            // 
            this.cbPZSW1b_11.AutoSize = true;
            this.cbPZSW1b_11.Location = new System.Drawing.Point(22, 252);
            this.cbPZSW1b_11.Name = "cbPZSW1b_11";
            this.cbPZSW1b_11.Size = new System.Drawing.Size(124, 22);
            this.cbPZSW1b_11.TabIndex = 80;
            this.cbPZSW1b_11.Text = "Homing active";
            this.cbPZSW1b_11.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_10
            // 
            this.cbPZSW1b_10.AutoSize = true;
            this.cbPZSW1b_10.Location = new System.Drawing.Point(22, 233);
            this.cbPZSW1b_10.Name = "cbPZSW1b_10";
            this.cbPZSW1b_10.Size = new System.Drawing.Size(124, 22);
            this.cbPZSW1b_10.TabIndex = 79;
            this.cbPZSW1b_10.Text = "Jogging active";
            this.cbPZSW1b_10.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_9
            // 
            this.cbPZSW1b_9.AutoSize = true;
            this.cbPZSW1b_9.Location = new System.Drawing.Point(22, 214);
            this.cbPZSW1b_9.Name = "cbPZSW1b_9";
            this.cbPZSW1b_9.Size = new System.Drawing.Size(215, 22);
            this.cbPZSW1b_9.TabIndex = 78;
            this.cbPZSW1b_9.Text = "Positive limit switch reached";
            this.cbPZSW1b_9.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_8
            // 
            this.cbPZSW1b_8.AutoSize = true;
            this.cbPZSW1b_8.Location = new System.Drawing.Point(22, 195);
            this.cbPZSW1b_8.Name = "cbPZSW1b_8";
            this.cbPZSW1b_8.Size = new System.Drawing.Size(220, 22);
            this.cbPZSW1b_8.TabIndex = 77;
            this.cbPZSW1b_8.Text = "Negative limit switch reached";
            this.cbPZSW1b_8.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_7
            // 
            this.cbPZSW1b_7.AutoSize = true;
            this.cbPZSW1b_7.Location = new System.Drawing.Point(22, 175);
            this.cbPZSW1b_7.Name = "cbPZSW1b_7";
            this.cbPZSW1b_7.Size = new System.Drawing.Size(35, 22);
            this.cbPZSW1b_7.TabIndex = 76;
            this.cbPZSW1b_7.Text = "-";
            this.cbPZSW1b_7.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_6
            // 
            this.cbPZSW1b_6.AutoSize = true;
            this.cbPZSW1b_6.Location = new System.Drawing.Point(22, 156);
            this.cbPZSW1b_6.Name = "cbPZSW1b_6";
            this.cbPZSW1b_6.Size = new System.Drawing.Size(226, 22);
            this.cbPZSW1b_6.TabIndex = 75;
            this.cbPZSW1b_6.Text = "Active positioning record bit  6";
            this.cbPZSW1b_6.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_5
            // 
            this.cbPZSW1b_5.AutoSize = true;
            this.cbPZSW1b_5.Location = new System.Drawing.Point(22, 137);
            this.cbPZSW1b_5.Name = "cbPZSW1b_5";
            this.cbPZSW1b_5.Size = new System.Drawing.Size(226, 22);
            this.cbPZSW1b_5.TabIndex = 74;
            this.cbPZSW1b_5.Text = "Active positioning record bit  5";
            this.cbPZSW1b_5.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_4
            // 
            this.cbPZSW1b_4.AutoSize = true;
            this.cbPZSW1b_4.Location = new System.Drawing.Point(22, 118);
            this.cbPZSW1b_4.Name = "cbPZSW1b_4";
            this.cbPZSW1b_4.Size = new System.Drawing.Size(226, 22);
            this.cbPZSW1b_4.TabIndex = 73;
            this.cbPZSW1b_4.Text = "Active positioning record bit  4";
            this.cbPZSW1b_4.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_3
            // 
            this.cbPZSW1b_3.AutoSize = true;
            this.cbPZSW1b_3.Location = new System.Drawing.Point(22, 99);
            this.cbPZSW1b_3.Name = "cbPZSW1b_3";
            this.cbPZSW1b_3.Size = new System.Drawing.Size(226, 22);
            this.cbPZSW1b_3.TabIndex = 72;
            this.cbPZSW1b_3.Text = "Active positioning record bit  3";
            this.cbPZSW1b_3.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_2
            // 
            this.cbPZSW1b_2.AutoSize = true;
            this.cbPZSW1b_2.Location = new System.Drawing.Point(22, 80);
            this.cbPZSW1b_2.Name = "cbPZSW1b_2";
            this.cbPZSW1b_2.Size = new System.Drawing.Size(226, 22);
            this.cbPZSW1b_2.TabIndex = 71;
            this.cbPZSW1b_2.Text = "Active positioning record bit  2";
            this.cbPZSW1b_2.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_1
            // 
            this.cbPZSW1b_1.AutoSize = true;
            this.cbPZSW1b_1.Location = new System.Drawing.Point(22, 61);
            this.cbPZSW1b_1.Name = "cbPZSW1b_1";
            this.cbPZSW1b_1.Size = new System.Drawing.Size(226, 22);
            this.cbPZSW1b_1.TabIndex = 70;
            this.cbPZSW1b_1.Text = "Active positioning record bit  1";
            this.cbPZSW1b_1.UseVisualStyleBackColor = true;
            // 
            // cbPZSW1b_0
            // 
            this.cbPZSW1b_0.AutoSize = true;
            this.cbPZSW1b_0.Location = new System.Drawing.Point(22, 42);
            this.cbPZSW1b_0.Name = "cbPZSW1b_0";
            this.cbPZSW1b_0.Size = new System.Drawing.Size(226, 22);
            this.cbPZSW1b_0.TabIndex = 69;
            this.cbPZSW1b_0.Text = "Active positioning record bit  0";
            this.cbPZSW1b_0.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(197, 8);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(39, 18);
            this.label36.TabIndex = 39;
            this.label36.Text = "Input";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbPZSW2b_15);
            this.tabPage2.Controls.Add(this.cbPZSW2b_14);
            this.tabPage2.Controls.Add(this.cbPZSW2b_13);
            this.tabPage2.Controls.Add(this.cbPZSW2b_12);
            this.tabPage2.Controls.Add(this.cbPZSW2b_11);
            this.tabPage2.Controls.Add(this.cbPZSW2b_10);
            this.tabPage2.Controls.Add(this.cbPZSW2b_9);
            this.tabPage2.Controls.Add(this.cbPZSW2b_8);
            this.tabPage2.Controls.Add(this.cbPZSW2b_7);
            this.tabPage2.Controls.Add(this.cbPZSW2b_6);
            this.tabPage2.Controls.Add(this.cbPZSW2b_5);
            this.tabPage2.Controls.Add(this.cbPZSW2b_4);
            this.tabPage2.Controls.Add(this.cbPZSW2b_3);
            this.tabPage2.Controls.Add(this.cbPZSW2b_2);
            this.tabPage2.Controls.Add(this.cbPZSW2b_1);
            this.tabPage2.Controls.Add(this.cbPZSW2b_0);
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(258, 360);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "PZSW2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_15
            // 
            this.cbPZSW2b_15.AutoSize = true;
            this.cbPZSW2b_15.Location = new System.Drawing.Point(22, 328);
            this.cbPZSW2b_15.Name = "cbPZSW2b_15";
            this.cbPZSW2b_15.Size = new System.Drawing.Size(197, 22);
            this.cbPZSW2b_15.TabIndex = 101;
            this.cbPZSW2b_15.Text = "Position command active";
            this.cbPZSW2b_15.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_14
            // 
            this.cbPZSW2b_14.AutoSize = true;
            this.cbPZSW2b_14.Location = new System.Drawing.Point(22, 309);
            this.cbPZSW2b_14.Name = "cbPZSW2b_14";
            this.cbPZSW2b_14.Size = new System.Drawing.Size(196, 22);
            this.cbPZSW2b_14.TabIndex = 100;
            this.cbPZSW2b_14.Text = "Travel to fixed stop active";
            this.cbPZSW2b_14.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_13
            // 
            this.cbPZSW2b_13.AutoSize = true;
            this.cbPZSW2b_13.Location = new System.Drawing.Point(22, 290);
            this.cbPZSW2b_13.Name = "cbPZSW2b_13";
            this.cbPZSW2b_13.Size = new System.Drawing.Size(264, 22);
            this.cbPZSW2b_13.TabIndex = 99;
            this.cbPZSW2b_13.Text = "Fixed stop clamping torque reached";
            this.cbPZSW2b_13.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_12
            // 
            this.cbPZSW2b_12.AutoSize = true;
            this.cbPZSW2b_12.Location = new System.Drawing.Point(22, 271);
            this.cbPZSW2b_12.Name = "cbPZSW2b_12";
            this.cbPZSW2b_12.Size = new System.Drawing.Size(155, 22);
            this.cbPZSW2b_12.TabIndex = 98;
            this.cbPZSW2b_12.Text = "Fixed stop reached";
            this.cbPZSW2b_12.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_11
            // 
            this.cbPZSW2b_11.AutoSize = true;
            this.cbPZSW2b_11.Location = new System.Drawing.Point(22, 252);
            this.cbPZSW2b_11.Name = "cbPZSW2b_11";
            this.cbPZSW2b_11.Size = new System.Drawing.Size(270, 22);
            this.cbPZSW2b_11.TabIndex = 97;
            this.cbPZSW2b_11.Text = "Direct output 2 via positioning record";
            this.cbPZSW2b_11.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_10
            // 
            this.cbPZSW2b_10.AutoSize = true;
            this.cbPZSW2b_10.Location = new System.Drawing.Point(22, 233);
            this.cbPZSW2b_10.Name = "cbPZSW2b_10";
            this.cbPZSW2b_10.Size = new System.Drawing.Size(270, 22);
            this.cbPZSW2b_10.TabIndex = 96;
            this.cbPZSW2b_10.Text = "Direct output 1 via positioning record";
            this.cbPZSW2b_10.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_9
            // 
            this.cbPZSW2b_9.AutoSize = true;
            this.cbPZSW2b_9.Location = new System.Drawing.Point(22, 214);
            this.cbPZSW2b_9.Name = "cbPZSW2b_9";
            this.cbPZSW2b_9.Size = new System.Drawing.Size(242, 22);
            this.cbPZSW2b_9.TabIndex = 95;
            this.cbPZSW2b_9.Text = "Actual position <= Cam switch 1";
            this.cbPZSW2b_9.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_8
            // 
            this.cbPZSW2b_8.AutoSize = true;
            this.cbPZSW2b_8.Location = new System.Drawing.Point(22, 195);
            this.cbPZSW2b_8.Name = "cbPZSW2b_8";
            this.cbPZSW2b_8.Size = new System.Drawing.Size(242, 22);
            this.cbPZSW2b_8.TabIndex = 94;
            this.cbPZSW2b_8.Text = "Actual position <= Cam switch 0";
            this.cbPZSW2b_8.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_7
            // 
            this.cbPZSW2b_7.AutoSize = true;
            this.cbPZSW2b_7.Location = new System.Drawing.Point(22, 175);
            this.cbPZSW2b_7.Name = "cbPZSW2b_7";
            this.cbPZSW2b_7.Size = new System.Drawing.Size(261, 22);
            this.cbPZSW2b_7.TabIndex = 93;
            this.cbPZSW2b_7.Text = "Positive software limit switch active";
            this.cbPZSW2b_7.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_6
            // 
            this.cbPZSW2b_6.AutoSize = true;
            this.cbPZSW2b_6.Location = new System.Drawing.Point(22, 156);
            this.cbPZSW2b_6.Name = "cbPZSW2b_6";
            this.cbPZSW2b_6.Size = new System.Drawing.Size(266, 22);
            this.cbPZSW2b_6.TabIndex = 92;
            this.cbPZSW2b_6.Text = "Negative software limit switch active";
            this.cbPZSW2b_6.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_5
            // 
            this.cbPZSW2b_5.AutoSize = true;
            this.cbPZSW2b_5.Location = new System.Drawing.Point(22, 137);
            this.cbPZSW2b_5.Name = "cbPZSW2b_5";
            this.cbPZSW2b_5.Size = new System.Drawing.Size(179, 22);
            this.cbPZSW2b_5.TabIndex = 91;
            this.cbPZSW2b_5.Text = "Drive travels backward";
            this.cbPZSW2b_5.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_4
            // 
            this.cbPZSW2b_4.AutoSize = true;
            this.cbPZSW2b_4.Location = new System.Drawing.Point(22, 118);
            this.cbPZSW2b_4.Name = "cbPZSW2b_4";
            this.cbPZSW2b_4.Size = new System.Drawing.Size(165, 22);
            this.cbPZSW2b_4.TabIndex = 90;
            this.cbPZSW2b_4.Text = "Drive travels forward";
            this.cbPZSW2b_4.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_3
            // 
            this.cbPZSW2b_3.AutoSize = true;
            this.cbPZSW2b_3.Location = new System.Drawing.Point(22, 99);
            this.cbPZSW2b_3.Name = "cbPZSW2b_3";
            this.cbPZSW2b_3.Size = new System.Drawing.Size(35, 22);
            this.cbPZSW2b_3.TabIndex = 89;
            this.cbPZSW2b_3.Text = "-";
            this.cbPZSW2b_3.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_2
            // 
            this.cbPZSW2b_2.AutoSize = true;
            this.cbPZSW2b_2.Location = new System.Drawing.Point(22, 80);
            this.cbPZSW2b_2.Name = "cbPZSW2b_2";
            this.cbPZSW2b_2.Size = new System.Drawing.Size(179, 22);
            this.cbPZSW2b_2.TabIndex = 88;
            this.cbPZSW2b_2.Text = "Setpoint value stopped";
            this.cbPZSW2b_2.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_1
            // 
            this.cbPZSW2b_1.AutoSize = true;
            this.cbPZSW2b_1.Location = new System.Drawing.Point(22, 61);
            this.cbPZSW2b_1.Name = "cbPZSW2b_1";
            this.cbPZSW2b_1.Size = new System.Drawing.Size(172, 22);
            this.cbPZSW2b_1.TabIndex = 87;
            this.cbPZSW2b_1.Text = "Velocity limiting active";
            this.cbPZSW2b_1.UseVisualStyleBackColor = true;
            // 
            // cbPZSW2b_0
            // 
            this.cbPZSW2b_0.AutoSize = true;
            this.cbPZSW2b_0.Location = new System.Drawing.Point(22, 42);
            this.cbPZSW2b_0.Name = "cbPZSW2b_0";
            this.cbPZSW2b_0.Size = new System.Drawing.Size(171, 22);
            this.cbPZSW2b_0.TabIndex = 86;
            this.cbPZSW2b_0.Text = "Tracking mode active";
            this.cbPZSW2b_0.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(197, 8);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(39, 18);
            this.label33.TabIndex = 85;
            this.label33.Text = "Input";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txRawOut2);
            this.tabPage1.Controls.Add(this.txRawIn2);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(258, 360);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Raw";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txRawOut2
            // 
            this.txRawOut2.Location = new System.Drawing.Point(134, 34);
            this.txRawOut2.Multiline = true;
            this.txRawOut2.Name = "txRawOut2";
            this.txRawOut2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txRawOut2.Size = new System.Drawing.Size(118, 316);
            this.txRawOut2.TabIndex = 41;
            // 
            // txRawIn2
            // 
            this.txRawIn2.Location = new System.Drawing.Point(6, 34);
            this.txRawIn2.Multiline = true;
            this.txRawIn2.Name = "txRawIn2";
            this.txRawIn2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txRawIn2.Size = new System.Drawing.Size(122, 316);
            this.txRawIn2.TabIndex = 38;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(131, 11);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 18);
            this.label31.TabIndex = 40;
            this.label31.Text = "Output:";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(15, 11);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(43, 18);
            this.label32.TabIndex = 39;
            this.label32.Text = "Input:";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbExpand
            // 
            this.lbExpand.AutoSize = true;
            this.lbExpand.Location = new System.Drawing.Point(777, 71);
            this.lbExpand.Name = "lbExpand";
            this.lbExpand.Size = new System.Drawing.Size(26, 18);
            this.lbExpand.TabIndex = 46;
            this.lbExpand.Text = ">>";
            this.lbExpand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbExpand.Click += new System.EventHandler(this.LbExpand_Click);
            // 
            // tRefresh
            // 
            this.tRefresh.Enabled = true;
            this.tRefresh.Interval = 500;
            this.tRefresh.Tick += new System.EventHandler(this.TRefresh_Tick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txHidden
            // 
            this.txHidden.Location = new System.Drawing.Point(128, 55);
            this.txHidden.Name = "txHidden";
            this.txHidden.Size = new System.Drawing.Size(43, 24);
            this.txHidden.TabIndex = 47;
            this.txHidden.Text = "100";
            this.txHidden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txHidden.Visible = false;
            // 
            // lbHidden
            // 
            this.lbHidden.AutoSize = true;
            this.lbHidden.Location = new System.Drawing.Point(17, 58);
            this.lbHidden.Name = "lbHidden";
            this.lbHidden.Size = new System.Drawing.Size(134, 18);
            this.lbHidden.TabIndex = 48;
            this.lbHidden.Text = "Set Read TimeOut:";
            this.lbHidden.Visible = false;
            this.lbHidden.Click += new System.EventHandler(this.lbHidden_Click);
            // 
            // btHidden
            // 
            this.btHidden.Location = new System.Drawing.Point(177, 54);
            this.btHidden.Name = "btHidden";
            this.btHidden.Size = new System.Drawing.Size(31, 23);
            this.btHidden.TabIndex = 49;
            this.btHidden.Text = "R";
            this.btHidden.UseVisualStyleBackColor = true;
            this.btHidden.Visible = false;
            this.btHidden.Click += new System.EventHandler(this.btHidden_Click);
            // 
            // lbConnectedSince
            // 
            this.lbConnectedSince.Location = new System.Drawing.Point(246, 58);
            this.lbConnectedSince.Name = "lbConnectedSince";
            this.lbConnectedSince.Size = new System.Drawing.Size(202, 19);
            this.lbConnectedSince.TabIndex = 50;
            this.lbConnectedSince.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbConnectedSince.Visible = false;
            // 
            // frCMMTModbus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 565);
            this.Controls.Add(this.lbConnectedSince);
            this.Controls.Add(this.gbMonitorInput);
            this.Controls.Add(this.btHidden);
            this.Controls.Add(this.lbHidden);
            this.Controls.Add(this.txHidden);
            this.Controls.Add(this.gbDebug);
            this.Controls.Add(this.gbDynamic);
            this.Controls.Add(this.lbExpand);
            this.Controls.Add(this.gbTakeControl);
            this.Controls.Add(this.gbConnect);
            this.Controls.Add(this.gbSetting);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbFesto);
            this.Controls.Add(this.ssStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frCMMTModbus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMMT-xx-EP Modbus v1.01";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrCMMTModbus_FormClosing);
            this.Load += new System.EventHandler(this.FrCMMTModbus_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFesto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbSetting.ResumeLayout(false);
            this.gbSetting.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.gbTest.ResumeLayout(false);
            this.gbLimit.ResumeLayout(false);
            this.gbLimit.PerformLayout();
            this.gbJog.ResumeLayout(false);
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbDebug.ResumeLayout(false);
            this.gbDebug.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpSTW1.ResumeLayout(false);
            this.tpSTW1.PerformLayout();
            this.tpPSTW1.ResumeLayout(false);
            this.tpPSTW1.PerformLayout();
            this.tpPSTW2.ResumeLayout(false);
            this.tpPSTW2.PerformLayout();
            this.tpZSW1.ResumeLayout(false);
            this.tpZSW1.PerformLayout();
            this.tpPZSW1.ResumeLayout(false);
            this.tpPZSW1.PerformLayout();
            this.tpPZSW2.ResumeLayout(false);
            this.tpPZSW2.PerformLayout();
            this.tpRaw.ResumeLayout(false);
            this.tpRaw.PerformLayout();
            this.tpExtOut.ResumeLayout(false);
            this.tpExtOut.PerformLayout();
            this.gbDynamic.ResumeLayout(false);
            this.gbDynamic.PerformLayout();
            this.gbConnect.ResumeLayout(false);
            this.gbTakeControl.ResumeLayout(false);
            this.gbTakeControl.PerformLayout();
            this.gbMonitorInput.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox txIPAddress;
        private System.Windows.Forms.Timer tCycle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txExtendedOW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txExtendedIW;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.PictureBox pbFesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txRawIn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txVelocityOutputFG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txVelocityInputFG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txPositionOutputFG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txPositionInputFG;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txCycleTime;
        private System.Windows.Forms.GroupBox gbDebug;
        private System.Windows.Forms.GroupBox gbDynamic;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbUnitVel;
        private System.Windows.Forms.Label lbUnitPos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txUnitVel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txUnitPos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txTargetPosition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txTargetVelocity;
        private System.Windows.Forms.TextBox txOverride;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txDec;
        private System.Windows.Forms.TextBox txAcc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbSettingPrev;
        private System.Windows.Forms.Label lbSettingNext;
        private System.Windows.Forms.Label lbDebugPrev;
        private System.Windows.Forms.Label lbDebugNext;
        private System.Windows.Forms.Label lbDynamicPrev;
        private System.Windows.Forms.Label lbDynamicNext;
        private System.Windows.Forms.CheckBox cbTakeControl;
        private System.Windows.Forms.GroupBox gbConnect;
        private System.Windows.Forms.GroupBox gbTakeControl;
        private System.Windows.Forms.CheckBox cbEnableDrive;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRaw;
        private System.Windows.Forms.TextBox txRawOut;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tpSTW1;
        private System.Windows.Forms.CheckBox cbSTW1_7;
        private System.Windows.Forms.CheckBox cbSTW1_6;
        private System.Windows.Forms.CheckBox cbSTW1_5;
        private System.Windows.Forms.CheckBox cbSTW1_4;
        private System.Windows.Forms.CheckBox cbSTW1_3;
        private System.Windows.Forms.CheckBox cbSTW1_2;
        private System.Windows.Forms.CheckBox cbSTW1_1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox cbSTW1_0;
        private System.Windows.Forms.TabPage tpZSW1;
        private System.Windows.Forms.TabPage tpPSTW1;
        private System.Windows.Forms.TabPage tpPZSW1;
        private System.Windows.Forms.TabPage tpPSTW2;
        private System.Windows.Forms.CheckBox cbSTW1_14;
        private System.Windows.Forms.CheckBox cbSTW1_13;
        private System.Windows.Forms.CheckBox cbSTW1_12;
        private System.Windows.Forms.CheckBox cbSTW1_11;
        private System.Windows.Forms.CheckBox cbSTW1_10;
        private System.Windows.Forms.CheckBox cbSTW1_9;
        private System.Windows.Forms.CheckBox cbSTW1_8;
        private System.Windows.Forms.CheckBox cbZSW1_15;
        private System.Windows.Forms.CheckBox cbZSW1_14;
        private System.Windows.Forms.CheckBox cbZSW1_13;
        private System.Windows.Forms.CheckBox cbZSW1_12;
        private System.Windows.Forms.CheckBox cbZSW1_10;
        private System.Windows.Forms.CheckBox cbZSW1_11;
        private System.Windows.Forms.CheckBox cbZSW1_8;
        private System.Windows.Forms.CheckBox cbZSW1_7;
        private System.Windows.Forms.CheckBox cbZSW1_6;
        private System.Windows.Forms.CheckBox cbZSW1_5;
        private System.Windows.Forms.CheckBox cbZSW1_4;
        private System.Windows.Forms.CheckBox cbZSW1_3;
        private System.Windows.Forms.CheckBox cbZSW1_2;
        private System.Windows.Forms.CheckBox cbZSW1_1;
        private System.Windows.Forms.CheckBox cbZSW1_0;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox cbPSTW1_14;
        private System.Windows.Forms.CheckBox cbPSTW1_13;
        private System.Windows.Forms.CheckBox cbPSTW1_12;
        private System.Windows.Forms.CheckBox cbPSTW1_11;
        private System.Windows.Forms.CheckBox cbPSTW1_10;
        private System.Windows.Forms.CheckBox cbPSTW1_9;
        private System.Windows.Forms.CheckBox cbPSTW1_8;
        private System.Windows.Forms.CheckBox cbPSTW1_7;
        private System.Windows.Forms.CheckBox cbPSTW1_6;
        private System.Windows.Forms.CheckBox cbPSTW1_5;
        private System.Windows.Forms.CheckBox cbPSTW1_4;
        private System.Windows.Forms.CheckBox cbPSTW1_3;
        private System.Windows.Forms.CheckBox cbPSTW1_2;
        private System.Windows.Forms.CheckBox cbPSTW1_1;
        private System.Windows.Forms.CheckBox cbPSTW1_0;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox cbPZSW1_14;
        private System.Windows.Forms.CheckBox cbPZSW1_13;
        private System.Windows.Forms.CheckBox cbPZSW1_12;
        private System.Windows.Forms.CheckBox cbPZSW1_11;
        private System.Windows.Forms.CheckBox cbPZSW1_10;
        private System.Windows.Forms.CheckBox cbPZSW1_9;
        private System.Windows.Forms.CheckBox cbPZSW1_8;
        private System.Windows.Forms.CheckBox cbPZSW1_7;
        private System.Windows.Forms.CheckBox cbPZSW1_6;
        private System.Windows.Forms.CheckBox cbPZSW1_5;
        private System.Windows.Forms.CheckBox cbPZSW1_4;
        private System.Windows.Forms.CheckBox cbPZSW1_3;
        private System.Windows.Forms.CheckBox cbPZSW1_2;
        private System.Windows.Forms.CheckBox cbPZSW1_1;
        private System.Windows.Forms.CheckBox cbPZSW1_0;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox cbPSTW2_14;
        private System.Windows.Forms.CheckBox cbPSTW2_13;
        private System.Windows.Forms.CheckBox cbPSTW2_12;
        private System.Windows.Forms.CheckBox cbPSTW2_11;
        private System.Windows.Forms.CheckBox cbPSTW2_10;
        private System.Windows.Forms.CheckBox cbPSTW2_9;
        private System.Windows.Forms.CheckBox cbPSTW2_8;
        private System.Windows.Forms.CheckBox cbPSTW2_7;
        private System.Windows.Forms.CheckBox cbPSTW2_6;
        private System.Windows.Forms.CheckBox cbPSTW2_5;
        private System.Windows.Forms.CheckBox cbPSTW2_4;
        private System.Windows.Forms.CheckBox cbPSTW2_3;
        private System.Windows.Forms.CheckBox cbPSTW2_2;
        private System.Windows.Forms.CheckBox cbPSTW2_1;
        private System.Windows.Forms.CheckBox cbPSTW2_0;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox cbSTW1_15;
        private System.Windows.Forms.CheckBox cbZSW1_9;
        private System.Windows.Forms.CheckBox cbPSTW1_15;
        private System.Windows.Forms.CheckBox cbPZSW1_15;
        private System.Windows.Forms.CheckBox cbPSTW2_15;
        private System.Windows.Forms.CheckBox cbSTW1Write;
        private System.Windows.Forms.CheckBox cbPSTW1Write;
        private System.Windows.Forms.CheckBox cbPSTW2Write;
        private System.Windows.Forms.ToolStripStatusLabel lbCmmtStatus;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.RadioButton rbHoming;
        private System.Windows.Forms.RadioButton rbRecordSelection;
        private System.Windows.Forms.RadioButton rbMoveRelative;
        private System.Windows.Forms.RadioButton rbMoveAbsolute;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.Button btAck;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.TextBox txRecordSelection;
        private System.Windows.Forms.Button btJog1;
        private System.Windows.Forms.Button btJog2;
        private System.Windows.Forms.GroupBox gbJog;
        private System.Windows.Forms.Button ErrorIndicator;
        private System.Windows.Forms.ToolStripStatusLabel lbActualPosition;
        private System.Windows.Forms.ToolStripStatusLabel lbActualVelocity;
        private System.Windows.Forms.Label lbHomingTimeOut;
        private System.Windows.Forms.Label lbTimeWait;
        private System.Windows.Forms.Label lbTimeOut;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txHomingTimeOut;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txTimeWait;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txTimeOut;
        private System.Windows.Forms.GroupBox gbMonitorInput;
        private System.Windows.Forms.Label lbExpand;
        private System.Windows.Forms.Timer tRefresh;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox cbZSW1b_9;
        private System.Windows.Forms.CheckBox cbZSW1b_15;
        private System.Windows.Forms.CheckBox cbZSW1b_14;
        private System.Windows.Forms.CheckBox cbZSW1b_13;
        private System.Windows.Forms.CheckBox cbZSW1b_12;
        private System.Windows.Forms.CheckBox cbZSW1b_10;
        private System.Windows.Forms.CheckBox cbZSW1b_11;
        private System.Windows.Forms.CheckBox cbZSW1b_8;
        private System.Windows.Forms.CheckBox cbZSW1b_7;
        private System.Windows.Forms.CheckBox cbZSW1b_6;
        private System.Windows.Forms.CheckBox cbZSW1b_5;
        private System.Windows.Forms.CheckBox cbZSW1b_4;
        private System.Windows.Forms.CheckBox cbZSW1b_3;
        private System.Windows.Forms.CheckBox cbZSW1b_2;
        private System.Windows.Forms.CheckBox cbZSW1b_1;
        private System.Windows.Forms.CheckBox cbZSW1b_0;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox cbPZSW1b_15;
        private System.Windows.Forms.CheckBox cbPZSW1b_14;
        private System.Windows.Forms.CheckBox cbPZSW1b_13;
        private System.Windows.Forms.CheckBox cbPZSW1b_12;
        private System.Windows.Forms.CheckBox cbPZSW1b_11;
        private System.Windows.Forms.CheckBox cbPZSW1b_10;
        private System.Windows.Forms.CheckBox cbPZSW1b_9;
        private System.Windows.Forms.CheckBox cbPZSW1b_8;
        private System.Windows.Forms.CheckBox cbPZSW1b_7;
        private System.Windows.Forms.CheckBox cbPZSW1b_6;
        private System.Windows.Forms.CheckBox cbPZSW1b_5;
        private System.Windows.Forms.CheckBox cbPZSW1b_4;
        private System.Windows.Forms.CheckBox cbPZSW1b_3;
        private System.Windows.Forms.CheckBox cbPZSW1b_2;
        private System.Windows.Forms.CheckBox cbPZSW1b_1;
        private System.Windows.Forms.CheckBox cbPZSW1b_0;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txRawOut2;
        private System.Windows.Forms.TextBox txRawIn2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TabPage tpExtOut;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txOW23;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txOW20;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txOW22;
        private System.Windows.Forms.TextBox txOW21;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txOW19;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txOW16;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txOW18;
        private System.Windows.Forms.TextBox txOW17;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txOW15;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txOW12;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txOW14;
        private System.Windows.Forms.TextBox txOW13;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.CheckBox cbExtendedWrite;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbPZSW2b_15;
        private System.Windows.Forms.CheckBox cbPZSW2b_14;
        private System.Windows.Forms.CheckBox cbPZSW2b_13;
        private System.Windows.Forms.CheckBox cbPZSW2b_12;
        private System.Windows.Forms.CheckBox cbPZSW2b_11;
        private System.Windows.Forms.CheckBox cbPZSW2b_10;
        private System.Windows.Forms.CheckBox cbPZSW2b_9;
        private System.Windows.Forms.CheckBox cbPZSW2b_8;
        private System.Windows.Forms.CheckBox cbPZSW2b_7;
        private System.Windows.Forms.CheckBox cbPZSW2b_6;
        private System.Windows.Forms.CheckBox cbPZSW2b_5;
        private System.Windows.Forms.CheckBox cbPZSW2b_4;
        private System.Windows.Forms.CheckBox cbPZSW2b_3;
        private System.Windows.Forms.CheckBox cbPZSW2b_2;
        private System.Windows.Forms.CheckBox cbPZSW2b_1;
        private System.Windows.Forms.CheckBox cbPZSW2b_0;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TabPage tpPZSW2;
        private System.Windows.Forms.CheckBox cbPZSW2_15;
        private System.Windows.Forms.CheckBox cbPZSW2_14;
        private System.Windows.Forms.CheckBox cbPZSW2_13;
        private System.Windows.Forms.CheckBox cbPZSW2_12;
        private System.Windows.Forms.CheckBox cbPZSW2_11;
        private System.Windows.Forms.CheckBox cbPZSW2_10;
        private System.Windows.Forms.CheckBox cbPZSW2_9;
        private System.Windows.Forms.CheckBox cbPZSW2_8;
        private System.Windows.Forms.CheckBox cbPZSW2_7;
        private System.Windows.Forms.CheckBox cbPZSW2_6;
        private System.Windows.Forms.CheckBox cbPZSW2_5;
        private System.Windows.Forms.CheckBox cbPZSW2_4;
        private System.Windows.Forms.CheckBox cbPZSW2_3;
        private System.Windows.Forms.CheckBox cbPZSW2_2;
        private System.Windows.Forms.CheckBox cbPZSW2_1;
        private System.Windows.Forms.CheckBox cbPZSW2_0;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.GroupBox gbLimit;
        private System.Windows.Forms.CheckBox cbSoftware;
        private System.Windows.Forms.CheckBox cbHardware;
        private System.Windows.Forms.TextBox txModbusTimeOut;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.GroupBox gbTest;
        private System.Windows.Forms.Button btStartTest;
        private System.Windows.Forms.Button btHelp;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label lbHidden;
        private System.Windows.Forms.TextBox txHidden;
        private System.Windows.Forms.Button btHidden;
        private System.Windows.Forms.Label lbConnectedSince;
    }
}