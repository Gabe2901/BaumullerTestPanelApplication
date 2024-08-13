using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ScottPlot.WinForms;

namespace BaumullerTestPanelApplication
{
    public partial class MainForm : Form
    {
        //TODO: add drive health check
        //TODO: setup modular code for drive control so it isn't this massive clump of spaghetti code for zero reason
        public MainForm()
        {
            InitializeComponent();
            Drive1HealthTextBox.Text = "DRIVE 1 = OK";
            Drive2HealthTextBox.Text = "DRIVE 2 = OK";
            Drive3HealthTextBox.Text = "DRIVE 3 = OK";
            Drive5HealthTextBox.Text = "DRIVE 5 = OK";
        }

        private void EstopButtonOnClick(object sender, EventArgs e)
        {
            MessageBox.Show("Emergency stop active, click ok to emergency stop circuit.");
            //TODO: Setup estop activation
        }

        private void MenuStripFileCloseBtn(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StopStart1Action(object sender, EventArgs e)
        {

        }

        TestGraphWindow testGraphWindow = new TestGraphWindow();

        private void Drive1StopStart(object sender, EventArgs e)
        {
            
            if (Drive1StopStartBtn.Checked)
            {
                Drive1StopStartBtn.Text = ("STOP");
                Drive1StopStartBtn.BackColor = Color.Red;

                Drive1SpeedBar.Enabled = false;
                Drive1SpeedBtn.Enabled = false;
                Drive1ForRevToggle.Enabled = false;
                Drive1FullRedCurrToggle.Enabled = false;
                Drive1SpeedText.Enabled = false;
                

                //TODO: PUT START DRIVE 1 FUNCTION HERE
            }
            else
            {
                Drive1StopStartBtn.Text = ("START");
                Drive1StopStartBtn.BackColor = Color.Green;

                Drive1SpeedBtn.Enabled = true;
                Drive1SpeedBar.Enabled = true;
                Drive1ForRevToggle.Enabled = true;
                Drive1FullRedCurrToggle.Enabled = true;
                Drive1SpeedText.Enabled = true;

                //TODO: PUT STOP DRIVE 1 FUNCTION HERE
            }
        }

        private void Drive1SpeedControl(object sender, EventArgs e)
        {
            int Drive1Speed = Drive1SpeedBar.Value;
            Drive1SpeedText.Text = Convert.ToString(Drive1Speed);
            //TODO: Drive 1 speed control

        }

        private void Drive1SpeedBtnSet(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Drive1SpeedText.Text) > 2500)
            {
                Drive1SpeedText.Text = "2500";
            }
            Drive1SpeedBar.Value = Convert.ToInt32(Drive1SpeedText.Text);
        }

        private void Drive1TextValidation(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 8 || (e.KeyChar >= 48 && e.KeyChar <= 57)))
            {
                e.Handled = true;
            }
        }

        private void Drive1ForRevChange(object sender, EventArgs e)
        {
            if (Drive1ForRevToggle.Checked)
            {
                Drive1ForRevToggle.Text = ("REVERSE");

                //TODO: PUT REVERSE DRIVE 1 FUNCTION HERE
            }
            else
            {
                Drive1ForRevToggle.Text = ("FORWARD");

                //TODO: PUT FORWARD DRIVE 1 FUNCTION HERE
            }
        }

        private void Drive1FullRed(object sender, EventArgs e)
        {
            if (Drive1FullRedCurrToggle.Checked) {
                Drive1FullRedCurrToggle.Text = "REDUCED";
            }
            else
            {
                Drive1FullRedCurrToggle.Text = "FULL";
            }
        }

        private void Drive2StopStart(object sender, EventArgs e)
        {
            if (Drive2StopStartBtn.Checked)
            {

                if (Convert.ToInt32(TimeControlTextBox.Text) > 0) {
                    timer1.Start();
                    if (testGraphWindow == null || testGraphWindow.IsDisposed)
                    {
                        testGraphWindow = new TestGraphWindow();
                    }
                    testGraphWindow.Show();
                    testGraphWindow.Start();
                    Drive2StopStartBtn.Text = "STOP";
                    Drive2StopStartBtn.BackColor = Color.Red;

                    Drive2SpeedBar.Enabled = false;
                    Drive2SetSpeedBtn.Enabled = false;
                    Drive2ForRevToggle.Enabled = false;
                    Drive2FullRedToggle.Enabled = false;
                    Drive2SpeedText.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please enter a time value to start the test.");
                    Drive2StopStartBtn.Checked = false;
                }
                    

                //TODO: DRIVE 2 START METHOD

            } else {
                timer1.Stop();
                testGraphWindow.Stop();
                Drive2StopStartBtn.Text = "START";
                Drive2StopStartBtn.BackColor = Color.Green;

                Drive2SpeedBar.Enabled = true;
                Drive2SetSpeedBtn.Enabled = true;
                Drive2ForRevToggle.Enabled = true;
                Drive2FullRedToggle.Enabled = true;
                Drive2SpeedText.Enabled = true;
                //TODO: DRIVE 2 STOP METHOD
            }
        }

        private void Drive2SpeedControl(object sender, EventArgs e)
        {
            int Drive2Speed = Drive2SpeedBar.Value;
            Drive2SpeedText.Text = Convert.ToString(Drive2Speed);
        }

        private void Drive2SpeedValidation(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 8 || (e.KeyChar >= 48 && e.KeyChar <= 57)))
            {
                e.Handled = true;
            }
        }

        private void Drive2SpeedSet(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Drive2SpeedText.Text) > 2500) {
                Drive2SpeedText.Text = "2500";
            }
            Drive2SpeedBar.Value = Convert.ToInt32(Drive2SpeedText.Text);
        }

        private void Drive2ForRevChange(object sender, EventArgs e)
        {
            if (Drive2ForRevToggle.Checked) {
                Drive2ForRevToggle.Text = "REVERSE";
            }
            else
            {
                Drive2ForRevToggle.Text = "FORWARD";
            }
        }

        private void Drive2FullRed(object sender, EventArgs e)
        {
            if (Drive2FullRedToggle.Checked) {
                Drive2FullRedToggle.Text = "REDUCED";
            }
            else
            {
                Drive2FullRedToggle.Text = "FULL";
            }
        }

        private void Drive3StopStartBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Drive3StopStart(object sender, EventArgs e)
        {
            if (Drive3StopStartBtn.Checked) {
                //TODO: Drive 3 stop start method
                Drive3StopStartBtn.Text = "STOP";
                Drive3StopStartBtn.BackColor = Color.Red;

                Drive3SpeedBar.Enabled = false;
                Drive3SetSpeedBtn.Enabled = false;
                Drive3RedFullToggle.Enabled = false;
                Drive3ForRevToggle.Enabled = false;
                Drive3SpeedText.Enabled = false;
            }
            else
            {
                Drive3StopStartBtn.Text = "START";
                Drive3StopStartBtn.BackColor = Color.Green;

                Drive3SpeedBar.Enabled = true;
                Drive3SetSpeedBtn.Enabled = true;
                Drive3RedFullToggle.Enabled = true;
                Drive3ForRevToggle.Enabled = true;
                Drive3SpeedText.Enabled = true;
            }
        }

        private void Drive3SpeedSet(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Drive3SpeedText.Text) > 2500)
            {
                Drive3SpeedText.Text = "2500";
            }
            Drive3SpeedBar.Value = Convert.ToInt32(Drive3SpeedText.Text);
        }

        private void Drive3SpeedValidation(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 8 || (e.KeyChar >= 48 && e.KeyChar <= 57)))
            {
                e.Handled = true;
            }
        }

        private void Drive3SpeedControl(object sender, EventArgs e)
        {
            int Drive3Speed = Drive3SpeedBar.Value;
            Drive3SpeedText.Text = Convert.ToString(Drive3Speed);
        }

        private void Drive3ForRevChange(object sender, EventArgs e)
        {
            if (Drive3ForRevToggle.Checked)
            {
                Drive3ForRevToggle.Text = "REVERSE";
            }
            else
            {
                Drive3ForRevToggle.Text = "FORWARD";
            }
        }

        private void Drive3RedFull(object sender, EventArgs e)
        {
            if (Drive3RedFullToggle.Checked) {
                Drive3RedFullToggle.Text = "REDUCED";
            }
            else
            {
                Drive3RedFullToggle.Text = "FULL";
            }
        }

        private void Drive4SpeedControl(object sender, EventArgs e)
        {
            int Drive4Speed = Drive4SpeedBar.Value;
            Drive4SpeedText.Text = Convert.ToString(Drive4Speed);
        }

        private void Drive4SpeedValidation(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 8 || (e.KeyChar >= 48 && e.KeyChar <= 57)))
            {
                e.Handled = true;
            }
        }

        private void Drive4SpeedSet(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Drive4SpeedText.Text) > 2500)
            {
                Drive4SpeedText.Text = "2500";
            }

            Drive4SpeedBar.Value = Convert.ToInt32(Drive4SpeedText.Text);
        }

        private void Drive4RevForChange(object sender, EventArgs e)
        {
            if (Drive4RevForToggle.Checked) {
                Drive4RevForToggle.Text = "REVERSE";
            }
            else
            {
                Drive4RevForToggle.Text = "FORWARD";
            }
        }

        private void Drive4FullRed(object sender, EventArgs e)
        {
            if (Drive4FullRedToggle.Checked) {
                Drive4FullRedToggle.Text = "REDUCED";
            }
            else
            {
                Drive4FullRedToggle.Text = "FULL";
            }
        }

        private void Drive4StartStop(object sender, EventArgs e)
        {
            if (Drive4StopStartBtn.Checked)
            {
                //TODO: DRIVE 4 START FUNCTION
                Drive4StopStartBtn.Text = "STOP";
                Drive4StopStartBtn.BackColor = Color.Red;

                Drive4SpeedBar.Enabled = false;
                Drive4SetSpeedBtn.Enabled = false;
                Drive4RevForToggle.Enabled = false;
                Drive4FullRedToggle.Enabled = false;
                Drive4SpeedText.Enabled = false;
            }
            else
            {
                Drive4StopStartBtn.Text = "START";
                Drive4StopStartBtn.BackColor = Color.Green;

                Drive4SpeedBar.Enabled = true;
                Drive4SetSpeedBtn.Enabled = true;
                Drive4FullRedToggle.Enabled = true;
                Drive4RevForToggle.Enabled = true;
                Drive4SpeedText.Enabled = true;
                //TODO: DRIVE 4 STOP FUNCTION
            }
        }

        private void Drive5StopStart(object sender, EventArgs e)
        {
            if (Drive5StopStartBtn.Checked) {
                //TODO: DRIVE 5 STOP START FUNCTION
                Drive5StopStartBtn.Text = "STOP";
                Drive5StopStartBtn.BackColor = Color.Red;

                Drive5SpeedBar.Enabled = false;
                Drive5SpeedBtn.Enabled = false;
                Drive5RevForToggle.Enabled = false;
                Drive5FullRedToggle.Enabled = false;
                Drive5SpeedText.Enabled = false;
            }
            else
            {
                Drive5StopStartBtn.Text = "START";
                Drive5StopStartBtn.BackColor = Color.Green;

                Drive5SpeedBar.Enabled = true;
                Drive5SpeedBar.Enabled = true;
                Drive5RevForToggle.Enabled = true;
                Drive5FullRedToggle.Enabled = true;
                Drive5SpeedText.Enabled = true;
            }
        }

        private void Drive5SpeedValidation(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 8 || (e.KeyChar >= 48 && e.KeyChar <= 57)))
            {
                e.Handled = true;
            }
        }

        private void Drive5SpeedControl(object sender, EventArgs e)
        {
            int Drive5Speed = Drive5SpeedBar.Value;
            Drive5SpeedText.Text = Convert.ToString(Drive5Speed);
        }

        private void Drive5SpeedSet(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Drive5SpeedText.Text) > 2500)
            {
                Drive5SpeedText.Text = "2500";
            }
            Drive5SpeedBar.Value = Convert.ToInt32(Drive5SpeedText.Text);
        }

        private void Drive5RevFor(object sender, EventArgs e)
        {
            if (Drive5RevForToggle.Checked) {
                Drive5RevForToggle.Text = "REVERSE";
            }
            else
            {
                Drive5RevForToggle.Text = "FORWARD";
            }
        }

        private void Drive5FullRed(object sender, EventArgs e)
        {
            if (Drive5FullRedToggle.Checked) {
                Drive5FullRedToggle.Text = "REDUCED";
            }
            else
            {
                Drive5FullRedToggle.Text = "FULL";
            }
        }

        private void Drive6StopStart(object sender, EventArgs e)
        {
            if (Drive6StopStartBtn.Checked)
            {
                //TODO: Drive 6 stop start function and other methods
                Drive6StopStartBtn.Text = "STOP";
                Drive6StopStartBtn.BackColor = Color.Red;

                Drive6SpeedBar.Enabled = false;
                Drive6SetSpeedBtn.Enabled = false;
                Drive6RedFullToggle.Enabled = false;
                Drive6RevForToggle.Enabled = false;
                Drive6SpeedText.Enabled = false;
            }
            else
            {
                Drive6StopStartBtn.Text = "START";
                Drive6StopStartBtn.BackColor = Color.Green;

                Drive6SpeedBar.Enabled = true;
                Drive6SetSpeedBtn.Enabled = true;
                Drive6RedFullToggle.Enabled = true;
                Drive6RevForToggle.Enabled = true;
                Drive6SpeedText.Enabled = true;
            }
        }

        private void Drive6SpeedValidation(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 8 || (e.KeyChar >= 48 && e.KeyChar <= 57)))
            {
                e.Handled = true;
            }
        }

        private void Drive6SetSpeed(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Drive6SpeedText.Text) > 2500)
            {
                Drive6SpeedText.Text = "2500";
            }
            Drive6SpeedBar.Value = Convert.ToInt32(Drive6SpeedText.Text);
        }

        private void Drive6SpeedControl(object sender, EventArgs e)
        {
            int Drive6Speed = Drive6SpeedBar.Value;
            Drive6SpeedText.Text = Convert.ToString(Drive6Speed);
        }

        private void Drive6ForRev(object sender, EventArgs e)
        {
            if (Drive6RevForToggle.Checked)
            {
                Drive6RevForToggle.Text = "REVERSE";
            }
            else
            {
                Drive6RevForToggle.Text = "FORWARD";
            }
        }

        private void Drive6RedFull(object sender, EventArgs e)
        {
            if (Drive6RedFullToggle.Checked) {
                Drive6RedFullToggle.Text = "REDUCED";
            }
            else
            {
                Drive6RedFullToggle.Text = "FULL";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void HelpMenuItemOnClick(object sender, EventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
        }

        private void TimeControlTextBoxValidation(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 8 || (e.KeyChar >= 48 && e.KeyChar <= 57)))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int EnteredTime = Convert.ToInt32(TimeControlTextBox.Text);

            if (EnteredTime > 0)
            {
                EnteredTime = EnteredTime - 1;
                TimeControlTextBox.Text = Convert.ToString(EnteredTime);
            }
            else
            {
                timer1.Stop();
                Drive2StopStartBtn.Checked = false;
                MessageBox.Show("Test finished. All drives now powered down.");
            }
        }
    }
}