namespace Win_Tweaker
{
    partial class Features
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Features));
            Features_LBL = new Label();
            CM_DDM = new ComboBox();
            label8 = new Label();
            PV_DDM = new ComboBox();
            label1 = new Label();
            VL_DDM = new ComboBox();
            label2 = new Label();
            Reset_BTN = new Button();
            Apply_BTN = new Button();
            toolTip1 = new ToolTip(components);
            UninstallApp_DD = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            ExplorerRibbon_DDM = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // Features_LBL
            // 
            Features_LBL.AutoSize = true;
            Features_LBL.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold);
            Features_LBL.ForeColor = SystemColors.ActiveCaptionText;
            Features_LBL.Location = new Point(247, 40);
            Features_LBL.Name = "Features_LBL";
            Features_LBL.Size = new Size(207, 50);
            Features_LBL.TabIndex = 16;
            Features_LBL.Text = "FEATURES";
            Features_LBL.TextAlign = ContentAlignment.BottomLeft;
            // 
            // CM_DDM
            // 
            CM_DDM.BackColor = Color.Silver;
            CM_DDM.DropDownStyle = ComboBoxStyle.DropDownList;
            CM_DDM.FlatStyle = FlatStyle.System;
            CM_DDM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CM_DDM.ForeColor = Color.Black;
            CM_DDM.FormattingEnabled = true;
            CM_DDM.IntegralHeight = false;
            CM_DDM.Items.AddRange(new object[] { "Enable", "Disable" });
            CM_DDM.Location = new Point(75, 163);
            CM_DDM.Name = "CM_DDM";
            CM_DDM.Size = new Size(166, 36);
            CM_DDM.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(39, 122);
            label8.Name = "label8";
            label8.Size = new Size(244, 38);
            label8.TabIndex = 35;
            label8.Text = "Old Context Menu";
            toolTip1.SetToolTip(label8, "Enable Windows 10 context menu for Windows 11.\r\n-WINDOWS 11 ONLY");
            // 
            // PV_DDM
            // 
            PV_DDM.BackColor = Color.Silver;
            PV_DDM.DropDownStyle = ComboBoxStyle.DropDownList;
            PV_DDM.FlatStyle = FlatStyle.System;
            PV_DDM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PV_DDM.ForeColor = Color.Black;
            PV_DDM.FormattingEnabled = true;
            PV_DDM.IntegralHeight = false;
            PV_DDM.Items.AddRange(new object[] { "Enable", "Disable" });
            PV_DDM.Location = new Point(460, 163);
            PV_DDM.Name = "PV_DDM";
            PV_DDM.Size = new Size(166, 36);
            PV_DDM.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(424, 122);
            label1.Name = "label1";
            label1.Size = new Size(234, 38);
            label1.TabIndex = 37;
            label1.Text = "Old Photo Viewer";
            toolTip1.SetToolTip(label1, "Coming soon....");
            // 
            // VL_DDM
            // 
            VL_DDM.BackColor = Color.Silver;
            VL_DDM.DropDownStyle = ComboBoxStyle.DropDownList;
            VL_DDM.FlatStyle = FlatStyle.System;
            VL_DDM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VL_DDM.ForeColor = Color.Black;
            VL_DDM.FormattingEnabled = true;
            VL_DDM.IntegralHeight = false;
            VL_DDM.Items.AddRange(new object[] { "Enable", "Disable" });
            VL_DDM.Location = new Point(460, 298);
            VL_DDM.Name = "VL_DDM";
            VL_DDM.Size = new Size(166, 36);
            VL_DDM.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(418, 257);
            label2.Name = "label2";
            label2.Size = new Size(252, 38);
            label2.TabIndex = 39;
            label2.Text = "Old Volume Layout";
            toolTip1.SetToolTip(label2, "Enable the Windows 7 volume layout style for Windows 10.\r\n-WINDOWS 10 ONLY");
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
            Reset_BTN.TabIndex = 42;
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
            Apply_BTN.TabIndex = 41;
            Apply_BTN.Text = "Apply";
            toolTip1.SetToolTip(Apply_BTN, "Run the tweaks found on the current tab.");
            Apply_BTN.UseVisualStyleBackColor = false;
            Apply_BTN.Click += Apply_BTN_Click;
            // 
            // UninstallApp_DD
            // 
            UninstallApp_DD.BackColor = Color.Silver;
            UninstallApp_DD.DropDownStyle = ComboBoxStyle.DropDownList;
            UninstallApp_DD.FlatStyle = FlatStyle.System;
            UninstallApp_DD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UninstallApp_DD.ForeColor = Color.Black;
            UninstallApp_DD.FormattingEnabled = true;
            UninstallApp_DD.IntegralHeight = false;
            UninstallApp_DD.Items.AddRange(new object[] { "Your Phone/Phone Link", "OneDrive", "Get Started & Tips", "Get Help", "People" });
            UninstallApp_DD.Location = new Point(188, 556);
            UninstallApp_DD.Name = "UninstallApp_DD";
            UninstallApp_DD.Size = new Size(325, 36);
            UninstallApp_DD.TabIndex = 44;
            toolTip1.SetToolTip(UninstallApp_DD, "Coming soon...");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(128, 516);
            label3.Name = "label3";
            label3.Size = new Size(445, 38);
            label3.TabIndex = 43;
            label3.Text = "Uninstall a Windows App/Package ";
            toolTip1.SetToolTip(label3, "Uninstall a Windows Package from Windows.\r\n-WINDOWS 10 & 11");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(8, 257);
            label4.Name = "label4";
            label4.Size = new Size(301, 38);
            label4.TabIndex = 45;
            label4.Text = "Win10 Explorer Ribbon";
            toolTip1.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            // 
            // ExplorerRibbon_DDM
            // 
            ExplorerRibbon_DDM.BackColor = Color.Silver;
            ExplorerRibbon_DDM.DropDownStyle = ComboBoxStyle.DropDownList;
            ExplorerRibbon_DDM.FlatStyle = FlatStyle.System;
            ExplorerRibbon_DDM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExplorerRibbon_DDM.ForeColor = Color.Black;
            ExplorerRibbon_DDM.FormattingEnabled = true;
            ExplorerRibbon_DDM.IntegralHeight = false;
            ExplorerRibbon_DDM.Items.AddRange(new object[] { "Add (Normal Window)", "Add (Maximized Window)" });
            ExplorerRibbon_DDM.Location = new Point(8, 298);
            ExplorerRibbon_DDM.Name = "ExplorerRibbon_DDM";
            ExplorerRibbon_DDM.Size = new Size(301, 36);
            ExplorerRibbon_DDM.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(487, 337);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 47;
            label5.Text = "Windows 10";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(104, 337);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 48;
            label6.Text = "Windows 11";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(104, 202);
            label7.Name = "label7";
            label7.Size = new Size(111, 25);
            label7.TabIndex = 49;
            label7.Text = "Windows 11";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(467, 202);
            label9.Name = "label9";
            label9.Size = new Size(155, 25);
            label9.TabIndex = 50;
            label9.Text = "Windows 10 && 11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(273, 595);
            label10.Name = "label10";
            label10.Size = new Size(155, 25);
            label10.TabIndex = 51;
            label10.Text = "Windows 10 && 11";
            // 
            // Features
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(ExplorerRibbon_DDM);
            Controls.Add(label4);
            Controls.Add(UninstallApp_DD);
            Controls.Add(label3);
            Controls.Add(Reset_BTN);
            Controls.Add(Apply_BTN);
            Controls.Add(VL_DDM);
            Controls.Add(label2);
            Controls.Add(PV_DDM);
            Controls.Add(label1);
            Controls.Add(CM_DDM);
            Controls.Add(label8);
            Controls.Add(Features_LBL);
            Margin = new Padding(0);
            MaximumSize = new Size(700, 700);
            MinimumSize = new Size(700, 700);
            Name = "Features";
            Size = new Size(700, 700);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Features_LBL;
        private ComboBox CM_DDM;
        private Label label8;
        private ComboBox PV_DDM;
        private Label label1;
        private ComboBox VL_DDM;
        private Label label2;
        private Button Reset_BTN;
        private Button Apply_BTN;
        private ToolTip toolTip1;
        private ComboBox UninstallApp_DD;
        private Label label3;
        private ComboBox ExplorerRibbon_DDM;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
    }
}
