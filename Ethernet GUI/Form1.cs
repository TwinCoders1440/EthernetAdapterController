using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ethernet_GUI
{

    public partial class EthernetDEForm : Form
    {

        private Thread pbt;

        public EthernetDEForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            PBar.Value = 0;

            //declaring time for saving date & time entered by user.
            DateTime time = new DateTime(DateSet.Value.Year, DateSet.Value.Month, DateSet.Value.Day, TimeSet.Value.Hour, TimeSet.Value.Minute, TimeSet.Value.Second);
            TimeSpan timer = time - DateTime.Now;
            TimeSpan suber = new TimeSpan(0, 0, 1);

            if (timer.TotalSeconds < 0)
                PBar.Maximum = 0;
            else
                PBar.Maximum = (int) timer.TotalSeconds + 1;

            timelabel.Text = Convert.ToString(PBar.Maximum);

            string[] fargs = new string[10];//arguments for for loop.

            if(EnableCheck.Checked)
                fargs[0] = "e";
            else if(DisableCheck.Checked)
                fargs[0] = "d";
            
            //time & date.
            fargs[1] = Convert.ToString(DateSet.Value.Year);
            fargs[2] = Convert.ToString(DateSet.Value.Month);
            fargs[3] = Convert.ToString(DateSet.Value.Day);
            fargs[4] = Convert.ToString(TimeSet.Value.Hour);
            fargs[5] = Convert.ToString(TimeSet.Value.Minute);
            fargs[6] = Convert.ToString(TimeSet.Value.Second);

            //shutdown & freegate.
            if (Shutdowncheck.Checked)
                fargs[7] = "shut";
            else
                fargs[7] = "N";

            if (FreeGatecheck.Checked)
            {
                fargs[8] = "free";
                fargs[9] = FreeGate.Text;
            }
            else
            {
                fargs[8] = "N";
                fargs[9] = "N";
            }

            //for prosses.
            ProcessStartInfo forp = new ProcessStartInfo("EthP.exe");

            forp.Arguments = fargs[0] + " " + fargs[1] + " " + fargs[2] + " " + fargs[3] + " " + fargs[4] + " " + fargs[5] + " " +
                fargs[6] + " " + fargs[7] + " " + fargs[8] + " " + fargs[9];
            forp.UseShellExecute = true;
            forp.WindowStyle = ProcessWindowStyle.Normal;

            Process.Start(forp);

            //Pbar thread.

            this.pbt = new Thread(new ThreadStart(this.ProcessPBarValue));

            this.pbt.Start();

        }//end StartButton_Click().

        //proccesing PBar.
        public void ProcessPBarValue()
        {
            int t = this.PBar.Maximum;

            for (; this.PBar.Value != this.PBar.Maximum; )
            {
                t--;
                IncreasePBarValue();
                ChaingeTimeLabel1(t);

                Thread.Sleep(1000);
            }
        }

        delegate void IncreasePBarValueCallback();
        private void IncreasePBarValue()
        {
            if (this.PBar.InvokeRequired)
            {
                IncreasePBarValueCallback incPBV = new IncreasePBarValueCallback(IncreasePBarValue);
                Invoke(incPBV);

            }
            else
                this.PBar.Value++;

        }

        private delegate void ChangeTimeLabel1Callback(int time);
        public void ChaingeTimeLabel1(int time)
        {
            if (this.timelabel.InvokeRequired)
            {
                ChangeTimeLabel1Callback changeTL = new ChangeTimeLabel1Callback(ChaingeTimeLabel1);
                Invoke(changeTL, new object[] { time });

            }
            else
                timelabel.Text = Convert.ToString(time);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the name of God.\nEthernetED\n\tVersion 1 for Win32. Freeware\n\nCopyright by\n\tMorteza Ahmadzadeh\n\nContact\n\tmorteza1440@gmail.com", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }//end if

        }

    }//end class EthernetDE.

}//end namespace Ethernet_GUI.
