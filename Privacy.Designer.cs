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
            TailoredExp_CB = new CheckBox();
            label2 = new Label();
            SMSuggestions_CB = new CheckBox();
            label4 = new Label();
            RemoveCortana_CB = new CheckBox();
            label5 = new Label();
            ServicesTel_CB = new CheckBox();
            label6 = new Label();
            ExtraTel_CB = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            AccessToPhoneMic_DD = new ComboBox();
            SuspendLayout();
            // 
            // Personalization_LBL
            // 
            Personalization_LBL.AutoSize = true;
            Personalization_LBL.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold);
            Personalization_LBL.ForeColor = SystemColors.ActiveCaptionText;
            Personalization_LBL.Location = new Point(283, 40);
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
            Apply_BTN.FlatStyle = FlatStyle.Flat;
            Apply_BTN.Font = new Font("Segoe UI Semibold", 19.2F, FontStyle.Bold);
            Apply_BTN.Location = new Point(10, 716);
            Apply_BTN.Name = "Apply_BTN";
            Apply_BTN.Size = new Size(358, 75);
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
            Reset_BTN.FlatStyle = FlatStyle.Flat;
            Reset_BTN.Font = new Font("Segoe UI Semibold", 19.2F, FontStyle.Bold);
            Reset_BTN.Location = new Point(382, 716);
            Reset_BTN.Name = "Reset_BTN";
            Reset_BTN.Size = new Size(358, 75);
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
            DiagnosticData_CB.Location = new Point(189, 219);
            DiagnosticData_CB.Name = "DiagnosticData_CB";
            DiagnosticData_CB.Size = new Size(16, 16);
            DiagnosticData_CB.TabIndex = 19;
            DiagnosticData_CB.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(90, 178);
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
            ScheduledTelemetry_CB.Location = new Point(189, 311);
            ScheduledTelemetry_CB.Name = "ScheduledTelemetry_CB";
            ScheduledTelemetry_CB.Size = new Size(16, 16);
            ScheduledTelemetry_CB.TabIndex = 21;
            ScheduledTelemetry_CB.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(58, 270);
            label1.Name = "label1";
            label1.Size = new Size(275, 38);
            label1.TabIndex = 20;
            label1.Text = "Scheduled Telemetry";
            toolTip1.SetToolTip(label1, "Telemetry location");
            // 
            // TailoredExp_CB
            // 
            TailoredExp_CB.BackColor = Color.Transparent;
            TailoredExp_CB.Checked = true;
            TailoredExp_CB.CheckState = CheckState.Checked;
            TailoredExp_CB.Location = new Point(536, 311);
            TailoredExp_CB.Name = "TailoredExp_CB";
            TailoredExp_CB.Size = new Size(16, 16);
            TailoredExp_CB.TabIndex = 23;
            TailoredExp_CB.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(411, 270);
            label2.Name = "label2";
            label2.Size = new Size(268, 38);
            label2.TabIndex = 22;
            label2.Text = "Tailored Experiences";
            toolTip1.SetToolTip(label2, "More Telemetry.....");
            // 
            // SMSuggestions_CB
            // 
            SMSuggestions_CB.BackColor = Color.Transparent;
            SMSuggestions_CB.Checked = true;
            SMSuggestions_CB.CheckState = CheckState.Checked;
            SMSuggestions_CB.Location = new Point(560, 634);
            SMSuggestions_CB.Name = "SMSuggestions_CB";
            SMSuggestions_CB.Size = new Size(16, 16);
            SMSuggestions_CB.TabIndex = 25;
            SMSuggestions_CB.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(423, 593);
            label4.Name = "label4";
            label4.Size = new Size(282, 38);
            label4.TabIndex = 24;
            label4.Text = "Start Menu Telemetry";
            toolTip1.SetToolTip(label4, "More Telemetry");
            // 
            // RemoveCortana_CB
            // 
            RemoveCortana_CB.BackColor = Color.Transparent;
            RemoveCortana_CB.Location = new Point(367, 532);
            RemoveCortana_CB.Name = "RemoveCortana_CB";
            RemoveCortana_CB.Size = new Size(16, 16);
            RemoveCortana_CB.TabIndex = 27;
            RemoveCortana_CB.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(106, 491);
            label5.Name = "label5";
            label5.Size = new Size(539, 38);
            label5.TabIndex = 26;
            label5.Text = "Remove Cortana and Searchbox Telemetry";
            toolTip1.SetToolTip(label5, "RIP Cortana");
            // 
            // ServicesTel_CB
            // 
            ServicesTel_CB.BackColor = Color.Transparent;
            ServicesTel_CB.Checked = true;
            ServicesTel_CB.CheckState = CheckState.Checked;
            ServicesTel_CB.Location = new Point(537, 219);
            ServicesTel_CB.Name = "ServicesTel_CB";
            ServicesTel_CB.Size = new Size(16, 16);
            ServicesTel_CB.TabIndex = 29;
            ServicesTel_CB.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(423, 178);
            label6.Name = "label6";
            label6.Size = new Size(246, 38);
            label6.TabIndex = 28;
            label6.Text = "Services Telemetry";
            toolTip1.SetToolTip(label6, "Telemetry location");
            // 
            // ExtraTel_CB
            // 
            ExtraTel_CB.BackColor = Color.Transparent;
            ExtraTel_CB.Checked = true;
            ExtraTel_CB.CheckState = CheckState.Checked;
            ExtraTel_CB.Location = new Point(183, 634);
            ExtraTel_CB.Name = "ExtraTel_CB";
            ExtraTel_CB.Size = new Size(16, 16);
            ExtraTel_CB.TabIndex = 31;
            ExtraTel_CB.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(90, 593);
            label7.Name = "label7";
            label7.Size = new Size(206, 38);
            label7.TabIndex = 30;
            label7.Text = "Extra Telemetry";
            toolTip1.SetToolTip(label7, "More Telemetry");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(103, 375);
            label8.Name = "label8";
            label8.Size = new Size(545, 38);
            label8.TabIndex = 32;
            label8.Text = "Allow Access to Phone, Location, Email etc.\r\n";
            toolTip1.SetToolTip(label8, "Allow Microsoft to access different aspects of your PC");
            // 
            // AccessToPhoneMic_DD
            // 
            AccessToPhoneMic_DD.BackColor = Color.Silver;
            AccessToPhoneMic_DD.DropDownStyle = ComboBoxStyle.DropDownList;
            AccessToPhoneMic_DD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccessToPhoneMic_DD.ForeColor = Color.Black;
            AccessToPhoneMic_DD.FormattingEnabled = true;
            AccessToPhoneMic_DD.IntegralHeight = false;
            AccessToPhoneMic_DD.Items.AddRange(new object[] { "None", "Microphone, Location, Calendar and Email", "Microphone, Location, Calendar, Email, Bluetooth, Cellular Data, Phone and Webcam", "All (default)" });
            AccessToPhoneMic_DD.Location = new Point(4, 416);
            AccessToPhoneMic_DD.Name = "AccessToPhoneMic_DD";
            AccessToPhoneMic_DD.Size = new Size(743, 36);
            AccessToPhoneMic_DD.TabIndex = 34;
            // 
            // Privacy
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(AccessToPhoneMic_DD);
            Controls.Add(label8);
            Controls.Add(ExtraTel_CB);
            Controls.Add(label7);
            Controls.Add(ServicesTel_CB);
            Controls.Add(label6);
            Controls.Add(RemoveCortana_CB);
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
            Margin = new Padding(7);
            MaximumSize = new Size(750, 800);
            MinimumSize = new Size(750, 800);
            Name = "Privacy";
            Size = new Size(750, 800);
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
        private CheckBox RemoveCortana_CB;
        private Label label5;
        private CheckBox ServicesTel_CB;
        private Label label6;
        private CheckBox ExtraTel_CB;
        private Label label7;
        private Label label8;
        private ComboBox AccessToPhoneMic_DD;
    }
}
