using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using XRPCLib;
using XDevkitPlusPlus;

namespace MX_vs_ATV_Ult_RTE_Tool
{
    public partial class Form1 : MetroForm

    {

        XRPC Jtag = new XRPC();

        public Form1()
        {
            InitializeComponent();
        }

        private void connectConsole_Click(object sender, EventArgs e)
        {
            try
            {
                Jtag.Connect();
                if (Jtag.activeConnection == true)
                {
                    MessageBox.Show("Connected To Console", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboFive.Enabled = true;
                    comboEight.Enabled = true;
                    comboTen.Enabled = true;
                    moneyValue.Enabled = true;
                    freestyleValue.Enabled = true;
                }
                else
                {
                    MessageBox.Show("XRPC Connection Failed", "Connected Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("XBDM Connection Failed", "Connected Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //
        //
        //

        private void comboFive_Click(object sender, EventArgs e)
        {
            if (comboFiveTimer.Enabled)
            {
                comboFiveTimer.Stop();
                comboFiveStatus.Text = "Not Active";
            }
            else
            {
                comboFiveTimer.Start();
                comboFiveStatus.Text = "Active";
            }
        }

        private void comboFiveTimer_Tick(object sender, EventArgs e)
        {
            Jtag.xbCon.DebugTarget.WriteUInt32(0xC328AF18, 0x00000005);
        }

        //
        //
        //

        private void comboEight_Click(object sender, EventArgs e)
        {
            if (comboEightTimer.Enabled)
            {
                comboEightTimer.Stop();
                comboEightStatus.Text = "Not Active";
            }
            else
            {
                comboEightTimer.Start();
                comboEightStatus.Text = "Active";
            }
        }

        private void comboEightTimer_Tick(object sender, EventArgs e)
        {
            Jtag.xbCon.DebugTarget.WriteUInt32(0xC328AF18, 0x00000008);
        }

        //
        //
        //

        private void comboTen_Click(object sender, EventArgs e)
        {
            if (comboTenTimer.Enabled)
            {
                comboTenTimer.Stop();
                comboTenStatus.Text = "Not Active";
            }
            else
            {
                comboTenTimer.Start();
                comboTenStatus.Text = "Active";
            }
        }

        private void comboTenTimer_Tick(object sender, EventArgs e)
        {
            Jtag.xbCon.DebugTarget.WriteUInt32(0xC328AF18, 0x0000000A);
        }
        
        //
        //
        //

        private void setMoney_Click(object sender, EventArgs e)
        {
            Jtag.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC7EC98D0), Convert.ToInt32(moneyValue.Text));
        }

        private void setFreestyle_Click(object sender, EventArgs e)
        {
            Jtag.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xC328AF1C), Convert.ToInt32(freestyleValue.Text));
        }

        //Not Used ATM
        //
        //

        private void freestyleValue_Click(object sender, EventArgs e)
        {

        }

        private void moneyValue_Click(object sender, EventArgs e)
        {

        }
    }
}
