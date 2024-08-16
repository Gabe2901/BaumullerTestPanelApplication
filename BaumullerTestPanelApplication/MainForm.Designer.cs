using ScottPlot.WinForms;
using ScottPlot;

namespace BaumullerTestPanelApplication



{
    partial class MainForm
    {
        private const string Drive1Speed = "0";

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hlepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Drive1StopStartBtn = new System.Windows.Forms.CheckBox();
            this.Drive1Label = new System.Windows.Forms.Label();
            this.Drive1SpeedBar = new System.Windows.Forms.TrackBar();
            this.Drive1SpeedText = new System.Windows.Forms.TextBox();
            this.Drive1SpeedBtn = new System.Windows.Forms.Button();
            this.Drive1ForRevToggle = new System.Windows.Forms.CheckBox();
            this.Drive1FullRedCurrToggle = new System.Windows.Forms.CheckBox();
            this.Drive2Label = new System.Windows.Forms.Label();
            this.Drive2StopStartBtn = new System.Windows.Forms.CheckBox();
            this.Drive2SpeedBar = new System.Windows.Forms.TrackBar();
            this.Drive2SpeedText = new System.Windows.Forms.TextBox();
            this.Drive2SetSpeedBtn = new System.Windows.Forms.Button();
            this.Drive2ForRevToggle = new System.Windows.Forms.CheckBox();
            this.Drive2FullRedToggle = new System.Windows.Forms.CheckBox();
            this.Drive3Label = new System.Windows.Forms.Label();
            this.Drive3StopStartBtn = new System.Windows.Forms.CheckBox();
            this.Drive3SpeedBar = new System.Windows.Forms.TrackBar();
            this.Drive3SpeedText = new System.Windows.Forms.TextBox();
            this.Drive3SetSpeedBtn = new System.Windows.Forms.Button();
            this.Drive3ForRevToggle = new System.Windows.Forms.CheckBox();
            this.Drive3RedFullToggle = new System.Windows.Forms.CheckBox();
            this.Drive4Label = new System.Windows.Forms.Label();
            this.Drive4StopStartBtn = new System.Windows.Forms.CheckBox();
            this.Drive4SpeedBar = new System.Windows.Forms.TrackBar();
            this.Drive4SpeedText = new System.Windows.Forms.TextBox();
            this.Drive4SetSpeedBtn = new System.Windows.Forms.Button();
            this.Drive4RevForToggle = new System.Windows.Forms.CheckBox();
            this.Drive4FullRedToggle = new System.Windows.Forms.CheckBox();
            this.Drive5Label = new System.Windows.Forms.Label();
            this.Drive5StopStartBtn = new System.Windows.Forms.CheckBox();
            this.Drive5SpeedBar = new System.Windows.Forms.TrackBar();
            this.Drive5SpeedText = new System.Windows.Forms.TextBox();
            this.Drive5SpeedBtn = new System.Windows.Forms.Button();
            this.Drive5RevForToggle = new System.Windows.Forms.CheckBox();
            this.Drive5FullRedToggle = new System.Windows.Forms.CheckBox();
            this.Drive6Label = new System.Windows.Forms.Label();
            this.Drive6StopStartBtn = new System.Windows.Forms.CheckBox();
            this.Drive6SpeedBar = new System.Windows.Forms.TrackBar();
            this.Drive6SpeedText = new System.Windows.Forms.TextBox();
            this.Drive6SetSpeedBtn = new System.Windows.Forms.Button();
            this.Drive6RevForToggle = new System.Windows.Forms.CheckBox();
            this.Drive6RedFullToggle = new System.Windows.Forms.CheckBox();
            this.Drive3HealthTextBox = new System.Windows.Forms.TextBox();
            this.Drive1HealthTextBox = new System.Windows.Forms.TextBox();
            this.Drive2HealthTextBox = new System.Windows.Forms.TextBox();
            this.Drive5HealthTextBox = new System.Windows.Forms.TextBox();
            this.TimeControlTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerTextBoxLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drive1SpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drive2SpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drive3SpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drive4SpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drive5SpeedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drive6SpeedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1642, 849);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "ESTOP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.EstopButtonOnClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.MenuStripFileCloseBtn);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hlepToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // hlepToolStripMenuItem
            // 
            this.hlepToolStripMenuItem.Name = "hlepToolStripMenuItem";
            this.hlepToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.hlepToolStripMenuItem.Text = "Help";
            this.hlepToolStripMenuItem.Click += new System.EventHandler(this.HelpMenuItemOnClick);
            // 
            // Drive1StopStartBtn
            // 
            this.Drive1StopStartBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Drive1StopStartBtn.AutoSize = true;
            this.Drive1StopStartBtn.BackColor = System.Drawing.Color.Green;
            this.Drive1StopStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive1StopStartBtn.Location = new System.Drawing.Point(52, 81);
            this.Drive1StopStartBtn.Name = "Drive1StopStartBtn";
            this.Drive1StopStartBtn.Size = new System.Drawing.Size(91, 35);
            this.Drive1StopStartBtn.TabIndex = 2;
            this.Drive1StopStartBtn.Tag = "Drive1";
            this.Drive1StopStartBtn.Text = "START";
            this.Drive1StopStartBtn.UseVisualStyleBackColor = false;
            this.Drive1StopStartBtn.CheckedChanged += new System.EventHandler(this.StopStartMethod);
            // 
            // Drive1Label
            // 
            this.Drive1Label.AutoSize = true;
            this.Drive1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive1Label.Location = new System.Drawing.Point(42, 41);
            this.Drive1Label.Name = "Drive1Label";
            this.Drive1Label.Size = new System.Drawing.Size(115, 37);
            this.Drive1Label.TabIndex = 3;
            this.Drive1Label.Text = "Drive 1";
            // 
            // Drive1SpeedBar
            // 
            this.Drive1SpeedBar.Location = new System.Drawing.Point(46, 122);
            this.Drive1SpeedBar.Maximum = 2500;
            this.Drive1SpeedBar.Name = "Drive1SpeedBar";
            this.Drive1SpeedBar.Size = new System.Drawing.Size(104, 45);
            this.Drive1SpeedBar.TabIndex = 4;
            this.Drive1SpeedBar.Tag = "Drive1";
            this.Drive1SpeedBar.ValueChanged += new System.EventHandler(this.DriveSpeedControl);
            // 
            // Drive1SpeedText
            // 
            this.Drive1SpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive1SpeedText.Location = new System.Drawing.Point(46, 161);
            this.Drive1SpeedText.MaxLength = 4;
            this.Drive1SpeedText.Name = "Drive1SpeedText";
            this.Drive1SpeedText.Size = new System.Drawing.Size(100, 31);
            this.Drive1SpeedText.TabIndex = 5;
            this.Drive1SpeedText.Tag = "Drive1";
            this.Drive1SpeedText.Text = "0";
            this.Drive1SpeedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericalTextBoxInputValidation);
            // 
            // Drive1SpeedBtn
            // 
            this.Drive1SpeedBtn.AutoSize = true;
            this.Drive1SpeedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive1SpeedBtn.Location = new System.Drawing.Point(32, 198);
            this.Drive1SpeedBtn.Name = "Drive1SpeedBtn";
            this.Drive1SpeedBtn.Size = new System.Drawing.Size(140, 35);
            this.Drive1SpeedBtn.TabIndex = 6;
            this.Drive1SpeedBtn.Tag = "Drive1";
            this.Drive1SpeedBtn.Text = "SET SPEED";
            this.Drive1SpeedBtn.UseVisualStyleBackColor = true;
            this.Drive1SpeedBtn.Click += new System.EventHandler(this.DriveSetSpeed);
            // 
            // Drive1ForRevToggle
            // 
            this.Drive1ForRevToggle.AutoSize = true;
            this.Drive1ForRevToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive1ForRevToggle.Location = new System.Drawing.Point(35, 239);
            this.Drive1ForRevToggle.Name = "Drive1ForRevToggle";
            this.Drive1ForRevToggle.Size = new System.Drawing.Size(139, 29);
            this.Drive1ForRevToggle.TabIndex = 8;
            this.Drive1ForRevToggle.Tag = "Drive1";
            this.Drive1ForRevToggle.Text = "FORWARD";
            this.Drive1ForRevToggle.UseVisualStyleBackColor = true;
            this.Drive1ForRevToggle.CheckedChanged += new System.EventHandler(this.ForwardReverseToggleMethod);
            // 
            // Drive1FullRedCurrToggle
            // 
            this.Drive1FullRedCurrToggle.AutoSize = true;
            this.Drive1FullRedCurrToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive1FullRedCurrToggle.Location = new System.Drawing.Point(35, 274);
            this.Drive1FullRedCurrToggle.Name = "Drive1FullRedCurrToggle";
            this.Drive1FullRedCurrToggle.Size = new System.Drawing.Size(83, 29);
            this.Drive1FullRedCurrToggle.TabIndex = 9;
            this.Drive1FullRedCurrToggle.Tag = "Drive1";
            this.Drive1FullRedCurrToggle.Text = "FULL";
            this.Drive1FullRedCurrToggle.UseVisualStyleBackColor = true;
            this.Drive1FullRedCurrToggle.CheckedChanged += new System.EventHandler(this.FullReducedToggleMethod);
            // 
            // Drive2Label
            // 
            this.Drive2Label.AutoSize = true;
            this.Drive2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive2Label.Location = new System.Drawing.Point(42, 300);
            this.Drive2Label.Name = "Drive2Label";
            this.Drive2Label.Size = new System.Drawing.Size(117, 37);
            this.Drive2Label.TabIndex = 10;
            this.Drive2Label.Text = "Drive 2";
            // 
            // Drive2StopStartBtn
            // 
            this.Drive2StopStartBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Drive2StopStartBtn.AutoSize = true;
            this.Drive2StopStartBtn.BackColor = System.Drawing.Color.Green;
            this.Drive2StopStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive2StopStartBtn.Location = new System.Drawing.Point(52, 340);
            this.Drive2StopStartBtn.Name = "Drive2StopStartBtn";
            this.Drive2StopStartBtn.Size = new System.Drawing.Size(91, 35);
            this.Drive2StopStartBtn.TabIndex = 11;
            this.Drive2StopStartBtn.Tag = "Drive2";
            this.Drive2StopStartBtn.Text = "START";
            this.Drive2StopStartBtn.UseVisualStyleBackColor = false;
            this.Drive2StopStartBtn.CheckedChanged += new System.EventHandler(this.StopStartMethod);
            // 
            // Drive2SpeedBar
            // 
            this.Drive2SpeedBar.Location = new System.Drawing.Point(46, 381);
            this.Drive2SpeedBar.Maximum = 2500;
            this.Drive2SpeedBar.Name = "Drive2SpeedBar";
            this.Drive2SpeedBar.Size = new System.Drawing.Size(104, 45);
            this.Drive2SpeedBar.TabIndex = 12;
            this.Drive2SpeedBar.Tag = "Drive2";
            this.Drive2SpeedBar.ValueChanged += new System.EventHandler(this.DriveSpeedControl);
            // 
            // Drive2SpeedText
            // 
            this.Drive2SpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive2SpeedText.Location = new System.Drawing.Point(52, 432);
            this.Drive2SpeedText.MaxLength = 5;
            this.Drive2SpeedText.Name = "Drive2SpeedText";
            this.Drive2SpeedText.Size = new System.Drawing.Size(100, 31);
            this.Drive2SpeedText.TabIndex = 13;
            this.Drive2SpeedText.Tag = "Drive2";
            this.Drive2SpeedText.Text = "0";
            this.Drive2SpeedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericalTextBoxInputValidation);
            // 
            // Drive2SetSpeedBtn
            // 
            this.Drive2SetSpeedBtn.AutoSize = true;
            this.Drive2SetSpeedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive2SetSpeedBtn.Location = new System.Drawing.Point(32, 469);
            this.Drive2SetSpeedBtn.Name = "Drive2SetSpeedBtn";
            this.Drive2SetSpeedBtn.Size = new System.Drawing.Size(140, 35);
            this.Drive2SetSpeedBtn.TabIndex = 14;
            this.Drive2SetSpeedBtn.Tag = "Drive2";
            this.Drive2SetSpeedBtn.Text = "SET SPEED";
            this.Drive2SetSpeedBtn.UseVisualStyleBackColor = true;
            this.Drive2SetSpeedBtn.Click += new System.EventHandler(this.DriveSetSpeed);
            // 
            // Drive2ForRevToggle
            // 
            this.Drive2ForRevToggle.AutoSize = true;
            this.Drive2ForRevToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive2ForRevToggle.Location = new System.Drawing.Point(46, 510);
            this.Drive2ForRevToggle.Name = "Drive2ForRevToggle";
            this.Drive2ForRevToggle.Size = new System.Drawing.Size(139, 29);
            this.Drive2ForRevToggle.TabIndex = 15;
            this.Drive2ForRevToggle.Tag = "Drive2";
            this.Drive2ForRevToggle.Text = "FORWARD";
            this.Drive2ForRevToggle.UseVisualStyleBackColor = true;
            this.Drive2ForRevToggle.CheckedChanged += new System.EventHandler(this.ForwardReverseToggleMethod);
            // 
            // Drive2FullRedToggle
            // 
            this.Drive2FullRedToggle.AutoSize = true;
            this.Drive2FullRedToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive2FullRedToggle.Location = new System.Drawing.Point(46, 545);
            this.Drive2FullRedToggle.Name = "Drive2FullRedToggle";
            this.Drive2FullRedToggle.Size = new System.Drawing.Size(83, 29);
            this.Drive2FullRedToggle.TabIndex = 16;
            this.Drive2FullRedToggle.Tag = "Drive2";
            this.Drive2FullRedToggle.Text = "FULL";
            this.Drive2FullRedToggle.UseVisualStyleBackColor = true;
            this.Drive2FullRedToggle.CheckedChanged += new System.EventHandler(this.FullReducedToggleMethod);
            // 
            // Drive3Label
            // 
            this.Drive3Label.AutoSize = true;
            this.Drive3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive3Label.Location = new System.Drawing.Point(42, 581);
            this.Drive3Label.Name = "Drive3Label";
            this.Drive3Label.Size = new System.Drawing.Size(117, 37);
            this.Drive3Label.TabIndex = 17;
            this.Drive3Label.Text = "Drive 3";
            // 
            // Drive3StopStartBtn
            // 
            this.Drive3StopStartBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Drive3StopStartBtn.AutoSize = true;
            this.Drive3StopStartBtn.BackColor = System.Drawing.Color.Green;
            this.Drive3StopStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive3StopStartBtn.Location = new System.Drawing.Point(52, 621);
            this.Drive3StopStartBtn.Name = "Drive3StopStartBtn";
            this.Drive3StopStartBtn.Size = new System.Drawing.Size(91, 35);
            this.Drive3StopStartBtn.TabIndex = 18;
            this.Drive3StopStartBtn.Tag = "Drive3";
            this.Drive3StopStartBtn.Text = "START";
            this.Drive3StopStartBtn.UseVisualStyleBackColor = false;
            this.Drive3StopStartBtn.CheckedChanged += new System.EventHandler(this.StopStartMethod);
            // 
            // Drive3SpeedBar
            // 
            this.Drive3SpeedBar.Location = new System.Drawing.Point(46, 662);
            this.Drive3SpeedBar.Maximum = 2500;
            this.Drive3SpeedBar.Name = "Drive3SpeedBar";
            this.Drive3SpeedBar.Size = new System.Drawing.Size(104, 45);
            this.Drive3SpeedBar.TabIndex = 19;
            this.Drive3SpeedBar.Tag = "Drive3";
            this.Drive3SpeedBar.ValueChanged += new System.EventHandler(this.DriveSpeedControl);
            // 
            // Drive3SpeedText
            // 
            this.Drive3SpeedText.AcceptsReturn = true;
            this.Drive3SpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive3SpeedText.Location = new System.Drawing.Point(46, 703);
            this.Drive3SpeedText.MaxLength = 4;
            this.Drive3SpeedText.Name = "Drive3SpeedText";
            this.Drive3SpeedText.Size = new System.Drawing.Size(100, 31);
            this.Drive3SpeedText.TabIndex = 20;
            this.Drive3SpeedText.Tag = "Drive3";
            this.Drive3SpeedText.Text = "0";
            this.Drive3SpeedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericalTextBoxInputValidation);
            // 
            // Drive3SetSpeedBtn
            // 
            this.Drive3SetSpeedBtn.AutoSize = true;
            this.Drive3SetSpeedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive3SetSpeedBtn.Location = new System.Drawing.Point(32, 740);
            this.Drive3SetSpeedBtn.Name = "Drive3SetSpeedBtn";
            this.Drive3SetSpeedBtn.Size = new System.Drawing.Size(140, 35);
            this.Drive3SetSpeedBtn.TabIndex = 21;
            this.Drive3SetSpeedBtn.Tag = "Drive3";
            this.Drive3SetSpeedBtn.Text = "SET SPEED";
            this.Drive3SetSpeedBtn.UseVisualStyleBackColor = true;
            this.Drive3SetSpeedBtn.Click += new System.EventHandler(this.DriveSetSpeed);
            // 
            // Drive3ForRevToggle
            // 
            this.Drive3ForRevToggle.AutoSize = true;
            this.Drive3ForRevToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive3ForRevToggle.Location = new System.Drawing.Point(35, 781);
            this.Drive3ForRevToggle.Name = "Drive3ForRevToggle";
            this.Drive3ForRevToggle.Size = new System.Drawing.Size(139, 29);
            this.Drive3ForRevToggle.TabIndex = 22;
            this.Drive3ForRevToggle.Tag = "Drive3";
            this.Drive3ForRevToggle.Text = "FORWARD";
            this.Drive3ForRevToggle.UseVisualStyleBackColor = true;
            this.Drive3ForRevToggle.CheckedChanged += new System.EventHandler(this.ForwardReverseToggleMethod);
            // 
            // Drive3RedFullToggle
            // 
            this.Drive3RedFullToggle.AutoSize = true;
            this.Drive3RedFullToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive3RedFullToggle.Location = new System.Drawing.Point(35, 816);
            this.Drive3RedFullToggle.Name = "Drive3RedFullToggle";
            this.Drive3RedFullToggle.Size = new System.Drawing.Size(83, 29);
            this.Drive3RedFullToggle.TabIndex = 23;
            this.Drive3RedFullToggle.Tag = "Drive3";
            this.Drive3RedFullToggle.Text = "FULL";
            this.Drive3RedFullToggle.UseVisualStyleBackColor = true;
            this.Drive3RedFullToggle.CheckedChanged += new System.EventHandler(this.FullReducedToggleMethod);
            // 
            // Drive4Label
            // 
            this.Drive4Label.AutoSize = true;
            this.Drive4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive4Label.Location = new System.Drawing.Point(215, 41);
            this.Drive4Label.Name = "Drive4Label";
            this.Drive4Label.Size = new System.Drawing.Size(117, 37);
            this.Drive4Label.TabIndex = 24;
            this.Drive4Label.Text = "Drive 4";
            // 
            // Drive4StopStartBtn
            // 
            this.Drive4StopStartBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Drive4StopStartBtn.AutoSize = true;
            this.Drive4StopStartBtn.BackColor = System.Drawing.Color.Green;
            this.Drive4StopStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive4StopStartBtn.Location = new System.Drawing.Point(222, 81);
            this.Drive4StopStartBtn.Name = "Drive4StopStartBtn";
            this.Drive4StopStartBtn.Size = new System.Drawing.Size(91, 35);
            this.Drive4StopStartBtn.TabIndex = 25;
            this.Drive4StopStartBtn.Tag = "Drive4";
            this.Drive4StopStartBtn.Text = "START";
            this.Drive4StopStartBtn.UseVisualStyleBackColor = false;
            this.Drive4StopStartBtn.CheckedChanged += new System.EventHandler(this.StopStartMethod);
            // 
            // Drive4SpeedBar
            // 
            this.Drive4SpeedBar.Location = new System.Drawing.Point(216, 122);
            this.Drive4SpeedBar.Maximum = 2500;
            this.Drive4SpeedBar.Name = "Drive4SpeedBar";
            this.Drive4SpeedBar.Size = new System.Drawing.Size(104, 45);
            this.Drive4SpeedBar.TabIndex = 26;
            this.Drive4SpeedBar.Tag = "Drive4";
            this.Drive4SpeedBar.ValueChanged += new System.EventHandler(this.DriveSpeedControl);
            // 
            // Drive4SpeedText
            // 
            this.Drive4SpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive4SpeedText.Location = new System.Drawing.Point(220, 161);
            this.Drive4SpeedText.MaxLength = 4;
            this.Drive4SpeedText.Name = "Drive4SpeedText";
            this.Drive4SpeedText.Size = new System.Drawing.Size(100, 31);
            this.Drive4SpeedText.TabIndex = 27;
            this.Drive4SpeedText.Tag = "Drive4";
            this.Drive4SpeedText.Text = "0";
            this.Drive4SpeedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericalTextBoxInputValidation);
            // 
            // Drive4SetSpeedBtn
            // 
            this.Drive4SetSpeedBtn.AutoSize = true;
            this.Drive4SetSpeedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive4SetSpeedBtn.Location = new System.Drawing.Point(202, 198);
            this.Drive4SetSpeedBtn.Name = "Drive4SetSpeedBtn";
            this.Drive4SetSpeedBtn.Size = new System.Drawing.Size(140, 35);
            this.Drive4SetSpeedBtn.TabIndex = 28;
            this.Drive4SetSpeedBtn.Tag = "Drive4";
            this.Drive4SetSpeedBtn.Text = "SET SPEED";
            this.Drive4SetSpeedBtn.UseVisualStyleBackColor = true;
            this.Drive4SetSpeedBtn.Click += new System.EventHandler(this.DriveSetSpeed);
            // 
            // Drive4RevForToggle
            // 
            this.Drive4RevForToggle.AutoSize = true;
            this.Drive4RevForToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive4RevForToggle.Location = new System.Drawing.Point(202, 239);
            this.Drive4RevForToggle.Name = "Drive4RevForToggle";
            this.Drive4RevForToggle.Size = new System.Drawing.Size(139, 29);
            this.Drive4RevForToggle.TabIndex = 29;
            this.Drive4RevForToggle.Tag = "Drive4";
            this.Drive4RevForToggle.Text = "FORWARD";
            this.Drive4RevForToggle.UseVisualStyleBackColor = true;
            this.Drive4RevForToggle.CheckedChanged += new System.EventHandler(this.ForwardReverseToggleMethod);
            // 
            // Drive4FullRedToggle
            // 
            this.Drive4FullRedToggle.AutoSize = true;
            this.Drive4FullRedToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive4FullRedToggle.Location = new System.Drawing.Point(202, 274);
            this.Drive4FullRedToggle.Name = "Drive4FullRedToggle";
            this.Drive4FullRedToggle.Size = new System.Drawing.Size(83, 29);
            this.Drive4FullRedToggle.TabIndex = 30;
            this.Drive4FullRedToggle.Tag = "Drive4";
            this.Drive4FullRedToggle.Text = "FULL";
            this.Drive4FullRedToggle.UseVisualStyleBackColor = true;
            this.Drive4FullRedToggle.CheckedChanged += new System.EventHandler(this.FullReducedToggleMethod);
            // 
            // Drive5Label
            // 
            this.Drive5Label.AutoSize = true;
            this.Drive5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive5Label.Location = new System.Drawing.Point(215, 300);
            this.Drive5Label.Name = "Drive5Label";
            this.Drive5Label.Size = new System.Drawing.Size(117, 37);
            this.Drive5Label.TabIndex = 31;
            this.Drive5Label.Text = "Drive 5";
            // 
            // Drive5StopStartBtn
            // 
            this.Drive5StopStartBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Drive5StopStartBtn.AutoSize = true;
            this.Drive5StopStartBtn.BackColor = System.Drawing.Color.Green;
            this.Drive5StopStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive5StopStartBtn.Location = new System.Drawing.Point(222, 340);
            this.Drive5StopStartBtn.Name = "Drive5StopStartBtn";
            this.Drive5StopStartBtn.Size = new System.Drawing.Size(91, 35);
            this.Drive5StopStartBtn.TabIndex = 32;
            this.Drive5StopStartBtn.Tag = "Drive5";
            this.Drive5StopStartBtn.Text = "START";
            this.Drive5StopStartBtn.UseVisualStyleBackColor = false;
            this.Drive5StopStartBtn.CheckedChanged += new System.EventHandler(this.StopStartMethod);
            // 
            // Drive5SpeedBar
            // 
            this.Drive5SpeedBar.Location = new System.Drawing.Point(216, 381);
            this.Drive5SpeedBar.Maximum = 2500;
            this.Drive5SpeedBar.Name = "Drive5SpeedBar";
            this.Drive5SpeedBar.Size = new System.Drawing.Size(104, 45);
            this.Drive5SpeedBar.TabIndex = 33;
            this.Drive5SpeedBar.Tag = "Drive5";
            this.Drive5SpeedBar.ValueChanged += new System.EventHandler(this.DriveSpeedControl);
            // 
            // Drive5SpeedText
            // 
            this.Drive5SpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive5SpeedText.Location = new System.Drawing.Point(220, 432);
            this.Drive5SpeedText.MaxLength = 4;
            this.Drive5SpeedText.Name = "Drive5SpeedText";
            this.Drive5SpeedText.Size = new System.Drawing.Size(100, 31);
            this.Drive5SpeedText.TabIndex = 34;
            this.Drive5SpeedText.Tag = "Drive5";
            this.Drive5SpeedText.Text = "0";
            this.Drive5SpeedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericalTextBoxInputValidation);
            // 
            // Drive5SpeedBtn
            // 
            this.Drive5SpeedBtn.AutoSize = true;
            this.Drive5SpeedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive5SpeedBtn.Location = new System.Drawing.Point(202, 469);
            this.Drive5SpeedBtn.Name = "Drive5SpeedBtn";
            this.Drive5SpeedBtn.Size = new System.Drawing.Size(140, 35);
            this.Drive5SpeedBtn.TabIndex = 35;
            this.Drive5SpeedBtn.Tag = "Drive5";
            this.Drive5SpeedBtn.Text = "SET SPEED";
            this.Drive5SpeedBtn.UseVisualStyleBackColor = true;
            this.Drive5SpeedBtn.Click += new System.EventHandler(this.DriveSetSpeed);
            // 
            // Drive5RevForToggle
            // 
            this.Drive5RevForToggle.AutoSize = true;
            this.Drive5RevForToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive5RevForToggle.Location = new System.Drawing.Point(202, 510);
            this.Drive5RevForToggle.Name = "Drive5RevForToggle";
            this.Drive5RevForToggle.Size = new System.Drawing.Size(139, 29);
            this.Drive5RevForToggle.TabIndex = 36;
            this.Drive5RevForToggle.Tag = "Drive5";
            this.Drive5RevForToggle.Text = "FORWARD";
            this.Drive5RevForToggle.UseVisualStyleBackColor = true;
            this.Drive5RevForToggle.CheckedChanged += new System.EventHandler(this.ForwardReverseToggleMethod);
            // 
            // Drive5FullRedToggle
            // 
            this.Drive5FullRedToggle.AutoSize = true;
            this.Drive5FullRedToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive5FullRedToggle.Location = new System.Drawing.Point(202, 545);
            this.Drive5FullRedToggle.Name = "Drive5FullRedToggle";
            this.Drive5FullRedToggle.Size = new System.Drawing.Size(83, 29);
            this.Drive5FullRedToggle.TabIndex = 37;
            this.Drive5FullRedToggle.Tag = "Drive5";
            this.Drive5FullRedToggle.Text = "FULL";
            this.Drive5FullRedToggle.UseVisualStyleBackColor = true;
            this.Drive5FullRedToggle.CheckedChanged += new System.EventHandler(this.FullReducedToggleMethod);
            // 
            // Drive6Label
            // 
            this.Drive6Label.AutoSize = true;
            this.Drive6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive6Label.Location = new System.Drawing.Point(215, 581);
            this.Drive6Label.Name = "Drive6Label";
            this.Drive6Label.Size = new System.Drawing.Size(117, 37);
            this.Drive6Label.TabIndex = 38;
            this.Drive6Label.Text = "Drive 6";
            // 
            // Drive6StopStartBtn
            // 
            this.Drive6StopStartBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Drive6StopStartBtn.AutoSize = true;
            this.Drive6StopStartBtn.BackColor = System.Drawing.Color.Green;
            this.Drive6StopStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive6StopStartBtn.Location = new System.Drawing.Point(222, 621);
            this.Drive6StopStartBtn.Name = "Drive6StopStartBtn";
            this.Drive6StopStartBtn.Size = new System.Drawing.Size(91, 35);
            this.Drive6StopStartBtn.TabIndex = 39;
            this.Drive6StopStartBtn.Tag = "Drive6";
            this.Drive6StopStartBtn.Text = "START";
            this.Drive6StopStartBtn.UseVisualStyleBackColor = false;
            this.Drive6StopStartBtn.CheckedChanged += new System.EventHandler(this.StopStartMethod);
            // 
            // Drive6SpeedBar
            // 
            this.Drive6SpeedBar.Location = new System.Drawing.Point(216, 662);
            this.Drive6SpeedBar.Maximum = 2500;
            this.Drive6SpeedBar.Name = "Drive6SpeedBar";
            this.Drive6SpeedBar.Size = new System.Drawing.Size(104, 45);
            this.Drive6SpeedBar.TabIndex = 40;
            this.Drive6SpeedBar.Tag = "Drive6";
            this.Drive6SpeedBar.ValueChanged += new System.EventHandler(this.DriveSpeedControl);
            // 
            // Drive6SpeedText
            // 
            this.Drive6SpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive6SpeedText.Location = new System.Drawing.Point(220, 703);
            this.Drive6SpeedText.MaxLength = 4;
            this.Drive6SpeedText.Name = "Drive6SpeedText";
            this.Drive6SpeedText.Size = new System.Drawing.Size(100, 31);
            this.Drive6SpeedText.TabIndex = 41;
            this.Drive6SpeedText.Tag = "Drive6";
            this.Drive6SpeedText.Text = "0";
            this.Drive6SpeedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericalTextBoxInputValidation);
            // 
            // Drive6SetSpeedBtn
            // 
            this.Drive6SetSpeedBtn.AutoSize = true;
            this.Drive6SetSpeedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive6SetSpeedBtn.Location = new System.Drawing.Point(202, 740);
            this.Drive6SetSpeedBtn.Name = "Drive6SetSpeedBtn";
            this.Drive6SetSpeedBtn.Size = new System.Drawing.Size(140, 35);
            this.Drive6SetSpeedBtn.TabIndex = 42;
            this.Drive6SetSpeedBtn.Tag = "Drive6";
            this.Drive6SetSpeedBtn.Text = "SET SPEED";
            this.Drive6SetSpeedBtn.UseVisualStyleBackColor = true;
            this.Drive6SetSpeedBtn.Click += new System.EventHandler(this.DriveSetSpeed);
            // 
            // Drive6RevForToggle
            // 
            this.Drive6RevForToggle.AutoSize = true;
            this.Drive6RevForToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive6RevForToggle.Location = new System.Drawing.Point(202, 781);
            this.Drive6RevForToggle.Name = "Drive6RevForToggle";
            this.Drive6RevForToggle.Size = new System.Drawing.Size(139, 29);
            this.Drive6RevForToggle.TabIndex = 43;
            this.Drive6RevForToggle.Tag = "Drive6";
            this.Drive6RevForToggle.Text = "FORWARD";
            this.Drive6RevForToggle.UseVisualStyleBackColor = true;
            this.Drive6RevForToggle.CheckedChanged += new System.EventHandler(this.ForwardReverseToggleMethod);
            // 
            // Drive6RedFullToggle
            // 
            this.Drive6RedFullToggle.AutoSize = true;
            this.Drive6RedFullToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive6RedFullToggle.Location = new System.Drawing.Point(202, 816);
            this.Drive6RedFullToggle.Name = "Drive6RedFullToggle";
            this.Drive6RedFullToggle.Size = new System.Drawing.Size(83, 29);
            this.Drive6RedFullToggle.TabIndex = 44;
            this.Drive6RedFullToggle.Tag = "Drive6";
            this.Drive6RedFullToggle.Text = "FULL";
            this.Drive6RedFullToggle.UseVisualStyleBackColor = true;
            this.Drive6RedFullToggle.CheckedChanged += new System.EventHandler(this.FullReducedToggleMethod);
            // 
            // Drive3HealthTextBox
            // 
            this.Drive3HealthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive3HealthTextBox.Location = new System.Drawing.Point(1760, 775);
            this.Drive3HealthTextBox.Name = "Drive3HealthTextBox";
            this.Drive3HealthTextBox.ReadOnly = true;
            this.Drive3HealthTextBox.Size = new System.Drawing.Size(132, 29);
            this.Drive3HealthTextBox.TabIndex = 45;
            // 
            // Drive1HealthTextBox
            // 
            this.Drive1HealthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive1HealthTextBox.Location = new System.Drawing.Point(1760, 705);
            this.Drive1HealthTextBox.Name = "Drive1HealthTextBox";
            this.Drive1HealthTextBox.ReadOnly = true;
            this.Drive1HealthTextBox.Size = new System.Drawing.Size(132, 29);
            this.Drive1HealthTextBox.TabIndex = 46;
            // 
            // Drive2HealthTextBox
            // 
            this.Drive2HealthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive2HealthTextBox.Location = new System.Drawing.Point(1760, 740);
            this.Drive2HealthTextBox.Name = "Drive2HealthTextBox";
            this.Drive2HealthTextBox.ReadOnly = true;
            this.Drive2HealthTextBox.Size = new System.Drawing.Size(132, 29);
            this.Drive2HealthTextBox.TabIndex = 47;
            // 
            // Drive5HealthTextBox
            // 
            this.Drive5HealthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drive5HealthTextBox.Location = new System.Drawing.Point(1760, 810);
            this.Drive5HealthTextBox.Name = "Drive5HealthTextBox";
            this.Drive5HealthTextBox.ReadOnly = true;
            this.Drive5HealthTextBox.Size = new System.Drawing.Size(132, 29);
            this.Drive5HealthTextBox.TabIndex = 48;
            // 
            // TimeControlTextBox
            // 
            this.TimeControlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeControlTextBox.Location = new System.Drawing.Point(46, 893);
            this.TimeControlTextBox.Name = "TimeControlTextBox";
            this.TimeControlTextBox.Size = new System.Drawing.Size(100, 31);
            this.TimeControlTextBox.TabIndex = 49;
            this.TimeControlTextBox.Text = "0";
            this.TimeControlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeControlTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericalTextBoxInputValidation);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerTextBoxLabel
            // 
            this.TimerTextBoxLabel.AutoSize = true;
            this.TimerTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerTextBoxLabel.Location = new System.Drawing.Point(46, 865);
            this.TimerTextBoxLabel.Name = "TimerTextBoxLabel";
            this.TimerTextBoxLabel.Size = new System.Drawing.Size(59, 25);
            this.TimerTextBoxLabel.TabIndex = 50;
            this.TimerTextBoxLabel.Text = "Time";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.TimerTextBoxLabel);
            this.Controls.Add(this.TimeControlTextBox);
            this.Controls.Add(this.Drive5HealthTextBox);
            this.Controls.Add(this.Drive2HealthTextBox);
            this.Controls.Add(this.Drive1HealthTextBox);
            this.Controls.Add(this.Drive3HealthTextBox);
            this.Controls.Add(this.Drive6RedFullToggle);
            this.Controls.Add(this.Drive6RevForToggle);
            this.Controls.Add(this.Drive6SetSpeedBtn);
            this.Controls.Add(this.Drive6SpeedText);
            this.Controls.Add(this.Drive6SpeedBar);
            this.Controls.Add(this.Drive6StopStartBtn);
            this.Controls.Add(this.Drive6Label);
            this.Controls.Add(this.Drive5FullRedToggle);
            this.Controls.Add(this.Drive5RevForToggle);
            this.Controls.Add(this.Drive5SpeedBtn);
            this.Controls.Add(this.Drive5SpeedText);
            this.Controls.Add(this.Drive5SpeedBar);
            this.Controls.Add(this.Drive5StopStartBtn);
            this.Controls.Add(this.Drive5Label);
            this.Controls.Add(this.Drive4FullRedToggle);
            this.Controls.Add(this.Drive4RevForToggle);
            this.Controls.Add(this.Drive4SetSpeedBtn);
            this.Controls.Add(this.Drive4SpeedText);
            this.Controls.Add(this.Drive4SpeedBar);
            this.Controls.Add(this.Drive4StopStartBtn);
            this.Controls.Add(this.Drive4Label);
            this.Controls.Add(this.Drive3RedFullToggle);
            this.Controls.Add(this.Drive3ForRevToggle);
            this.Controls.Add(this.Drive3SetSpeedBtn);
            this.Controls.Add(this.Drive3SpeedText);
            this.Controls.Add(this.Drive3SpeedBar);
            this.Controls.Add(this.Drive3StopStartBtn);
            this.Controls.Add(this.Drive3Label);
            this.Controls.Add(this.Drive2FullRedToggle);
            this.Controls.Add(this.Drive2ForRevToggle);
            this.Controls.Add(this.Drive2SetSpeedBtn);
            this.Controls.Add(this.Drive2SpeedText);
            this.Controls.Add(this.Drive2SpeedBar);
            this.Controls.Add(this.Drive2StopStartBtn);
            this.Controls.Add(this.Drive2Label);
            this.Controls.Add(this.Drive1FullRedCurrToggle);
            this.Controls.Add(this.Drive1ForRevToggle);
            this.Controls.Add(this.Drive1SpeedBtn);
            this.Controls.Add(this.Drive1SpeedText);
            this.Controls.Add(this.Drive1SpeedBar);
            this.Controls.Add(this.Drive1Label);
            this.Controls.Add(this.Drive1StopStartBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Drive6";
            this.Text = "BaumullerTestPanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drive1SpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drive2SpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drive3SpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drive4SpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drive5SpeedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drive6SpeedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hlepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.CheckBox Drive1StopStartBtn;
        private System.Windows.Forms.Label Drive1Label;
        private System.Windows.Forms.TrackBar Drive1SpeedBar;
        private System.Windows.Forms.TextBox Drive1SpeedText;
        private System.Windows.Forms.Button Drive1SpeedBtn;
        private System.Windows.Forms.CheckBox Drive1ForRevToggle;
        private System.Windows.Forms.CheckBox Drive1FullRedCurrToggle;
        private System.Windows.Forms.Label Drive2Label;
        private System.Windows.Forms.CheckBox Drive2StopStartBtn;
        private System.Windows.Forms.TrackBar Drive2SpeedBar;
        private System.Windows.Forms.TextBox Drive2SpeedText;
        private System.Windows.Forms.Button Drive2SetSpeedBtn;
        private System.Windows.Forms.CheckBox Drive2ForRevToggle;
        private System.Windows.Forms.CheckBox Drive2FullRedToggle;
        private System.Windows.Forms.Label Drive3Label;
        private System.Windows.Forms.CheckBox Drive3StopStartBtn;
        private System.Windows.Forms.TrackBar Drive3SpeedBar;
        private System.Windows.Forms.TextBox Drive3SpeedText;
        private System.Windows.Forms.Button Drive3SetSpeedBtn;
        private System.Windows.Forms.CheckBox Drive3ForRevToggle;
        private System.Windows.Forms.CheckBox Drive3RedFullToggle;
        private System.Windows.Forms.Label Drive4Label;
        private System.Windows.Forms.CheckBox Drive4StopStartBtn;
        private System.Windows.Forms.TrackBar Drive4SpeedBar;
        private System.Windows.Forms.TextBox Drive4SpeedText;
        private System.Windows.Forms.Button Drive4SetSpeedBtn;
        private System.Windows.Forms.CheckBox Drive4RevForToggle;
        private System.Windows.Forms.CheckBox Drive4FullRedToggle;
        private System.Windows.Forms.Label Drive5Label;
        private System.Windows.Forms.CheckBox Drive5StopStartBtn;
        private System.Windows.Forms.TrackBar Drive5SpeedBar;
        private System.Windows.Forms.TextBox Drive5SpeedText;
        private System.Windows.Forms.Button Drive5SpeedBtn;
        private System.Windows.Forms.CheckBox Drive5RevForToggle;
        private System.Windows.Forms.CheckBox Drive5FullRedToggle;
        private System.Windows.Forms.Label Drive6Label;
        private System.Windows.Forms.CheckBox Drive6StopStartBtn;
        private System.Windows.Forms.TrackBar Drive6SpeedBar;
        private System.Windows.Forms.TextBox Drive6SpeedText;
        private System.Windows.Forms.Button Drive6SetSpeedBtn;
        private System.Windows.Forms.CheckBox Drive6RevForToggle;
        private System.Windows.Forms.CheckBox Drive6RedFullToggle;
        private System.Windows.Forms.TextBox Drive3HealthTextBox;
        private System.Windows.Forms.TextBox Drive1HealthTextBox;
        private System.Windows.Forms.TextBox Drive2HealthTextBox;
        private System.Windows.Forms.TextBox Drive5HealthTextBox;
        private System.Windows.Forms.TextBox TimeControlTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerTextBoxLabel;
    }
}

