namespace BaumullerTestPanelApplication
{
    partial class HelpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.HelpWindowListBox = new System.Windows.Forms.ListBox();
            this.HelpMenuTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.HelpWindowListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.HelpMenuTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // HelpWindowListBox
            // 
            this.HelpWindowListBox.CausesValidation = false;
            this.HelpWindowListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpWindowListBox.FormattingEnabled = true;
            this.HelpWindowListBox.ItemHeight = 16;
            this.HelpWindowListBox.Items.AddRange(new object[] {
            "ESTOP",
            "FORWARD/REVERSE",
            "FULL/REDUCED"});
            this.HelpWindowListBox.Location = new System.Drawing.Point(12, 13);
            this.HelpWindowListBox.MaximumSize = new System.Drawing.Size(251, 420);
            this.HelpWindowListBox.MinimumSize = new System.Drawing.Size(251, 420);
            this.HelpWindowListBox.Name = "HelpWindowListBox";
            this.HelpWindowListBox.ScrollAlwaysVisible = true;
            this.HelpWindowListBox.Size = new System.Drawing.Size(251, 420);
            this.HelpWindowListBox.Sorted = true;
            this.HelpWindowListBox.TabIndex = 0;
            // 
            // HelpMenuTextBox
            // 
            this.HelpMenuTextBox.Location = new System.Drawing.Point(3, 12);
            this.HelpMenuTextBox.Name = "HelpMenuTextBox";
            this.HelpMenuTextBox.ReadOnly = true;
            this.HelpMenuTextBox.Size = new System.Drawing.Size(515, 420);
            this.HelpMenuTextBox.TabIndex = 0;
            this.HelpMenuTextBox.Text = "";
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelpWindow";
            this.Text = "HelpWindow";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox HelpWindowListBox;
        private System.Windows.Forms.RichTextBox HelpMenuTextBox;
    }
}