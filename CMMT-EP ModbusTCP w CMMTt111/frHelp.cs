using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMMT_EP_ModbusTCP
{
    public partial class frHelp : Form
    {
        public uint PositionOutput = 0;
        public uint PositionInput = 0;
        public uint VelocityOutput = 0;
        public uint VelocityInput = 0;

        public frHelp()
        {
            InitializeComponent();
        }

        private void GetPosition()
        {
            if (cbFASPosition.Text == "-3") { PositionOutput = 1000; }
            else if (cbFASPosition.Text == "-4") { PositionOutput = 10000; }
            else if (cbFASPosition.Text == "-5") { PositionOutput = 100000; }
            else if (cbFASPosition.Text == "-6") { PositionOutput = 1000000; }

            PositionInput = PositionOutput;
            txPositionOutput.Text = PositionOutput.ToString();
            txPositionInput.Text = PositionInput.ToString();
        }

        private void GetVelocityOutput()
        {
            if (cbFASVelocity.Text == "-3") { VelocityOutput = 1000; }
            else if (cbFASVelocity.Text == "-4") { VelocityOutput = 10000; }
            else if (cbFASVelocity.Text == "-5") { VelocityOutput = 100000; }
            else if (cbFASVelocity.Text == "-6") { VelocityOutput = 1000000; }

            txVelocityOutput.Text = VelocityOutput.ToString();
        }

        private void GetVelocityInput()
        {
            try
            {
                float BaseVelocity = float.Parse(txFASBaseVelocity.Text);
                VelocityInput = (uint)(1073741824 / BaseVelocity);
                txVelocityInput.Text = VelocityInput.ToString("0");
            }
            catch { }
        }

        private void cbFASPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPosition();
        }

        private void cbFASVelocity_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetVelocityOutput();
        }

        private void txFASBaseVelocity_TextChanged(object sender, EventArgs e)
        {
            GetVelocityInput();
        }

        private void frHelp_Load(object sender, EventArgs e)
        {
            GetPosition();
            GetVelocityOutput();
            GetVelocityInput();
        }

        private void frHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide(); 
            e.Cancel = true; 
                 
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
