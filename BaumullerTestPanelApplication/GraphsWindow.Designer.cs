using System.Drawing;
using System.Windows.Forms;

namespace BaumullerTestPanelApplication
{
    partial class GraphsWindow
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
            this.formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            this.btnFull = new System.Windows.Forms.Button();
            this.btnJump = new System.Windows.Forms.Button();
            this.rbManage = new System.Windows.Forms.RadioButton();
            this.rbContinuous = new System.Windows.Forms.RadioButton();
            this.btnMark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.formsPlot1.DisplayScale = 1F;
            this.formsPlot1.Location = new System.Drawing.Point(10, 45);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(665, 335);
            this.formsPlot1.TabIndex = 0;
            // 
            // btnFull
            // 
            this.btnFull.Location = new System.Drawing.Point(10, 10);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(75, 29);
            this.btnFull.TabIndex = 2;
            this.btnFull.Text = "Full";
            this.btnFull.UseVisualStyleBackColor = true;
            // 
            // btnJump
            // 
            this.btnJump.Location = new System.Drawing.Point(91, 10);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(75, 29);
            this.btnJump.TabIndex = 5;
            this.btnJump.Text = "Jump";
            this.btnJump.UseVisualStyleBackColor = true;
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
            // GraphsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.rbContinuous);
            this.Controls.Add(this.rbManage);
            this.Controls.Add(this.btnJump);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.formsPlot1);
            this.Name = "GraphsWindow";
            this.Text = "DataStreamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Button btnFull;
        private Button btnJump;
        private RadioButton rbManage;
        private RadioButton rbContinuous;
        private Button btnMark;
    }
}