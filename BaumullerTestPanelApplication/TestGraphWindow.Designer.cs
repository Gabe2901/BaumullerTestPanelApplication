using System.Drawing;
using System.Windows.Forms;

namespace BaumullerTestPanelApplication
{
    partial class TestGraphWindow
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestGraphWindow));
            this.formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            this.btnWipeRight = new System.Windows.Forms.Button();
            this.btnScrollLeft = new System.Windows.Forms.Button();
            this.rbManage = new System.Windows.Forms.RadioButton();
            this.rbContinuous = new System.Windows.Forms.RadioButton();
            this.btnMark = new System.Windows.Forms.Button();
            this.formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot1.DisplayScale = 1F;
            this.formsPlot1.Location = new System.Drawing.Point(10, 40);
            this.formsPlot1.MaximumSize = new System.Drawing.Size(940, 840);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(940, 840);
            this.formsPlot1.TabIndex = 0;
            // 
            // btnWipeRight
            // 
            this.btnWipeRight.Location = new System.Drawing.Point(10, 10);
            this.btnWipeRight.Name = "btnWipeRight";
            this.btnWipeRight.Size = new System.Drawing.Size(75, 29);
            this.btnWipeRight.TabIndex = 2;
            this.btnWipeRight.Text = "Wipe";
            this.btnWipeRight.UseVisualStyleBackColor = true;
            // 
            // btnScrollLeft
            // 
            this.btnScrollLeft.Location = new System.Drawing.Point(91, 10);
            this.btnScrollLeft.Name = "btnScrollLeft";
            this.btnScrollLeft.Size = new System.Drawing.Size(75, 29);
            this.btnScrollLeft.TabIndex = 5;
            this.btnScrollLeft.Text = "Scroll";
            this.btnScrollLeft.UseVisualStyleBackColor = true;
            // 
            // rbManage
            // 
            this.rbManage.AutoSize = true;
            this.rbManage.Checked = true;
            this.rbManage.Location = new System.Drawing.Point(189, 17);
            this.rbManage.Name = "rbManage";
            this.rbManage.Size = new System.Drawing.Size(177, 17);
            this.rbManage.TabIndex = 7;
            this.rbManage.TabStop = true;
            this.rbManage.Text = "DataStreamer.ManageAxisLimits";
            this.rbManage.UseVisualStyleBackColor = true;
            // 
            // rbContinuous
            // 
            this.rbContinuous.AutoSize = true;
            this.rbContinuous.Location = new System.Drawing.Point(386, 17);
            this.rbContinuous.Name = "rbContinuous";
            this.rbContinuous.Size = new System.Drawing.Size(154, 17);
            this.rbContinuous.TabIndex = 8;
            this.rbContinuous.Text = "Axis.ContinuouslyAutoscale";
            this.rbContinuous.UseVisualStyleBackColor = true;
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(590, 10);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(75, 29);
            this.btnMark.TabIndex = 9;
            this.btnMark.Text = "Mark Position";
            this.btnMark.UseVisualStyleBackColor = true;
            // 
            // formsPlot2
            // 
            this.formsPlot2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot2.DisplayScale = 1F;
            this.formsPlot2.Location = new System.Drawing.Point(968, 40);
            this.formsPlot2.MaximumSize = new System.Drawing.Size(940, 840);
            this.formsPlot2.Name = "formsPlot2";
            this.formsPlot2.Size = new System.Drawing.Size(940, 840);
            this.formsPlot2.TabIndex = 0;
            // 
            // TestGraphWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.formsPlot2);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.rbContinuous);
            this.Controls.Add(this.rbManage);
            this.Controls.Add(this.btnScrollLeft);
            this.Controls.Add(this.btnWipeRight);
            this.Controls.Add(this.formsPlot1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestGraphWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataStreamer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TestGraphWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Button btnWipeRight;
        private Button btnScrollLeft;
        private RadioButton rbManage;
        private RadioButton rbContinuous;
        private Button btnMark;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
    }
}