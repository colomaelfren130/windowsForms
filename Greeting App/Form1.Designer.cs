namespace Greeting_App
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
            lblPrompt = new Label();
            txtName = new TextBox();
            btnGreet = new Button();
            btnClear = new Button();
            lblResult = new Label();
            label1 = new Label();
            lblCity = new Label();
            txtCity = new TextBox();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(28, 53);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(120, 20);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Enter your name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(28, 76);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "e.g Juan Dela Cruz";
            txtName.Size = new Size(306, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnGreet
            // 
            btnGreet.Enabled = false;
            btnGreet.Location = new Point(28, 192);
            btnGreet.Name = "btnGreet";
            btnGreet.Size = new Size(94, 29);
            btnGreet.TabIndex = 2;
            btnGreet.Text = "Greet";
            btnGreet.UseVisualStyleBackColor = true;
            btnGreet.Click += btnGreet_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(150, 192);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(12, 278);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(596, 30);
            lblResult.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(28, 116);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(110, 20);
            lblCity.TabIndex = 6;
            lblCity.Text = "Enter your city: ";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(30, 147);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "e.g Binan City";
            txtCity.Size = new Size(304, 27);
            txtCity.TabIndex = 7;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // Form1
            // 
            AcceptButton = btnGreet;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCity);
            Controls.Add(lblCity);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(btnClear);
            Controls.Add(btnGreet);
            Controls.Add(txtName);
            Controls.Add(lblPrompt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtName;
        private Button btnGreet;
        private Button btnClear;
        private Label lblResult;
        private Label label1;
        private Label lblCity;
        private TextBox txtCity;
    }
}
