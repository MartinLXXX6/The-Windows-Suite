namespace Win_Tweaker
{
    partial class Personalization
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
            TaskbarSize_DD = new ComboBox();
            label1 = new Label();
            Apply_BTN = new Button();
            label2 = new Label();
            DynamicSearchBox_CB = new CheckBox();
            WebBrowsingOnSearchBox_CB = new CheckBox();
            label3 = new Label();
            LockScreen_CB = new CheckBox();
            label4 = new Label();
            Reset_BTN = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SnapAssist_CB = new CheckBox();
            jabov = new Label();
            VeroboseStatus_CB = new CheckBox();
            label11 = new Label();
            toolTip1 = new ToolTip(components);
            AdvancedTS_BTN = new Button();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            SuspendLayout();
            // 
            // Personalization_LBL
            // 
            Personalization_LBL.AutoSize = true;
            Personalization_LBL.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold);
            Personalization_LBL.ForeColor = SystemColors.ActiveCaptionText;
            Personalization_LBL.Location = new Point(161, 40);
            Personalization_LBL.Name = "Personalization_LBL";
            Personalization_LBL.Size = new Size(378, 50);
            Personalization_LBL.TabIndex = 1;
            Personalization_LBL.Text = "PERSONALIZATION";
            Personalization_LBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TaskbarSize_DD
            // 
            TaskbarSize_DD.BackColor = Color.Silver;
            TaskbarSize_DD.DropDownStyle = ComboBoxStyle.DropDownList;
            TaskbarSize_DD.FlatStyle = FlatStyle.System;
            TaskbarSize_DD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TaskbarSize_DD.ForeColor = Color.Black;
            TaskbarSize_DD.FormattingEnabled = true;
            TaskbarSize_DD.IntegralHeight = false;
            TaskbarSize_DD.Items.AddRange(new object[] { "Huge", "Medium (Default)" });
            TaskbarSize_DD.Location = new Point(450, 216);
            TaskbarSize_DD.Name = "TaskbarSize_DD";
            TaskbarSize_DD.Size = new Size(180, 36);
            TaskbarSize_DD.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(460, 174);
            label1.Name = "label1";
            label1.Size = new Size(167, 38);
            label1.TabIndex = 3;
            label1.Text = "Taskbar Size";
            toolTip1.SetToolTip(label1, "The actual size of the taskbar.\r\n-WINDOWS 11 ONLY");
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
            Apply_BTN.TabIndex = 4;
            Apply_BTN.Text = "Apply";
            toolTip1.SetToolTip(Apply_BTN, "Run the tweaks found on the current tab.");
            Apply_BTN.UseVisualStyleBackColor = false;
            Apply_BTN.Click += Apply_BTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(34, 265);
            label2.Name = "label2";
            label2.Size = new Size(266, 38);
            label2.TabIndex = 5;
            label2.Text = "Dynamic search box";
            toolTip1.SetToolTip(label2, "See latest news on the main page of the searchbox.\r\n-WINDOWS 10 & 11");
            // 
            // DynamicSearchBox_CB
            // 
            DynamicSearchBox_CB.BackColor = Color.Transparent;
            DynamicSearchBox_CB.Checked = true;
            DynamicSearchBox_CB.CheckState = CheckState.Checked;
            DynamicSearchBox_CB.FlatStyle = FlatStyle.System;
            DynamicSearchBox_CB.Location = new Point(157, 306);
            DynamicSearchBox_CB.Name = "DynamicSearchBox_CB";
            DynamicSearchBox_CB.Size = new Size(16, 16);
            DynamicSearchBox_CB.TabIndex = 6;
            DynamicSearchBox_CB.UseVisualStyleBackColor = false;
            // 
            // WebBrowsingOnSearchBox_CB
            // 
            WebBrowsingOnSearchBox_CB.BackColor = Color.Transparent;
            WebBrowsingOnSearchBox_CB.Checked = true;
            WebBrowsingOnSearchBox_CB.CheckState = CheckState.Checked;
            WebBrowsingOnSearchBox_CB.FlatStyle = FlatStyle.System;
            WebBrowsingOnSearchBox_CB.Location = new Point(157, 221);
            WebBrowsingOnSearchBox_CB.Name = "WebBrowsingOnSearchBox_CB";
            WebBrowsingOnSearchBox_CB.Size = new Size(16, 16);
            WebBrowsingOnSearchBox_CB.TabIndex = 8;
            WebBrowsingOnSearchBox_CB.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(67, 180);
            label3.Name = "label3";
            label3.Size = new Size(194, 38);
            label3.TabIndex = 7;
            label3.Text = "Web Browsing";
            toolTip1.SetToolTip(label3, "Browse the web with Bing every time you type on the searchbox.\r\n-WINDOWS 10 & 11");
            // 
            // LockScreen_CB
            // 
            LockScreen_CB.BackColor = Color.Transparent;
            LockScreen_CB.Checked = true;
            LockScreen_CB.CheckState = CheckState.Checked;
            LockScreen_CB.FlatStyle = FlatStyle.System;
            LockScreen_CB.Location = new Point(157, 490);
            LockScreen_CB.Name = "LockScreen_CB";
            LockScreen_CB.Size = new Size(16, 16);
            LockScreen_CB.TabIndex = 10;
            LockScreen_CB.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(85, 449);
            label4.Name = "label4";
            label4.Size = new Size(165, 38);
            label4.TabIndex = 9;
            label4.Text = "Lock Screen";
            toolTip1.SetToolTip(label4, "Toggle the screen displayed before password input screen.\r\n-WINDOWS 10 & 11");
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
            Reset_BTN.TabIndex = 11;
            Reset_BTN.Text = "Reset to default";
            toolTip1.SetToolTip(Reset_BTN, "Reset the tweaks from this tab to Windows default values. (Requires Apply)");
            Reset_BTN.UseVisualStyleBackColor = false;
            Reset_BTN.Click += ResetToDefault;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 128);
            label5.Name = "label5";
            label5.Size = new Size(267, 38);
            label5.TabIndex = 12;
            label5.Text = "Searchbox Settings";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(427, 128);
            label6.Name = "label6";
            label6.Size = new Size(232, 38);
            label6.TabIndex = 13;
            label6.Text = "Taskbar Settings";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(65, 397);
            label7.Name = "label7";
            label7.Size = new Size(205, 38);
            label7.TabIndex = 14;
            label7.Text = "Login Settings";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(419, 457);
            label8.Name = "label8";
            label8.Size = new Size(241, 38);
            label8.TabIndex = 15;
            label8.Text = "Window Settings";
            // 
            // SnapAssist_CB
            // 
            SnapAssist_CB.BackColor = Color.Transparent;
            SnapAssist_CB.Checked = true;
            SnapAssist_CB.CheckState = CheckState.Checked;
            SnapAssist_CB.FlatStyle = FlatStyle.System;
            SnapAssist_CB.Location = new Point(534, 545);
            SnapAssist_CB.Name = "SnapAssist_CB";
            SnapAssist_CB.Size = new Size(16, 16);
            SnapAssist_CB.TabIndex = 17;
            SnapAssist_CB.UseVisualStyleBackColor = false;
            // 
            // jabov
            // 
            jabov.AutoSize = true;
            jabov.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jabov.ForeColor = Color.FromArgb(64, 64, 64);
            jabov.Location = new Point(463, 504);
            jabov.Name = "jabov";
            jabov.Size = new Size(156, 38);
            jabov.TabIndex = 16;
            jabov.Text = "Snap Assist";
            toolTip1.SetToolTip(jabov, "UI displayed when hovering over maximize button on Win11.\r\n-WINDOWS 11 ONLY");
            // 
            // VeroboseStatus_CB
            // 
            VeroboseStatus_CB.BackColor = Color.Transparent;
            VeroboseStatus_CB.FlatStyle = FlatStyle.System;
            VeroboseStatus_CB.Location = new Point(157, 576);
            VeroboseStatus_CB.Name = "VeroboseStatus_CB";
            VeroboseStatus_CB.Size = new Size(16, 16);
            VeroboseStatus_CB.TabIndex = 22;
            VeroboseStatus_CB.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(58, 535);
            label11.Name = "label11";
            label11.Size = new Size(220, 38);
            label11.TabIndex = 21;
            label11.Text = "Status Messages";
            toolTip1.SetToolTip(label11, "Display more info about what's happening during shutdown and boot.\r\n-WINDOWS 10 & 11");
            // 
            // AdvancedTS_BTN
            // 
            AdvancedTS_BTN.BackColor = Color.WhiteSmoke;
            AdvancedTS_BTN.Cursor = Cursors.Hand;
            AdvancedTS_BTN.FlatAppearance.BorderColor = Color.Silver;
            AdvancedTS_BTN.FlatAppearance.BorderSize = 2;
            AdvancedTS_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            AdvancedTS_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            AdvancedTS_BTN.FlatStyle = FlatStyle.System;
            AdvancedTS_BTN.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdvancedTS_BTN.Location = new Point(414, 305);
            AdvancedTS_BTN.Name = "AdvancedTS_BTN";
            AdvancedTS_BTN.Size = new Size(250, 92);
            AdvancedTS_BTN.TabIndex = 23;
            AdvancedTS_BTN.Text = "Advanced Taskbar Settings";
            toolTip1.SetToolTip(AdvancedTS_BTN, " Access advanced taskbar settings such as managing tray icons or disabling notification center.\r\n-WINDOWS 10 ONLY");
            AdvancedTS_BTN.UseVisualStyleBackColor = false;
            AdvancedTS_BTN.Click += AdvancedTS_BTN_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(487, 255);
            label9.Name = "label9";
            label9.Size = new Size(111, 25);
            label9.TabIndex = 48;
            label9.Text = "Windows 11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(487, 400);
            label10.Name = "label10";
            label10.Size = new Size(111, 25);
            label10.TabIndex = 49;
            label10.Text = "Windows 10";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(487, 564);
            label12.Name = "label12";
            label12.Size = new Size(111, 25);
            label12.TabIndex = 50;
            label12.Text = "Windows 11";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(85, 103);
            label13.Name = "label13";
            label13.Size = new Size(155, 25);
            label13.TabIndex = 51;
            label13.Text = "Windows 10 && 11";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DimGray;
            label14.Location = new Point(85, 372);
            label14.Name = "label14";
            label14.Size = new Size(155, 25);
            label14.TabIndex = 52;
            label14.Text = "Windows 10 && 11";
            // 
            // Personalization
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(AdvancedTS_BTN);
            Controls.Add(label6);
            Controls.Add(VeroboseStatus_CB);
            Controls.Add(label11);
            Controls.Add(SnapAssist_CB);
            Controls.Add(jabov);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(Reset_BTN);
            Controls.Add(LockScreen_CB);
            Controls.Add(label4);
            Controls.Add(WebBrowsingOnSearchBox_CB);
            Controls.Add(label3);
            Controls.Add(DynamicSearchBox_CB);
            Controls.Add(label2);
            Controls.Add(Apply_BTN);
            Controls.Add(label1);
            Controls.Add(TaskbarSize_DD);
            Controls.Add(Personalization_LBL);
            Font = new Font("Segoe UI", 19F);
            Margin = new Padding(0);
            MaximumSize = new Size(700, 700);
            MinimumSize = new Size(700, 700);
            Name = "Personalization";
            Size = new Size(700, 700);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Personalization_LBL;
        private ComboBox TaskbarSize_DD;
        private Label label1;
        private Button Apply_BTN;
        private Label label2;
        private CheckBox DynamicSearchBox_CB;
        private CheckBox WebBrowsingOnSearchBox_CB;
        private Label label3;
        private CheckBox LockScreen_CB;
        private Label label4;
        private Button Reset_BTN;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox SnapAssist_CB;
        private Label jabov;
        private CheckBox VeroboseStatus_CB;
        private Label label11;
        private ToolTip toolTip1;
        private Button AdvancedTS_BTN;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}
