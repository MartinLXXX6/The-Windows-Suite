namespace Win_Tweaker
{
    partial class ShortcutMessageBox
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
            OK_BTN = new Button();
            Optimization_LBL = new Label();
            DontSA_CB = new CheckBox();
            EnhancedPrecision_L = new Label();
            DesktopShort_CB = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            appShort_CB = new CheckBox();
            SuspendLayout();
            // 
            // OK_BTN
            // 
            OK_BTN.BackColor = Color.WhiteSmoke;
            OK_BTN.Cursor = Cursors.Hand;
            OK_BTN.FlatAppearance.BorderColor = Color.Silver;
            OK_BTN.FlatAppearance.BorderSize = 2;
            OK_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            OK_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            OK_BTN.FlatStyle = FlatStyle.System;
            OK_BTN.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OK_BTN.ForeColor = Color.Black;
            OK_BTN.ImageAlign = ContentAlignment.MiddleLeft;
            OK_BTN.Location = new Point(288, 363);
            OK_BTN.Name = "OK_BTN";
            OK_BTN.Size = new Size(501, 75);
            OK_BTN.TabIndex = 3;
            OK_BTN.Text = "OK";
            OK_BTN.UseVisualStyleBackColor = false;
            OK_BTN.Click += OK_BTN_Click;
            // 
            // Optimization_LBL
            // 
            Optimization_LBL.AutoSize = true;
            Optimization_LBL.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold);
            Optimization_LBL.ForeColor = SystemColors.ActiveCaptionText;
            Optimization_LBL.Location = new Point(187, 15);
            Optimization_LBL.Name = "Optimization_LBL";
            Optimization_LBL.Size = new Size(425, 50);
            Optimization_LBL.TabIndex = 5;
            Optimization_LBL.Text = "MANAGE SHORTCUTS";
            Optimization_LBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DontSA_CB
            // 
            DontSA_CB.BackColor = Color.Transparent;
            DontSA_CB.Checked = true;
            DontSA_CB.CheckState = CheckState.Checked;
            DontSA_CB.FlatStyle = FlatStyle.System;
            DontSA_CB.Location = new Point(139, 412);
            DontSA_CB.Name = "DontSA_CB";
            DontSA_CB.Size = new Size(16, 16);
            DontSA_CB.TabIndex = 27;
            DontSA_CB.UseVisualStyleBackColor = false;
            // 
            // EnhancedPrecision_L
            // 
            EnhancedPrecision_L.AutoSize = true;
            EnhancedPrecision_L.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnhancedPrecision_L.ForeColor = Color.FromArgb(64, 64, 64);
            EnhancedPrecision_L.Location = new Point(9, 371);
            EnhancedPrecision_L.Name = "EnhancedPrecision_L";
            EnhancedPrecision_L.Size = new Size(273, 38);
            EnhancedPrecision_L.TabIndex = 26;
            EnhancedPrecision_L.Text = "DONT SHOW AGAIN";
            // 
            // DesktopShort_CB
            // 
            DesktopShort_CB.BackColor = Color.Transparent;
            DesktopShort_CB.FlatStyle = FlatStyle.System;
            DesktopShort_CB.Location = new Point(552, 179);
            DesktopShort_CB.Name = "DesktopShort_CB";
            DesktopShort_CB.Size = new Size(16, 16);
            DesktopShort_CB.TabIndex = 28;
            DesktopShort_CB.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(233, 165);
            label1.Name = "label1";
            label1.Size = new Size(312, 38);
            label1.TabIndex = 29;
            label1.Text = "Create desktop shortcut";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(129, 247);
            label2.Name = "label2";
            label2.Size = new Size(519, 38);
            label2.TabIndex = 31;
            label2.Text = "Create apps list shortcut (recommended)";
            // 
            // appShort_CB
            // 
            appShort_CB.BackColor = Color.Transparent;
            appShort_CB.Checked = true;
            appShort_CB.CheckState = CheckState.Checked;
            appShort_CB.FlatStyle = FlatStyle.System;
            appShort_CB.Location = new Point(655, 261);
            appShort_CB.Name = "appShort_CB";
            appShort_CB.Size = new Size(16, 16);
            appShort_CB.TabIndex = 30;
            appShort_CB.UseVisualStyleBackColor = false;
            // 
            // ShortcutMessageBox
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(label2);
            Controls.Add(appShort_CB);
            Controls.Add(label1);
            Controls.Add(DesktopShort_CB);
            Controls.Add(DontSA_CB);
            Controls.Add(EnhancedPrecision_L);
            Controls.Add(Optimization_LBL);
            Controls.Add(OK_BTN);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShortcutMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WARNING";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button OK_BTN;
        private Label Optimization_LBL;
        private CheckBox DontSA_CB;
        private Label EnhancedPrecision_L;
        private CheckBox DesktopShort_CB;
        private Label label1;
        private Label label2;
        private CheckBox appShort_CB;
    }
}