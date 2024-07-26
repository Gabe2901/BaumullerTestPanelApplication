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
        public MainForm()
        {
            InitializeComponent();
        }

        private void Estop_Clicked(object sender, EventArgs e)
        {
            MessageBox.Show("Emergency stop active, click ok to emergency stop circuit.");
            //TODO: Setup estop activation
        }

        private void hlepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StopStart1Action(object sender, EventArgs e)
        {

        }

        private void StopStart1Btn_CheckedChanged(object sender, EventArgs e)
        {
            if (StopStart1Btn.Checked)
            {
                StopStart1Btn.Text = ("STOP");

                //TODO: PUT START DRIVE 1 FUNCTION HERE
            }
            else
            {
                StopStart1Btn.Text = ("START");

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
                Drive2StopStartBtn.Text = "STOP";
                //TODO: DRIVE 2 START METHOD
            } else {
                Drive2StopStartBtn.Text = "START";
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
            }
            else
            {
                Drive3StopStartBtn.Text = "START";
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
            Drive4SpeedText.Text = Convert.ToString(Drive4SpeedBar.Value);
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
                //TODO: DRIVE 4 STOP START FUNCTION
                Drive4StopStartBtn.Text = "STOP";
            }
            else
            {
                Drive4StopStartBtn.Text = "START";
            }
        }

        private void Drive5StopStart(object sender, EventArgs e)
        {
            if (Drive5StopStartBtn.Checked) {
                //TODO: DRIVE 5 STOP START FUNCTION
                Drive5StopStartBtn.Text = "STOP";
            }
            else
            {
                Drive5StopStartBtn.Text = "START";
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
            }
            else
            {
                Drive6StopStartBtn.Text = "START";
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
    }
}