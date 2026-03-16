namespace CMMT_EP_ModbusTCP
{
    partial class frHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frHelp));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbFASVelocity = new System.Windows.Forms.ComboBox();
            this.cbFASPosition = new System.Windows.Forms.ComboBox();
            this.txVelocityInput = new System.Windows.Forms.TextBox();
            this.txPositionInput = new System.Windows.Forms.TextBox();
            this.txVelocityOutput = new System.Windows.Forms.TextBox();
            this.txPositionOutput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.bPositionOutput = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txFASBaseVelocity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.cbFASVelocity);
            this.groupBox1.Controls.Add(this.cbFASPosition);
            this.groupBox1.Controls.Add(this.txVelocityInput);
            this.groupBox1.Controls.Add(this.txPositionInput);
            this.groupBox1.Controls.Add(this.txVelocityOutput);
            this.groupBox1.Controls.Add(this.txPositionOutput);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.bPositionOutput);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txFASBaseVelocity);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 246);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "How to setup Factor Group";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 218);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(153, 13);
            this.label23.TabIndex = 29;
            this.label23.Text = "*Get these parameter from FAS";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(359, 218);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(285, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "*Manually copy these parameter to Factor Group parameter";
            // 
            // cbFASVelocity
            // 
            this.cbFASVelocity.FormattingEnabled = true;
            this.cbFASVelocity.Items.AddRange(new object[] {
            "-3",
            "-4",
            "-5",
            "-6"});
            this.cbFASVelocity.Location = new System.Drawing.Point(189, 92);
            this.cbFASVelocity.Name = "cbFASVelocity";
            this.cbFASVelocity.Size = new System.Drawing.Size(78, 21);
            this.cbFASVelocity.TabIndex = 27;
            this.cbFASVelocity.Text = "-3";
            this.cbFASVelocity.SelectedIndexChanged += new System.EventHandler(this.cbFASVelocity_SelectedIndexChanged);
            // 
            // cbFASPosition
            // 
            this.cbFASPosition.FormattingEnabled = true;
            this.cbFASPosition.Items.AddRange(new object[] {
            "-3",
            "-4",
            "-5",
            "-6"});
            this.cbFASPosition.Location = new System.Drawing.Point(189, 62);
            this.cbFASPosition.Name = "cbFASPosition";
            this.cbFASPosition.Size = new System.Drawing.Size(78, 21);
            this.cbFASPosition.TabIndex = 26;
            this.cbFASPosition.Text = "-6";
            this.cbFASPosition.SelectedIndexChanged += new System.EventHandler(this.cbFASPosition_SelectedIndexChanged);
            // 
            // txVelocityInput
            // 
            this.txVelocityInput.Location = new System.Drawing.Point(465, 174);
            this.txVelocityInput.Name = "txVelocityInput";
            this.txVelocityInput.Size = new System.Drawing.Size(78, 20);
            this.txVelocityInput.TabIndex = 25;
            this.txVelocityInput.Text = "2000000000";
            this.txVelocityInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txPositionInput
            // 
            this.txPositionInput.Location = new System.Drawing.Point(465, 145);
            this.txPositionInput.Name = "txPositionInput";
            this.txPositionInput.Size = new System.Drawing.Size(78, 20);
            this.txPositionInput.TabIndex = 24;
            this.txPositionInput.Text = "1000000";
            this.txPositionInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txVelocityOutput
            // 
            this.txVelocityOutput.Location = new System.Drawing.Point(465, 93);
            this.txVelocityOutput.Name = "txVelocityOutput";
            this.txVelocityOutput.Size = new System.Drawing.Size(78, 20);
            this.txVelocityOutput.TabIndex = 23;
            this.txVelocityOutput.Text = "1000";
            this.txVelocityOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txPositionOutput
            // 
            this.txPositionOutput.Location = new System.Drawing.Point(465, 63);
            this.txPositionOutput.Name = "txPositionOutput";
            this.txPositionOutput.Size = new System.Drawing.Size(78, 20);
            this.txPositionOutput.TabIndex = 22;
            this.txPositionOutput.Text = "1000000";
            this.txPositionOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(564, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "to display actual velocity";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(564, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "to display actual position";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(359, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Velocity Input:";
            // 
            // bPositionOutput
            // 
            this.bPositionOutput.AutoSize = true;
            this.bPositionOutput.Location = new System.Drawing.Point(359, 151);
            this.bPositionOutput.Name = "bPositionOutput";
            this.bPositionOutput.Size = new System.Drawing.Size(74, 13);
            this.bPositionOutput.TabIndex = 18;
            this.bPositionOutput.Text = "Position Input:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(564, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "to set target velocity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(564, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "to set target position";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Velocity Output:";
            // 
            // txFASBaseVelocity
            // 
            this.txFASBaseVelocity.Location = new System.Drawing.Point(189, 174);
            this.txFASBaseVelocity.Name = "txFASBaseVelocity";
            this.txFASBaseVelocity.Size = new System.Drawing.Size(78, 20);
            this.txFASBaseVelocity.TabIndex = 12;
            this.txFASBaseVelocity.Text = "0.5";
            this.txFASBaseVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txFASBaseVelocity.TextChanged += new System.EventHandler(this.txFASBaseVelocity_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "FAS Reference vaues";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Base value velocity (user unit):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Position Output:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Factor Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Velocity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "FAS Factor Group";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(30, 36);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox8.Size = new System.Drawing.Size(657, 423);
            this.textBox8.TabIndex = 26;
            this.textBox8.TabStop = false;
            this.textBox8.Text = resources.GetString("textBox8.Text");
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 257);
            this.panel2.TabIndex = 27;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 753);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 5);
            this.panel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.panel9);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 485);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "How to start";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 496);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(717, 11);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 496);
            this.panel5.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(711, 20);
            this.panel6.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(3, 36);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(27, 446);
            this.panel7.TabIndex = 28;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(687, 36);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(27, 446);
            this.panel8.TabIndex = 29;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(30, 459);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(657, 23);
            this.panel9.TabIndex = 30;
            // 
            // frHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 758);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frHelp";
            this.Text = "Help";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frHelp_FormClosing);
            this.Load += new System.EventHandler(this.frHelp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txFASBaseVelocity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label bPositionOutput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txVelocityInput;
        private System.Windows.Forms.TextBox txPositionInput;
        private System.Windows.Forms.TextBox txVelocityOutput;
        private System.Windows.Forms.TextBox txPositionOutput;
        private System.Windows.Forms.ComboBox cbFASVelocity;
        private System.Windows.Forms.ComboBox cbFASPosition;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panel2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
    }
}