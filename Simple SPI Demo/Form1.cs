using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_SPI_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AccessB AccB = new AccessB(); //First declare the AccessB object

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Find the device and enable buttons
        private void btnFindDev_Click(object sender, EventArgs e)
        {
            if (AccB.FindDevHID() == true)
            {
                lblStatus.Text = "Status: Connected";
                btnConfigure.Enabled = true;
                btnSPIOff.Enabled = true;
                btnSPIOn.Enabled = true;                
            }
            else
            {
                lblStatus.Text = "Status: Disconnected";
            }
        }

        //Configure SPI  Ck = 750kHz, master mode 11.
        private void btnConfigure_Click(object sender, EventArgs e)
        {
            AccB.SPI_CFG(AccB.SPI_CFG_CK_FOSCdiv64 | AccB.SPI_CFG_MASTER | AccB.SPI_CFG_MODE_11 | AccB.SPI_CFG_SAMPLE_MIDDLE);
        }

        //Enable SPI
        private void btnSPIOn_Click(object sender, EventArgs e)
        {
            AccB.SPI_Enable(true);
            btnSample.Enabled = true; //SPI transfer method is like a blocking function, so disable/enable the button is needed or the application will freeze
        }

        //Disable
        private void btnSPIOff_Click(object sender, EventArgs e)
        {
            AccB.SPI_Enable(false);
            btnSample.Enabled = false;//SPI transfer method is like a blocking function, so disable/enable the button is needed or the application will freeze
        }

        private void btnSample_Click(object sender, EventArgs e)
        {
            byte[] DummyData = new byte[2];//Dummy data, the SPI ADC don't need any command or data
            byte[] Rx = new byte[2]; //Array where transfer function will put the received data
            DummyData[0] = 0;
            DummyData[1] = 0;
            Rx = AccB.SPI_Transfer(2, 0, DummyData, AccB.CS_RA0);//Receive 2 bytes, transmit 0 bytes, chip select of the ADC is connected to RA0
            txbSample.Text = ((Rx[1] >> 1) | ((Rx[0] & 31) << 7)).ToString();//Data processing. Check the details of this in the MCP3021  datasheet.

        }
    }
}
