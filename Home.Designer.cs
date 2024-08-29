namespace Win_Tweaker
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            Home_LBL = new Label();
            panel5 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel6 = new Panel();
            ReadMe_TXT = new Label();
            label2 = new Label();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // Home_LBL
            // 
            Home_LBL.AutoSize = true;
            Home_LBL.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold);
            Home_LBL.ForeColor = SystemColors.ActiveCaptionText;
            Home_LBL.Location = new Point(282, 40);
            Home_LBL.Name = "Home_LBL";
            Home_LBL.Size = new Size(137, 50);
            Home_LBL.TabIndex = 1;
            Home_LBL.Text = "HOME";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(12, 428);
            panel5.Name = "panel5";
            panel5.Size = new Size(677, 260);
            panel5.TabIndex = 6;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semilight", 12.8F);
            label4.Location = new Point(15, 49);
            label4.Name = "label4";
            label4.Size = new Size(647, 211);
            label4.TabIndex = 12;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(225, 4);
            label3.Name = "label3";
            label3.Size = new Size(226, 45);
            label3.TabIndex = 12;
            label3.Text = "How it works...";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gainsboro;
            panel6.Controls.Add(ReadMe_TXT);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(12, 119);
            panel6.Name = "panel6";
            panel6.Size = new Size(677, 303);
            panel6.TabIndex = 7;
            // 
            // ReadMe_TXT
            // 
            ReadMe_TXT.Font = new Font("Segoe UI Semilight", 14.8F);
            ReadMe_TXT.Location = new Point(10, 48);
            ReadMe_TXT.Name = "ReadMe_TXT";
            ReadMe_TXT.Size = new Size(656, 255);
            ReadMe_TXT.TabIndex = 11;
            ReadMe_TXT.Text = resources.GetString("ReadMe_TXT.Text");
            ReadMe_TXT.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(213, 3);
            label2.Name = "label2";
            label2.Size = new Size(250, 45);
            label2.TabIndex = 10;
            label2.Text = "Read before use";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(Home_LBL);
            Font = new Font("Segoe UI", 19F);
            Margin = new Padding(0);
            MaximumSize = new Size(700, 700);
            MinimumSize = new Size(700, 700);
            Name = "Home";
            Size = new Size(700, 700);
            Load += Home_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Home_LBL;
        private Panel panel5;
        private Panel panel6;
        private Label label2;
        private Label ReadMe_TXT;
        private Label label3;
        private Label label4;
    }
}
