using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BaumullerTestPanelApplication
{
    public partial class MainForm : Form
    {
        //VARIABLES
        List<int> DriveSpeedList = new List<int> { 2500, 2500, 2500, 2500, 2500, 2500 };

        //Graph window
        TestGraphWindow testGraphWindow = new TestGraphWindow();

        //Help Menu
        HelpWindow helpWindow = new HelpWindow();


        //TODO: add drive health check
        
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
            MessageBox.Show("Emergency stop active, click ok to reset emergency stop circuit.");
            //TODO: Setup estop activation
        }

        private void MenuStripFileCloseBtn(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int GetDriveNumberFromControl(Control control)
        {
            string DriveTag = (string)control.Tag;
            return Convert.ToInt32(DriveTag.Substring(DriveTag.Length - 1));
        }
        private void DriveSetSpeed(object sender, EventArgs e)
        {
            Button senderObject = (Button)sender;
            string DriveTag = (string)senderObject.Tag;

            int DriveSpeedLimit = DriveSpeedList[GetDriveNumberFromControl(senderObject) - 1];
            int DriveSpeed = 0;

            foreach (Control c in this.Controls)
            {
                if ((string)c.Tag == DriveTag)
                {
                    if (c.GetType() == typeof(TextBox)) {
                        DriveSpeed = Convert.ToInt32(((TextBox)c).Text);
                        if(DriveSpeed > DriveSpeedLimit)
                        {
                            DriveSpeed = DriveSpeedLimit;
                            ((TextBox)c).Text = Convert.ToString(DriveSpeed);
                        }
                    }
                    
                }
            }
            foreach (Control c in this.Controls)
            {
                if ((string)c.Tag == DriveTag)
                {
                    if (c.GetType() == typeof(TrackBar))
                    {
                        ((TrackBar)c).Value = DriveSpeed;
                    }
                }
            }
        } 
        private void DriveSpeedControl(object sender, EventArgs e)
        {
            TrackBar senderObject = (TrackBar)sender;
            string DriveTag = (string)senderObject.Tag;
            int DriveSpeed = senderObject.Value;
            foreach (Control c in this.Controls)
            {
                if ((string)c.Tag == DriveTag)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        ((TextBox)c).Text = Convert.ToString(DriveSpeed);
                    }
                }

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void HelpMenuItemOnClick(object sender, EventArgs e)
        {
            helpWindow.Show();
        }

        private void NumericalTextBoxInputValidation(object sender, KeyPressEventArgs e)
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
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(CheckBox))
                    {
                        if (((CheckBox)c).Checked)
                        {
                            ((CheckBox)c).Checked = false;
                            MessageBox.Show("Test finished.");
                        }
                    }
                    
                }
            }
        }

        private void StopStartMethod(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string DriveTag = (string)checkBox.Tag;
            
            
                foreach (Control c in this.Controls)
                {
                    if ((string)c.Tag == DriveTag & !(c == checkBox))
                    {
                        c.Enabled = !checkBox.Checked;
                    }
                }
            if (checkBox.Checked)
            {
                if (Convert.ToInt32(TimeControlTextBox.Text) > 0)
                {
                    checkBox.Text = "STOP";
                    checkBox.BackColor = Color.Red;
                    timer1.Start();
                    TimeControlTextBox.Enabled = false;
                    if (testGraphWindow == null || testGraphWindow.IsDisposed)
                    {
                        testGraphWindow = new TestGraphWindow();
                    }
                    testGraphWindow.Show();
                    testGraphWindow.Start();
                }
                else
                {
                    MessageBox.Show("Please enter a time value to start the test.");
                    checkBox.Checked = false;
                }
            }
            else
            {
                checkBox.Text = "START";
                checkBox.BackColor = Color.Green;
                timer1.Stop();
                testGraphWindow.Stop();
                TimeControlTextBox.Enabled = true;

            }
        }

        private void FullReducedToggleMethod(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                checkBox.Text = "REDUCED";
            }
            else
            {
                checkBox.Text = "FULL";
            }
        }

        private void ForwardReverseToggleMethod(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                checkBox.Text = "REVERSE";
            }
            else
            {
                checkBox.Text = "FORWARD";
            }
        }

    }
}