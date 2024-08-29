namespace Win_Tweaker
{
    partial class Security_2
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
            label2 = new Label();
            label1 = new Label();
            RDSett_BTN = new Button();
            RRRDServices_BTN = new Button();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            Next_BTN = new Button();
            Previous_BTN = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // Personalization_LBL
            // 
            Personalization_LBL.AutoSize = true;
            Personalization_LBL.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold);
            Personalization_LBL.ForeColor = SystemColors.ActiveCaptionText;
            Personalization_LBL.Location = new Point(251, 40);
            Personalization_LBL.Name = "Personalization_LBL";
            Personalization_LBL.Size = new Size(199, 50);
            Personalization_LBL.TabIndex = 17;
            Personalization_LBL.Text = "SECURITY";
            Personalization_LBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.2F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(10, 144);
            label2.Name = "label2";
            label2.Size = new Size(681, 102);
            label2.TabIndex = 20;
            label2.Text = "Disable Remote Desktop and Remote Registry.This are a big security risk as anyone can access your computer remotely.\r\nNote: On Windows Home Edition is not possible to turn it on.\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(300, 90);
            label1.Name = "label1";
            label1.Size = new Size(100, 38);
            label1.TabIndex = 19;
            label1.Text = "Page 2";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RDSett_BTN
            // 
            RDSett_BTN.BackColor = Color.WhiteSmoke;
            RDSett_BTN.Cursor = Cursors.Hand;
            RDSett_BTN.FlatAppearance.BorderColor = Color.Silver;
            RDSett_BTN.FlatAppearance.BorderSize = 2;
            RDSett_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            RDSett_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            RDSett_BTN.FlatStyle = FlatStyle.System;
            RDSett_BTN.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RDSett_BTN.Location = new Point(10, 487);
            RDSett_BTN.Name = "RDSett_BTN";
            RDSett_BTN.Size = new Size(262, 120);
            RDSett_BTN.TabIndex = 23;
            RDSett_BTN.Text = "Remote Desktop Settings";
            RDSett_BTN.UseVisualStyleBackColor = false;
            RDSett_BTN.Click += RDSett_BTN_Click;
            // 
            // RRRDServices_BTN
            // 
            RRRDServices_BTN.BackColor = Color.WhiteSmoke;
            RRRDServices_BTN.Cursor = Cursors.Hand;
            RRRDServices_BTN.FlatAppearance.BorderColor = Color.Silver;
            RRRDServices_BTN.FlatAppearance.BorderSize = 2;
            RRRDServices_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            RRRDServices_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            RRRDServices_BTN.FlatStyle = FlatStyle.System;
            RRRDServices_BTN.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RRRDServices_BTN.Location = new Point(429, 487);
            RRRDServices_BTN.Name = "RRRDServices_BTN";
            RRRDServices_BTN.Size = new Size(262, 120);
            RRRDServices_BTN.TabIndex = 24;
            RRRDServices_BTN.Text = "Disable Remote Reg. and Remote Desk. Services";
            toolTip1.SetToolTip(RRRDServices_BTN, "Disable the services responsible for the Remote Registry function and Remote Desktop");
            RRRDServices_BTN.UseVisualStyleBackColor = false;
            RRRDServices_BTN.Click += RRRDServices_BTN_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(95, 246);
            label4.Name = "label4";
            label4.Size = new Size(92, 38);
            label4.TabIndex = 26;
            label4.Text = "Step 1";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.2F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(10, 289);
            label3.Name = "label3";
            label3.Size = new Size(264, 195);
            label3.TabIndex = 25;
            label3.Text = "Make sure Remote Desktop is turned off.\r\nBUTTON BELOW";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(510, 246);
            label5.Name = "label5";
            label5.Size = new Size(97, 38);
            label5.TabIndex = 28;
            label5.Text = "Step 2";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14.2F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(427, 289);
            label6.Name = "label6";
            label6.Size = new Size(264, 195);
            label6.TabIndex = 27;
            label6.Text = "For an extra security Disable Remote Registry and Disable Remote Desktop Services from running.\r\nBUTTON BELOW";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Next_BTN
            // 
            Next_BTN.BackColor = Color.WhiteSmoke;
            Next_BTN.Cursor = Cursors.Hand;
            Next_BTN.FlatAppearance.BorderColor = Color.Silver;
            Next_BTN.FlatAppearance.BorderSize = 2;
            Next_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            Next_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            Next_BTN.FlatStyle = FlatStyle.System;
            Next_BTN.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Next_BTN.Location = new Point(535, 622);
            Next_BTN.Name = "Next_BTN";
            Next_BTN.Size = new Size(159, 72);
            Next_BTN.TabIndex = 29;
            Next_BTN.Text = "------>";
            Next_BTN.UseVisualStyleBackColor = false;
            Next_BTN.Click += Next_BTN_Click;
            // 
            // Previous_BTN
            // 
            Previous_BTN.BackColor = Color.WhiteSmoke;
            Previous_BTN.Cursor = Cursors.Hand;
            Previous_BTN.FlatAppearance.BorderColor = Color.Silver;
            Previous_BTN.FlatAppearance.BorderSize = 2;
            Previous_BTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            Previous_BTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            Previous_BTN.FlatStyle = FlatStyle.System;
            Previous_BTN.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Previous_BTN.Location = new Point(6, 619);
            Previous_BTN.Name = "Previous_BTN";
            Previous_BTN.Size = new Size(159, 75);
            Previous_BTN.TabIndex = 30;
            Previous_BTN.Text = "<------";
            Previous_BTN.UseVisualStyleBackColor = false;
            Previous_BTN.Click += Previous_BTN_Click;
            // 
            // Security_2
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(Previous_BTN);
            Controls.Add(Next_BTN);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(RRRDServices_BTN);
            Controls.Add(RDSett_BTN);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Personalization_LBL);
            Font = new Font("Segoe UI", 19F);
            Margin = new Padding(0);
            MaximumSize = new Size(700, 700);
            MinimumSize = new Size(700, 700);
            Name = "Security_2";
            Size = new Size(700, 700);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Personalization_LBL;
        private Label label2;
        private Label label1;
        private Button RDSett_BTN;
        private Button RRRDServices_BTN;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button Next_BTN;
        private Button Previous_BTN;
        private ToolTip toolTip1;
    }
}
