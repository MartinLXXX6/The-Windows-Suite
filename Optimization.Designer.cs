﻿namespace Win_Tweaker
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
            label7 = new Label();
            Plans_BTN = new Button();
            label2 = new Label();
            GPUPriority_DD = new ComboBox();
            label6 = new Label();
            EnhancedPrecision_CB = new CheckBox();
            ReduceHoverTime_CB = new CheckBox();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // Optimization_LBL
            // 
            Optimization_LBL.AutoSize = true;
            Optimization_LBL.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold);
            Optimization_LBL.ForeColor = SystemColors.ActiveCaptionText;
            Optimization_LBL.Location = new Point(283, 40);
            Optimization_LBL.Name = "Optimization_LBL";
            Optimization_LBL.Size = new Size(184, 50);
            Optimization_LBL.TabIndex = 2;
            Optimization_LBL.Text = "GAMING";
            Optimization_LBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(72, 147);
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
            PThrottling_CB.Location = new Point(198, 261);
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
            label3.Location = new Point(92, 220);
            label3.Name = "label3";
            label3.Size = new Size(222, 38);
            label3.TabIndex = 14;
            label3.Text = "Power Throttling";
            toolTip1.SetToolTip(label3, "Windows limits the power used by your system");
            // 
            // NThrottling_CB
            // 
            NThrottling_CB.BackColor = Color.Transparent;
            NThrottling_CB.Checked = true;
            NThrottling_CB.CheckState = CheckState.Checked;
            NThrottling_CB.Location = new Point(198, 362);
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
            label1.Location = new Point(83, 321);
            label1.Name = "label1";
            label1.Size = new Size(251, 38);
            label1.TabIndex = 16;
            label1.Text = "Network Throttling";
            toolTip1.SetToolTip(label1, "Windows limits network used by the system");
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
            Reset_BTN.TabIndex = 19;
            Reset_BTN.Text = "Reset to default";
            toolTip1.SetToolTip(Reset_BTN, "Reset the Optimization tweaks to Windows default values. (Requires Apply)");
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
            Apply_BTN.FlatStyle = FlatStyle.Flat;
            Apply_BTN.Font = new Font("Segoe UI Semibold", 19.2F, FontStyle.Bold);
            Apply_BTN.Location = new Point(10, 716);
            Apply_BTN.Name = "Apply_BTN";
            Apply_BTN.Size = new Size(358, 75);
            Apply_BTN.TabIndex = 18;
            Apply_BTN.Text = "Apply";
            toolTip1.SetToolTip(Apply_BTN, "Run tweaks");
            Apply_BTN.UseVisualStyleBackColor = false;
            Apply_BTN.Click += Apply_BTN_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(417, 220);
            label4.Name = "label4";
            label4.Size = new Size(303, 38);
            label4.TabIndex = 22;
            label4.Text = "GPU Priority for Games";
            toolTip1.SetToolTip(label4, "GPU priority for games");
            // 
            // EnhancedPrecision_L
            // 
            EnhancedPrecision_L.AutoSize = true;
            EnhancedPrecision_L.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnhancedPrecision_L.ForeColor = Color.FromArgb(64, 64, 64);
            EnhancedPrecision_L.Location = new Point(431, 425);
            EnhancedPrecision_L.Name = "EnhancedPrecision_L";
            EnhancedPrecision_L.Size = new Size(257, 38);
            EnhancedPrecision_L.TabIndex = 24;
            EnhancedPrecision_L.Text = "Enhanced Precision";
            toolTip1.SetToolTip(EnhancedPrecision_L, "AKA mouse acceleration");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(431, 528);
            label7.Name = "label7";
            label7.Size = new Size(259, 38);
            label7.TabIndex = 26;
            label7.Text = "Reduce Hover Time";
            toolTip1.SetToolTip(label7, "Change Windows experiance by reducing time needed to hover over Windows UI items");
            // 
            // Plans_BTN
            // 
            Plans_BTN.BackColor = Color.WhiteSmoke;
            Plans_BTN.Cursor = Cursors.Hand;
            Plans_BTN.FlatAppearance.BorderColor = Color.Silver;
            Plans_BTN.FlatAppearance.BorderSize = 2;
            Plans_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            Plans_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            Plans_BTN.FlatStyle = FlatStyle.Flat;
            Plans_BTN.Font = new Font("Segoe UI Semibold", 13.2F, FontStyle.Bold);
            Plans_BTN.Location = new Point(125, 545);
            Plans_BTN.Name = "Plans_BTN";
            Plans_BTN.Size = new Size(156, 42);
            Plans_BTN.TabIndex = 31;
            Plans_BTN.Text = "See Plans";
            toolTip1.SetToolTip(Plans_BTN, "Administrate power plans for your system");
            Plans_BTN.UseVisualStyleBackColor = false;
            Plans_BTN.Click += Plans_BTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(471, 147);
            label2.Name = "label2";
            label2.Size = new Size(189, 38);
            label2.TabIndex = 20;
            label2.Text = "GPU Settings";
            // 
            // GPUPriority_DD
            // 
            GPUPriority_DD.BackColor = Color.Silver;
            GPUPriority_DD.DropDownStyle = ComboBoxStyle.DropDownList;
            GPUPriority_DD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GPUPriority_DD.ForeColor = Color.Black;
            GPUPriority_DD.FormattingEnabled = true;
            GPUPriority_DD.IntegralHeight = false;
            GPUPriority_DD.Items.AddRange(new object[] { "High", "Normal (Default)" });
            GPUPriority_DD.Location = new Point(475, 261);
            GPUPriority_DD.Name = "GPUPriority_DD";
            GPUPriority_DD.Size = new Size(180, 36);
            GPUPriority_DD.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(454, 362);
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
            EnhancedPrecision_CB.Location = new Point(553, 468);
            EnhancedPrecision_CB.Name = "EnhancedPrecision_CB";
            EnhancedPrecision_CB.Size = new Size(16, 16);
            EnhancedPrecision_CB.TabIndex = 25;
            EnhancedPrecision_CB.UseVisualStyleBackColor = false;
            // 
            // ReduceHoverTime_CB
            // 
            ReduceHoverTime_CB.BackColor = Color.Transparent;
            ReduceHoverTime_CB.Location = new Point(553, 571);
            ReduceHoverTime_CB.Name = "ReduceHoverTime_CB";
            ReduceHoverTime_CB.Size = new Size(16, 16);
            ReduceHoverTime_CB.TabIndex = 27;
            ReduceHoverTime_CB.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(71, 497);
            label8.Name = "label8";
            label8.Size = new Size(269, 38);
            label8.TabIndex = 29;
            label8.Text = "Overall Performance";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(102, 429);
            label9.Name = "label9";
            label9.Size = new Size(213, 38);
            label9.TabIndex = 30;
            label9.Text = "Power Settings";
            // 
            // Optimization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Plans_BTN);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(ReduceHoverTime_CB);
            Controls.Add(label7);
            Controls.Add(EnhancedPrecision_CB);
            Controls.Add(EnhancedPrecision_L);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(GPUPriority_DD);
            Controls.Add(label2);
            Controls.Add(Reset_BTN);
            Controls.Add(Apply_BTN);
            Controls.Add(NThrottling_CB);
            Controls.Add(label1);
            Controls.Add(PThrottling_CB);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(Optimization_LBL);
            MaximumSize = new Size(750, 800);
            MinimumSize = new Size(750, 800);
            Name = "Optimization";
            Size = new Size(750, 800);
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
        private CheckBox ReduceHoverTime_CB;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button Plans_BTN;
    }
}