namespace Win_Tweaker
{
    partial class Optimization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Optimization));
            Optimization_LBL = new Label();
            label5 = new Label();
            PThrottling_CB = new CheckBox();
            label3 = new Label();
            NThrottling_CB = new CheckBox();
            label1 = new Label();
            Reset_BTN = new Button();
            Apply_BTN = new Button();
            toolTip1 = new ToolTip(components);
            label4 = new Label();
            EnhancedPrecision_L = new Label();
            Plans_BTN = new Button();
            Services_BTN = new Button();
            label10 = new Label();
            label8 = new Label();
            label2 = new Label();
            GPUPriority_DD = new ComboBox();
            label6 = new Label();
            EnhancedPrecision_CB = new CheckBox();
            label9 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // Optimization_LBL
            // 
            Optimization_LBL.AutoSize = true;
            Optimization_LBL.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold);
            Optimization_LBL.ForeColor = SystemColors.ActiveCaptionText;
            Optimization_LBL.Location = new Point(199, 40);
            Optimization_LBL.Name = "Optimization_LBL";
            Optimization_LBL.Size = new Size(302, 50);
            Optimization_LBL.TabIndex = 2;
            Optimization_LBL.Text = "PERFORMANCE";
            Optimization_LBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 125);
            label5.Name = "label5";
            label5.Size = new Size(265, 38);
            label5.TabIndex = 13;
            label5.Text = "Throttling Settings";
            // 
            // PThrottling_CB
            // 
            PThrottling_CB.BackColor = Color.Transparent;
            PThrottling_CB.Checked = true;
            PThrottling_CB.CheckState = CheckState.Checked;
            PThrottling_CB.FlatStyle = FlatStyle.System;
            PThrottling_CB.Location = new Point(152, 221);
            PThrottling_CB.Name = "PThrottling_CB";
            PThrottling_CB.Size = new Size(16, 16);
            PThrottling_CB.TabIndex = 15;
            PThrottling_CB.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(50, 180);
            label3.Name = "label3";
            label3.Size = new Size(222, 38);
            label3.TabIndex = 14;
            label3.Text = "Power Throttling";
            toolTip1.SetToolTip(label3, "Windows limiting the power used by your system.\r\n-WINDOWS 10 & 11");
            // 
            // NThrottling_CB
            // 
            NThrottling_CB.BackColor = Color.Transparent;
            NThrottling_CB.Checked = true;
            NThrottling_CB.CheckState = CheckState.Checked;
            NThrottling_CB.FlatStyle = FlatStyle.System;
            NThrottling_CB.Location = new Point(152, 302);
            NThrottling_CB.Name = "NThrottling_CB";
            NThrottling_CB.Size = new Size(16, 16);
            NThrottling_CB.TabIndex = 17;
            NThrottling_CB.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(38, 261);
            label1.Name = "label1";
            label1.Size = new Size(251, 38);
            label1.TabIndex = 16;
            label1.Text = "Network Throttling";
            toolTip1.SetToolTip(label1, "Windows limiting network trafic of your system.\r\n-WINDOWS 10 & 11");
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
            Reset_BTN.TabIndex = 19;
            Reset_BTN.Text = "Reset to default";
            toolTip1.SetToolTip(Reset_BTN, "Reset the tweaks from this tab to Windows default values. (Requires Apply)");
            Reset_BTN.UseVisualStyleBackColor = false;
            Reset_BTN.Click += ResetToDefault;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(382, 180);
            label4.Name = "label4";
            label4.Size = new Size(303, 38);
            label4.TabIndex = 22;
            label4.Text = "GPU Priority for Games";
            toolTip1.SetToolTip(label4, "The priority of your GPU Windows gives to games.\r\n-WINDOWS 10 & 11");
            // 
            // EnhancedPrecision_L
            // 
            EnhancedPrecision_L.AutoSize = true;
            EnhancedPrecision_L.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnhancedPrecision_L.ForeColor = Color.FromArgb(64, 64, 64);
            EnhancedPrecision_L.Location = new Point(35, 431);
            EnhancedPrecision_L.Name = "EnhancedPrecision_L";
            EnhancedPrecision_L.Size = new Size(257, 38);
            EnhancedPrecision_L.TabIndex = 24;
            EnhancedPrecision_L.Text = "Enhanced Precision";
            toolTip1.SetToolTip(EnhancedPrecision_L, "AKA mouse acceleration, bad for gaming.\r\n-WINDOWS 10 & 11");
            // 
            // Plans_BTN
            // 
            Plans_BTN.BackColor = Color.WhiteSmoke;
            Plans_BTN.Cursor = Cursors.Hand;
            Plans_BTN.FlatAppearance.BorderColor = Color.Silver;
            Plans_BTN.FlatAppearance.BorderSize = 2;
            Plans_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            Plans_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            Plans_BTN.FlatStyle = FlatStyle.System;
            Plans_BTN.Font = new Font("Segoe UI Semibold", 13.2F, FontStyle.Bold);
            Plans_BTN.Location = new Point(411, 395);
            Plans_BTN.Name = "Plans_BTN";
            Plans_BTN.Size = new Size(250, 60);
            Plans_BTN.TabIndex = 31;
            Plans_BTN.Text = "See Plans";
            toolTip1.SetToolTip(Plans_BTN, "Administrate power plans of your system.");
            Plans_BTN.UseVisualStyleBackColor = false;
            Plans_BTN.Click += Plans_BTN_Click;
            // 
            // Services_BTN
            // 
            Services_BTN.BackColor = Color.WhiteSmoke;
            Services_BTN.Cursor = Cursors.Hand;
            Services_BTN.FlatAppearance.BorderColor = Color.Silver;
            Services_BTN.FlatAppearance.BorderSize = 2;
            Services_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            Services_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            Services_BTN.FlatStyle = FlatStyle.System;
            Services_BTN.Font = new Font("Segoe UI Semibold", 13.2F, FontStyle.Bold);
            Services_BTN.Location = new Point(411, 524);
            Services_BTN.Name = "Services_BTN";
            Services_BTN.Size = new Size(250, 60);
            Services_BTN.TabIndex = 33;
            Services_BTN.Text = "Optimize Services";
            toolTip1.SetToolTip(Services_BTN, "Set services to manual");
            Services_BTN.UseVisualStyleBackColor = false;
            Services_BTN.Click += Services_BTN_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(386, 483);
            label10.Name = "label10";
            label10.Size = new Size(297, 38);
            label10.TabIndex = 32;
            label10.Text = "Set Services to Manual";
            toolTip1.SetToolTip(label10, resources.GetString("label10.ToolTip"));
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(400, 354);
            label8.Name = "label8";
            label8.Size = new Size(270, 38);
            label8.TabIndex = 29;
            label8.Text = "System Performance";
            toolTip1.SetToolTip(label8, "The overall system performance.\r\n-WINDOWS 10 & 11");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(442, 125);
            label2.Name = "label2";
            label2.Size = new Size(189, 38);
            label2.TabIndex = 20;
            label2.Text = "GPU Settings";
            // 
            // GPUPriority_DD
            // 
            GPUPriority_DD.BackColor = Color.Silver;
            GPUPriority_DD.DropDownStyle = ComboBoxStyle.DropDownList;
            GPUPriority_DD.FlatStyle = FlatStyle.System;
            GPUPriority_DD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GPUPriority_DD.ForeColor = Color.Black;
            GPUPriority_DD.FormattingEnabled = true;
            GPUPriority_DD.IntegralHeight = false;
            GPUPriority_DD.Items.AddRange(new object[] { "High", "Normal (Default)" });
            GPUPriority_DD.Location = new Point(444, 221);
            GPUPriority_DD.Name = "GPUPriority_DD";
            GPUPriority_DD.Size = new Size(180, 36);
            GPUPriority_DD.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(53, 370);
            label6.Name = "label6";
            label6.Size = new Size(220, 38);
            label6.TabIndex = 23;
            label6.Text = "Mouse Settings";
            // 
            // EnhancedPrecision_CB
            // 
            EnhancedPrecision_CB.BackColor = Color.Transparent;
            EnhancedPrecision_CB.Checked = true;
            EnhancedPrecision_CB.CheckState = CheckState.Checked;
            EnhancedPrecision_CB.FlatStyle = FlatStyle.System;
            EnhancedPrecision_CB.Location = new Point(152, 475);
            EnhancedPrecision_CB.Name = "EnhancedPrecision_CB";
            EnhancedPrecision_CB.Size = new Size(16, 16);
            EnhancedPrecision_CB.TabIndex = 25;
            EnhancedPrecision_CB.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(382, 301);
            label9.Name = "label9";
            label9.Size = new Size(306, 38);
            label9.TabIndex = 30;
            label9.Text = "Power && Performance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(273, 15);
            label7.Name = "label7";
            label7.Size = new Size(155, 25);
            label7.TabIndex = 48;
            label7.Text = "Windows 10 && 11";
            // 
            // Optimization
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(label7);
            Controls.Add(Services_BTN);
            Controls.Add(label10);
            Controls.Add(Plans_BTN);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(EnhancedPrecision_CB);
            Controls.Add(EnhancedPrecision_L);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(GPUPriority_DD);
            Controls.Add(label2);
            Controls.Add(Apply_BTN);
            Controls.Add(NThrottling_CB);
            Controls.Add(label1);
            Controls.Add(PThrottling_CB);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(Optimization_LBL);
            Controls.Add(Reset_BTN);
            Margin = new Padding(0);
            MaximumSize = new Size(700, 700);
            MinimumSize = new Size(700, 700);
            Name = "Optimization";
            Size = new Size(700, 700);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Optimization_LBL;
        private Label label5;
        private CheckBox PThrottling_CB;
        private Label label3;
        private CheckBox NThrottling_CB;
        private Label label1;
        private Button Reset_BTN;
        private Button Apply_BTN;
        private ToolTip toolTip1;
        private Label label2;
        private Label label4;
        private ComboBox GPUPriority_DD;
        private Label label6;
        private CheckBox EnhancedPrecision_CB;
        private Label EnhancedPrecision_L;
        private Label label8;
        private Label label9;
        private Button Plans_BTN;
        private Button Services_BTN;
        private Label label10;
        private Label label7;
    }
}
