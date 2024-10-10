namespace Win_Tweaker
{
    partial class Startup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            Personalization_LBL = new Label();
            Apply_BTN = new Button();
            StartupApps_RTB = new RichTextBox();
            Check_BTN = new Button();
            label3 = new Label();
            MicrosoftEdgeStartup_CB = new CheckBox();
            SilentInstalls_CB = new CheckBox();
            SilentInstalls = new Label();
            ResetToDefault_BTN = new Button();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // Personalization_LBL
            // 
            Personalization_LBL.AutoSize = true;
            Personalization_LBL.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold);
            Personalization_LBL.ForeColor = SystemColors.ActiveCaptionText;
            Personalization_LBL.Location = new Point(253, 40);
            Personalization_LBL.Name = "Personalization_LBL";
            Personalization_LBL.Size = new Size(195, 50);
            Personalization_LBL.TabIndex = 16;
            Personalization_LBL.Text = "STARTUP";
            Personalization_LBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Apply_BTN
            // 
            Apply_BTN.BackColor = Color.WhiteSmoke;
            Apply_BTN.Cursor = Cursors.Hand;
            Apply_BTN.FlatAppearance.BorderColor = Color.Silver;
            Apply_BTN.FlatAppearance.BorderSize = 2;
            Apply_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            Apply_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            Apply_BTN.FlatStyle = FlatStyle.System;
            Apply_BTN.Font = new Font("Segoe UI Semibold", 19.2F, FontStyle.Bold);
            Apply_BTN.Location = new Point(6, 622);
            Apply_BTN.Name = "Apply_BTN";
            Apply_BTN.Size = new Size(320, 72);
            Apply_BTN.TabIndex = 18;
            Apply_BTN.Text = "Apply";
            toolTip1.SetToolTip(Apply_BTN, "Run the tweaks found on the current tab.");
            Apply_BTN.UseVisualStyleBackColor = false;
            Apply_BTN.Click += Apply_BTN_Click;
            // 
            // StartupApps_RTB
            // 
            StartupApps_RTB.BackColor = Color.LightGray;
            StartupApps_RTB.BorderStyle = BorderStyle.None;
            StartupApps_RTB.Font = new Font("Segoe UI", 11F);
            StartupApps_RTB.Location = new Point(3, 136);
            StartupApps_RTB.Name = "StartupApps_RTB";
            StartupApps_RTB.ReadOnly = true;
            StartupApps_RTB.Size = new Size(694, 314);
            StartupApps_RTB.TabIndex = 19;
            StartupApps_RTB.Text = resources.GetString("StartupApps_RTB.Text");
            // 
            // Check_BTN
            // 
            Check_BTN.BackColor = Color.WhiteSmoke;
            Check_BTN.Cursor = Cursors.Hand;
            Check_BTN.FlatAppearance.BorderColor = Color.Silver;
            Check_BTN.FlatAppearance.BorderSize = 2;
            Check_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            Check_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            Check_BTN.FlatStyle = FlatStyle.System;
            Check_BTN.Font = new Font("Segoe UI Semibold", 19.2F, FontStyle.Bold);
            Check_BTN.Location = new Point(37, 544);
            Check_BTN.Name = "Check_BTN";
            Check_BTN.Size = new Size(626, 72);
            Check_BTN.TabIndex = 17;
            Check_BTN.Text = "Check";
            toolTip1.SetToolTip(Check_BTN, "Check the current apps found on the registry startup entries.");
            Check_BTN.UseVisualStyleBackColor = false;
            Check_BTN.Click += Check_BTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(6, 462);
            label3.Name = "label3";
            label3.Size = new Size(203, 38);
            label3.TabIndex = 20;
            label3.Text = "Microsoft Edge";
            toolTip1.SetToolTip(label3, "Prevent Microsoft Edge to start on startup.\r\n-WINDOWS 10 & 11");
            // 
            // MicrosoftEdgeStartup_CB
            // 
            MicrosoftEdgeStartup_CB.Checked = true;
            MicrosoftEdgeStartup_CB.CheckState = CheckState.Checked;
            MicrosoftEdgeStartup_CB.FlatStyle = FlatStyle.System;
            MicrosoftEdgeStartup_CB.Location = new Point(99, 503);
            MicrosoftEdgeStartup_CB.Name = "MicrosoftEdgeStartup_CB";
            MicrosoftEdgeStartup_CB.Size = new Size(16, 16);
            MicrosoftEdgeStartup_CB.TabIndex = 21;
            MicrosoftEdgeStartup_CB.UseVisualStyleBackColor = true;
            // 
            // SilentInstalls_CB
            // 
            SilentInstalls_CB.Checked = true;
            SilentInstalls_CB.CheckState = CheckState.Checked;
            SilentInstalls_CB.FlatStyle = FlatStyle.System;
            SilentInstalls_CB.Location = new Point(563, 503);
            SilentInstalls_CB.Name = "SilentInstalls_CB";
            SilentInstalls_CB.Size = new Size(16, 16);
            SilentInstalls_CB.TabIndex = 23;
            SilentInstalls_CB.UseVisualStyleBackColor = true;
            // 
            // SilentInstalls
            // 
            SilentInstalls.AutoSize = true;
            SilentInstalls.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SilentInstalls.ForeColor = Color.FromArgb(64, 64, 64);
            SilentInstalls.Location = new Point(440, 462);
            SilentInstalls.Name = "SilentInstalls";
            SilentInstalls.Size = new Size(254, 38);
            SilentInstalls.TabIndex = 22;
            SilentInstalls.Text = "Allow Silent Installs";
            toolTip1.SetToolTip(SilentInstalls, resources.GetString("SilentInstalls.ToolTip"));
            // 
            // ResetToDefault_BTN
            // 
            ResetToDefault_BTN.BackColor = Color.WhiteSmoke;
            ResetToDefault_BTN.Cursor = Cursors.Hand;
            ResetToDefault_BTN.FlatAppearance.BorderColor = Color.Silver;
            ResetToDefault_BTN.FlatAppearance.BorderSize = 2;
            ResetToDefault_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            ResetToDefault_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            ResetToDefault_BTN.FlatStyle = FlatStyle.System;
            ResetToDefault_BTN.Font = new Font("Segoe UI Semibold", 19.2F, FontStyle.Bold);
            ResetToDefault_BTN.Location = new Point(374, 622);
            ResetToDefault_BTN.Name = "ResetToDefault_BTN";
            ResetToDefault_BTN.Size = new Size(320, 72);
            ResetToDefault_BTN.TabIndex = 24;
            ResetToDefault_BTN.Text = "Reset to default";
            toolTip1.SetToolTip(ResetToDefault_BTN, "Reset the tweaks from this tab to Windows default values. (Requires Apply)");
            ResetToDefault_BTN.UseVisualStyleBackColor = false;
            ResetToDefault_BTN.Click += ResetToDefault;
            // 
            // label1
            // 
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI Semilight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 104);
            label1.Name = "label1";
            label1.Size = new Size(694, 31);
            label1.TabIndex = 25;
            label1.Text = "                                                    App                                               |           Status         ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(273, 15);
            label13.Name = "label13";
            label13.Size = new Size(155, 25);
            label13.TabIndex = 52;
            label13.Text = "Windows 10 && 11";
            // 
            // Startup
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(label13);
            Controls.Add(label1);
            Controls.Add(ResetToDefault_BTN);
            Controls.Add(SilentInstalls_CB);
            Controls.Add(SilentInstalls);
            Controls.Add(MicrosoftEdgeStartup_CB);
            Controls.Add(label3);
            Controls.Add(StartupApps_RTB);
            Controls.Add(Apply_BTN);
            Controls.Add(Check_BTN);
            Controls.Add(Personalization_LBL);
            Font = new Font("Segoe UI", 19F);
            Margin = new Padding(0);
            MaximumSize = new Size(700, 700);
            MinimumSize = new Size(700, 700);
            Name = "Startup";
            Size = new Size(700, 700);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Personalization_LBL;
        private Button Apply_BTN;
        private RichTextBox StartupApps_RTB;
        private Button Check_BTN;
        private Label label3;
        private CheckBox MicrosoftEdgeStartup_CB;
        private CheckBox SilentInstalls_CB;
        private Label SilentInstalls;
        private Button ResetToDefault_BTN;
        private ToolTip toolTip1;
        private Label label1;
        private Label label13;
    }
}
