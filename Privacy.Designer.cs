namespace Win_Tweaker
{
    partial class Privacy
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
            Personalization_LBL = new Label();
            Apply_BTN = new Button();
            Reset_BTN = new Button();
            DiagnosticData_CB = new CheckBox();
            label3 = new Label();
            ScheduledTelemetry_CB = new CheckBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            TailoredExp_CB = new CheckBox();
            SMSuggestions_CB = new CheckBox();
            Cortana_CB = new CheckBox();
            ServicesTel_CB = new CheckBox();
            ExtraTel_CB = new CheckBox();
            AccessToPhoneMic_DD = new ComboBox();
            SuspendLayout();
            // 
            // Personalization_LBL
            // 
            Personalization_LBL.AutoSize = true;
            Personalization_LBL.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold);
            Personalization_LBL.ForeColor = SystemColors.ActiveCaptionText;
            Personalization_LBL.Location = new Point(258, 40);
            Personalization_LBL.Name = "Personalization_LBL";
            Personalization_LBL.Size = new Size(185, 50);
            Personalization_LBL.TabIndex = 15;
            Personalization_LBL.Text = "PRIVACY";
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
            Apply_BTN.TabIndex = 16;
            Apply_BTN.Text = "Apply";
            toolTip1.SetToolTip(Apply_BTN, "Remove all Microsoft Junk from YOUR hardware");
            Apply_BTN.UseVisualStyleBackColor = false;
            Apply_BTN.Click += Apply_BTN_Click;
            // 
            // Reset_BTN
            // 
            Reset_BTN.BackColor = Color.WhiteSmoke;
            Reset_BTN.Cursor = Cursors.Hand;
            Reset_BTN.FlatAppearance.BorderColor = Color.Silver;
            Reset_BTN.FlatAppearance.BorderSize = 2;
            Reset_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            Reset_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            Reset_BTN.FlatStyle = FlatStyle.System;
            Reset_BTN.Font = new Font("Segoe UI Semibold", 19.2F, FontStyle.Bold);
            Reset_BTN.Location = new Point(374, 622);
            Reset_BTN.Name = "Reset_BTN";
            Reset_BTN.Size = new Size(320, 72);
            Reset_BTN.TabIndex = 17;
            Reset_BTN.Text = "Reset to default";
            toolTip1.SetToolTip(Reset_BTN, "Reset the Privacy tweaks to Windows default values. (Requires Apply)");
            Reset_BTN.UseVisualStyleBackColor = false;
            Reset_BTN.Click += ResetToDefault;
            // 
            // DiagnosticData_CB
            // 
            DiagnosticData_CB.BackColor = Color.Transparent;
            DiagnosticData_CB.Checked = true;
            DiagnosticData_CB.CheckState = CheckState.Checked;
            DiagnosticData_CB.FlatStyle = FlatStyle.System;
            DiagnosticData_CB.Location = new Point(148, 161);
            DiagnosticData_CB.Name = "DiagnosticData_CB";
            DiagnosticData_CB.Size = new Size(16, 16);
            DiagnosticData_CB.TabIndex = 19;
            toolTip1.SetToolTip(DiagnosticData_CB, "Checked=Disagnotic data enabled\r\nUnchecked=Disagnotic data disabled\r\n");
            DiagnosticData_CB.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(53, 120);
            label3.Name = "label3";
            label3.Size = new Size(212, 38);
            label3.TabIndex = 18;
            label3.Text = "Diagnostic Data";
            toolTip1.SetToolTip(label3, "Send data to Microsoft about the use of your system");
            // 
            // ScheduledTelemetry_CB
            // 
            ScheduledTelemetry_CB.BackColor = Color.Transparent;
            ScheduledTelemetry_CB.Checked = true;
            ScheduledTelemetry_CB.CheckState = CheckState.Checked;
            ScheduledTelemetry_CB.FlatStyle = FlatStyle.System;
            ScheduledTelemetry_CB.Location = new Point(148, 250);
            ScheduledTelemetry_CB.Name = "ScheduledTelemetry_CB";
            ScheduledTelemetry_CB.Size = new Size(16, 16);
            ScheduledTelemetry_CB.TabIndex = 21;
            toolTip1.SetToolTip(ScheduledTelemetry_CB, "Checked=Scheduled tasks enabled\r\nUnchecked=Scheduled tasks disabled");
            ScheduledTelemetry_CB.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(22, 209);
            label1.Name = "label1";
            label1.Size = new Size(275, 38);
            label1.TabIndex = 20;
            label1.Text = "Scheduled Telemetry";
            toolTip1.SetToolTip(label1, "Telemetry found on Task Scheduler app\r\n");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(355, 190);
            label2.Name = "label2";
            label2.Size = new Size(345, 76);
            label2.TabIndex = 22;
            label2.Text = "Tailored Experiences\r\nInk && Type Personalization";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(label2, "Ads and ink & typing personalization\r\n");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(401, 518);
            label4.Name = "label4";
            label4.Size = new Size(282, 38);
            label4.TabIndex = 24;
            label4.Text = "Start Menu Telemetry";
            toolTip1.SetToolTip(label4, "Telemetry found on the Start Menu");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(135, 426);
            label5.Name = "label5";
            label5.Size = new Size(432, 38);
            label5.TabIndex = 26;
            label5.Text = "Cortana and Searchbox Telemetry";
            toolTip1.SetToolTip(label5, "RIP Cortana");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(425, 120);
            label6.Name = "label6";
            label6.Size = new Size(246, 38);
            label6.TabIndex = 28;
            label6.Text = "Services Telemetry";
            toolTip1.SetToolTip(label6, "Telemetry found on Services app");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(0, 518);
            label7.Name = "label7";
            label7.Size = new Size(340, 38);
            label7.TabIndex = 30;
            label7.Text = "General && Extra Telemetry";
            toolTip1.SetToolTip(label7, "General telemetry setting and more");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(78, 306);
            label8.Name = "label8";
            label8.Size = new Size(545, 38);
            label8.TabIndex = 32;
            label8.Text = "Allow Access to Phone, Location, Email etc.\r\n";
            toolTip1.SetToolTip(label8, "Allow Wiondows and Desktop Apps to access different aspects of your PC");
            // 
            // TailoredExp_CB
            // 
            TailoredExp_CB.BackColor = Color.Transparent;
            TailoredExp_CB.Checked = true;
            TailoredExp_CB.CheckState = CheckState.Checked;
            TailoredExp_CB.FlatStyle = FlatStyle.System;
            TailoredExp_CB.Location = new Point(542, 269);
            TailoredExp_CB.Name = "TailoredExp_CB";
            TailoredExp_CB.Size = new Size(16, 16);
            TailoredExp_CB.TabIndex = 23;
            toolTip1.SetToolTip(TailoredExp_CB, "Checked=Tailored experinces and Ink & Type personalization enabled\r\nUnchecked=Tailored experinces and Ink & Type personalization disabled");
            TailoredExp_CB.UseVisualStyleBackColor = false;
            // 
            // SMSuggestions_CB
            // 
            SMSuggestions_CB.BackColor = Color.Transparent;
            SMSuggestions_CB.Checked = true;
            SMSuggestions_CB.CheckState = CheckState.Checked;
            SMSuggestions_CB.FlatStyle = FlatStyle.System;
            SMSuggestions_CB.Location = new Point(542, 559);
            SMSuggestions_CB.Name = "SMSuggestions_CB";
            SMSuggestions_CB.Size = new Size(16, 16);
            SMSuggestions_CB.TabIndex = 25;
            toolTip1.SetToolTip(SMSuggestions_CB, "Checked=Start menu telemetry enabled\r\nUnchecked=Start menu telemetry disabled\r\n");
            SMSuggestions_CB.UseVisualStyleBackColor = false;
            // 
            // Cortana_CB
            // 
            Cortana_CB.BackColor = Color.Transparent;
            Cortana_CB.Checked = true;
            Cortana_CB.CheckState = CheckState.Checked;
            Cortana_CB.FlatStyle = FlatStyle.System;
            Cortana_CB.Location = new Point(342, 467);
            Cortana_CB.Name = "Cortana_CB";
            Cortana_CB.Size = new Size(16, 16);
            Cortana_CB.TabIndex = 27;
            toolTip1.SetToolTip(Cortana_CB, "Checked=Cortana and searchbox telemetry enabled\r\nUnchecked=Cortana and searchbox telemetry disabled");
            Cortana_CB.UseVisualStyleBackColor = false;
            // 
            // ServicesTel_CB
            // 
            ServicesTel_CB.BackColor = Color.Transparent;
            ServicesTel_CB.Checked = true;
            ServicesTel_CB.CheckState = CheckState.Checked;
            ServicesTel_CB.FlatStyle = FlatStyle.System;
            ServicesTel_CB.Location = new Point(542, 161);
            ServicesTel_CB.Name = "ServicesTel_CB";
            ServicesTel_CB.Size = new Size(16, 16);
            ServicesTel_CB.TabIndex = 29;
            toolTip1.SetToolTip(ServicesTel_CB, "Checked=Services enabled\r\nUnchecked=Services disabled");
            ServicesTel_CB.UseVisualStyleBackColor = false;
            // 
            // ExtraTel_CB
            // 
            ExtraTel_CB.BackColor = Color.Transparent;
            ExtraTel_CB.Checked = true;
            ExtraTel_CB.CheckState = CheckState.Checked;
            ExtraTel_CB.FlatStyle = FlatStyle.System;
            ExtraTel_CB.Location = new Point(148, 559);
            ExtraTel_CB.Name = "ExtraTel_CB";
            ExtraTel_CB.Size = new Size(16, 16);
            ExtraTel_CB.TabIndex = 31;
            toolTip1.SetToolTip(ExtraTel_CB, "Checked=General telemetry and extra telemetry enabled\r\nUnchecked=General telemetry and extra telemetry disabled\r\n");
            ExtraTel_CB.UseVisualStyleBackColor = false;
            // 
            // AccessToPhoneMic_DD
            // 
            AccessToPhoneMic_DD.BackColor = Color.Silver;
            AccessToPhoneMic_DD.DropDownStyle = ComboBoxStyle.DropDownList;
            AccessToPhoneMic_DD.FlatStyle = FlatStyle.System;
            AccessToPhoneMic_DD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccessToPhoneMic_DD.ForeColor = Color.Black;
            AccessToPhoneMic_DD.FormattingEnabled = true;
            AccessToPhoneMic_DD.IntegralHeight = false;
            AccessToPhoneMic_DD.Items.AddRange(new object[] { "Microphone and Camera (Recommended)", "Microphone, Camera, Location, Calendar and Email", "Microphone, Camera, Location, Calendar, Email, Bluetooth, Cellular Data and Phone", "All (default)" });
            AccessToPhoneMic_DD.Location = new Point(3, 354);
            AccessToPhoneMic_DD.Name = "AccessToPhoneMic_DD";
            AccessToPhoneMic_DD.Size = new Size(694, 36);
            AccessToPhoneMic_DD.TabIndex = 34;
            toolTip1.SetToolTip(AccessToPhoneMic_DD, "All=Let Windows and Desktop Apps access all aspects");
            // 
            // Privacy
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(AccessToPhoneMic_DD);
            Controls.Add(label8);
            Controls.Add(ExtraTel_CB);
            Controls.Add(label7);
            Controls.Add(ServicesTel_CB);
            Controls.Add(label6);
            Controls.Add(Cortana_CB);
            Controls.Add(label5);
            Controls.Add(SMSuggestions_CB);
            Controls.Add(label4);
            Controls.Add(TailoredExp_CB);
            Controls.Add(label2);
            Controls.Add(ScheduledTelemetry_CB);
            Controls.Add(label1);
            Controls.Add(DiagnosticData_CB);
            Controls.Add(label3);
            Controls.Add(Reset_BTN);
            Controls.Add(Apply_BTN);
            Controls.Add(Personalization_LBL);
            Font = new Font("Segoe UI", 19F);
            Margin = new Padding(0);
            MaximumSize = new Size(700, 700);
            MinimumSize = new Size(700, 700);
            Name = "Privacy";
            Size = new Size(700, 700);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Personalization_LBL;
        private Button Apply_BTN;
        private Button Reset_BTN;
        private CheckBox DiagnosticData_CB;
        private Label label3;
        private CheckBox ScheduledTelemetry_CB;
        private Label label1;
        private ToolTip toolTip1;
        private CheckBox TailoredExp_CB;
        private Label label2;
        private CheckBox SMSuggestions_CB;
        private Label label4;
        private CheckBox Cortana_CB;
        private Label label5;
        private CheckBox ServicesTel_CB;
        private Label label6;
        private CheckBox ExtraTel_CB;
        private Label label7;
        private Label label8;
        private ComboBox AccessToPhoneMic_DD;
    }
}
