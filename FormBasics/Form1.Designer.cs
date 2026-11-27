namespace FormBasics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnDarkMode = new Button();
            btnLightMode = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F);
            lblWelcome.Location = new Point(24, 64);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(64, 28);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Name";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // btnDarkMode
            // 
            btnDarkMode.Location = new Point(24, 112);
            btnDarkMode.Name = "btnDarkMode";
            btnDarkMode.Size = new Size(94, 29);
            btnDarkMode.TabIndex = 1;
            btnDarkMode.Text = "Dark Mode";
            btnDarkMode.UseVisualStyleBackColor = false;
            btnDarkMode.Click += btnDarkMode_Click;
            // 
            // btnLightMode
            // 
            btnLightMode.Location = new Point(124, 112);
            btnLightMode.Name = "btnLightMode";
            btnLightMode.Size = new Size(94, 29);
            btnLightMode.TabIndex = 2;
            btnLightMode.Text = "Light Mode";
            btnLightMode.UseVisualStyleBackColor = true;
            btnLightMode.Click += btnLightMode_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 153);
            Controls.Add(btnLightMode);
            Controls.Add(btnDarkMode);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Basics";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnDarkMode;
        private Button btnLightMode;
    }
}
