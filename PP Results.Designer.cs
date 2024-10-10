namespace Win_Tweaker
{
    partial class PP_Results
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
            PPResults_LBL = new Label();
            PPResults_RTB = new RichTextBox();
            Close_BTN = new Button();
            Check_BTN = new Button();
            Apply_BTN = new Button();
            InputPlan_TB = new TextBox();
            label8 = new Label();
            toolTip1 = new ToolTip(components);
            Delete_BTN = new Button();
            PSaving_BTN = new Button();
            Balanced_BTN = new Button();
            HPerformance_BTN = new Button();
            UltraHighPerformance_BTN = new Button();
            label1 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // PPResults_LBL
            // 
            PPResults_LBL.AutoSize = true;
            PPResults_LBL.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold);
            PPResults_LBL.ForeColor = SystemColors.ActiveCaptionText;
            PPResults_LBL.Location = new Point(267, 37);
            PPResults_LBL.Name = "PPResults_LBL";
            PPResults_LBL.Size = new Size(401, 50);
            PPResults_LBL.TabIndex = 2;
            PPResults_LBL.Text = "Manage Power Plans";
            // 
            // PPResults_RTB
            // 
            PPResults_RTB.BackColor = Color.LightGray;
            PPResults_RTB.BorderStyle = BorderStyle.None;
            PPResults_RTB.Font = new Font("Segoe UI", 12F);
            PPResults_RTB.Location = new Point(161, 113);
            PPResults_RTB.Name = "PPResults_RTB";
            PPResults_RTB.ReadOnly = true;
            PPResults_RTB.Size = new Size(760, 501);
            PPResults_RTB.TabIndex = 3;
            PPResults_RTB.Text = "";
            // 
            // Close_BTN
            // 
            Close_BTN.BackColor = Color.WhiteSmoke;
            Close_BTN.Cursor = Cursors.Hand;
            Close_BTN.FlatAppearance.BorderColor = Color.Silver;
            Close_BTN.FlatAppearance.BorderSize = 2;
            Close_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            Close_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            Close_BTN.FlatStyle = FlatStyle.System;
            Close_BTN.Font = new Font("Segoe UI Semibold", 19.2F, FontStyle.Bold);
            Close_BTN.Location = new Point(788, 637);
            Close_BTN.Name = "Close_BTN";
            Close_BTN.Size = new Size(133, 107);
            Close_BTN.TabIndex = 19;
            Close_BTN.Text = "Close";
            toolTip1.SetToolTip(Close_BTN, "Return");
            Close_BTN.UseVisualStyleBackColor = false;
            Close_BTN.Click += Close_BTN_Click;
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
            Check_BTN.Location = new Point(527, 637);
            Check_BTN.Name = "Check_BTN";
            Check_BTN.Size = new Size(255, 107);
            Check_BTN.TabIndex = 20;
            Check_BTN.Text = "Check";
            toolTip1.SetToolTip(Check_BTN, "Check the current PowerPlans as well as the active one and get its GUIDs.\r\n-WINDOWS 10 & 11");
            Check_BTN.UseVisualStyleBackColor = false;
            Check_BTN.Click += Check_BTN_Click;
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
            Apply_BTN.Location = new Point(19, 637);
            Apply_BTN.Name = "Apply_BTN";
            Apply_BTN.Size = new Size(216, 64);
            Apply_BTN.TabIndex = 21;
            Apply_BTN.Text = "Activate";
            toolTip1.SetToolTip(Apply_BTN, "Activate a PowerPlan with its corresponding GUID placed below.\r\n-WINDOWS 10 & 11");
            Apply_BTN.UseVisualStyleBackColor = false;
            Apply_BTN.Click += Apply_BTN_Click;
            // 
            // InputPlan_TB
            // 
            InputPlan_TB.BackColor = Color.Gainsboro;
            InputPlan_TB.Font = new Font("Segoe UI", 11F);
            InputPlan_TB.Location = new Point(107, 712);
            InputPlan_TB.Name = "InputPlan_TB";
            InputPlan_TB.Size = new Size(401, 32);
            InputPlan_TB.TabIndex = 22;
            toolTip1.SetToolTip(InputPlan_TB, "Place GUID here...");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.2F);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(19, 709);
            label8.Name = "label8";
            label8.Size = new Size(82, 36);
            label8.TabIndex = 30;
            label8.Text = "GUID:";
            // 
            // Delete_BTN
            // 
            Delete_BTN.BackColor = Color.WhiteSmoke;
            Delete_BTN.Cursor = Cursors.Hand;
            Delete_BTN.FlatAppearance.BorderColor = Color.Silver;
            Delete_BTN.FlatAppearance.BorderSize = 2;
            Delete_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            Delete_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            Delete_BTN.FlatStyle = FlatStyle.System;
            Delete_BTN.Font = new Font("Segoe UI Semibold", 19.2F, FontStyle.Bold);
            Delete_BTN.Location = new Point(283, 637);
            Delete_BTN.Name = "Delete_BTN";
            Delete_BTN.Size = new Size(224, 64);
            Delete_BTN.TabIndex = 36;
            Delete_BTN.Text = "Delete";
            toolTip1.SetToolTip(Delete_BTN, "Delete a PowerPlan with its corresponding GUID placed below.\r\n-WINDOWS 10 & 11\r\n\r\nWARNING: This will delete the PowerPlan instantly.");
            Delete_BTN.UseVisualStyleBackColor = false;
            Delete_BTN.Click += Delete_BTN_Click;
            // 
            // PSaving_BTN
            // 
            PSaving_BTN.BackColor = Color.WhiteSmoke;
            PSaving_BTN.Cursor = Cursors.Hand;
            PSaving_BTN.FlatAppearance.BorderColor = Color.ForestGreen;
            PSaving_BTN.FlatAppearance.BorderSize = 2;
            PSaving_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            PSaving_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            PSaving_BTN.FlatStyle = FlatStyle.Flat;
            PSaving_BTN.Font = new Font("Segoe UI", 12F);
            PSaving_BTN.Location = new Point(11, 191);
            PSaving_BTN.Name = "PSaving_BTN";
            PSaving_BTN.Size = new Size(134, 83);
            PSaving_BTN.TabIndex = 31;
            PSaving_BTN.Text = "Power Saving";
            toolTip1.SetToolTip(PSaving_BTN, "Coming soon...");
            PSaving_BTN.UseVisualStyleBackColor = false;
            PSaving_BTN.Click += PSaving_BTN_Click;
            // 
            // Balanced_BTN
            // 
            Balanced_BTN.BackColor = Color.WhiteSmoke;
            Balanced_BTN.Cursor = Cursors.Hand;
            Balanced_BTN.FlatAppearance.BorderColor = Color.Olive;
            Balanced_BTN.FlatAppearance.BorderSize = 2;
            Balanced_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            Balanced_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            Balanced_BTN.FlatStyle = FlatStyle.Flat;
            Balanced_BTN.Font = new Font("Segoe UI", 12F);
            Balanced_BTN.Location = new Point(11, 289);
            Balanced_BTN.Name = "Balanced_BTN";
            Balanced_BTN.Size = new Size(134, 83);
            Balanced_BTN.TabIndex = 32;
            Balanced_BTN.Text = "Balanced";
            toolTip1.SetToolTip(Balanced_BTN, "Coming soon...");
            Balanced_BTN.UseVisualStyleBackColor = false;
            Balanced_BTN.Click += Balanced_BTN_Click;
            // 
            // HPerformance_BTN
            // 
            HPerformance_BTN.BackColor = Color.WhiteSmoke;
            HPerformance_BTN.Cursor = Cursors.Hand;
            HPerformance_BTN.FlatAppearance.BorderColor = Color.IndianRed;
            HPerformance_BTN.FlatAppearance.BorderSize = 2;
            HPerformance_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            HPerformance_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            HPerformance_BTN.FlatStyle = FlatStyle.Flat;
            HPerformance_BTN.Font = new Font("Segoe UI", 12F);
            HPerformance_BTN.Location = new Point(11, 389);
            HPerformance_BTN.Name = "HPerformance_BTN";
            HPerformance_BTN.Size = new Size(134, 85);
            HPerformance_BTN.TabIndex = 34;
            HPerformance_BTN.Text = "High Performance";
            toolTip1.SetToolTip(HPerformance_BTN, "Coming soon...");
            HPerformance_BTN.UseVisualStyleBackColor = false;
            HPerformance_BTN.Click += HPerformance_BTN_Click;
            // 
            // UltraHighPerformance_BTN
            // 
            UltraHighPerformance_BTN.BackColor = Color.WhiteSmoke;
            UltraHighPerformance_BTN.Cursor = Cursors.Hand;
            UltraHighPerformance_BTN.FlatAppearance.BorderColor = Color.DarkRed;
            UltraHighPerformance_BTN.FlatAppearance.BorderSize = 2;
            UltraHighPerformance_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            UltraHighPerformance_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            UltraHighPerformance_BTN.FlatStyle = FlatStyle.Flat;
            UltraHighPerformance_BTN.Font = new Font("Segoe UI", 12F);
            UltraHighPerformance_BTN.Location = new Point(11, 490);
            UltraHighPerformance_BTN.Name = "UltraHighPerformance_BTN";
            UltraHighPerformance_BTN.Size = new Size(134, 85);
            UltraHighPerformance_BTN.TabIndex = 35;
            UltraHighPerformance_BTN.Text = "Ultra-High Performance";
            toolTip1.SetToolTip(UltraHighPerformance_BTN, "Coming soon...");
            UltraHighPerformance_BTN.UseVisualStyleBackColor = false;
            UltraHighPerformance_BTN.Click += UltraHighPerformance_BTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.2F);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(6, 139);
            label1.Name = "label1";
            label1.Size = new Size(152, 36);
            label1.TabIndex = 33;
            label1.Text = "Create Plan:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(390, 12);
            label13.Name = "label13";
            label13.Size = new Size(155, 25);
            label13.TabIndex = 52;
            label13.Text = "Windows 10 && 11";
            // 
            // PP_Results
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(label13);
            Controls.Add(Delete_BTN);
            Controls.Add(UltraHighPerformance_BTN);
            Controls.Add(HPerformance_BTN);
            Controls.Add(label1);
            Controls.Add(Balanced_BTN);
            Controls.Add(PSaving_BTN);
            Controls.Add(label8);
            Controls.Add(InputPlan_TB);
            Controls.Add(Apply_BTN);
            Controls.Add(Check_BTN);
            Controls.Add(Close_BTN);
            Controls.Add(PPResults_RTB);
            Controls.Add(PPResults_LBL);
            MaximumSize = new Size(935, 760);
            MinimumSize = new Size(935, 760);
            Name = "PP_Results";
            Size = new Size(935, 760);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PPResults_LBL;
        private RichTextBox PPResults_RTB;
        private Button Close_BTN;
        private Button Check_BTN;
        private Button Apply_BTN;
        private TextBox InputPlan_TB;
        private Label label8;
        private ToolTip toolTip1;
        private Button PSaving_BTN;
        private Button Balanced_BTN;
        private Label label1;
        private Button HPerformance_BTN;
        private Button UltraHighPerformance_BTN;
        private Button Delete_BTN;
        private Label label13;
    }
}
