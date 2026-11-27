namespace WinFormsApp1
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
            btnHello = new Button();
            btnGoodbye = new Button();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.Location = new Point(299, 34);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(133, 57);
            btnHello.TabIndex = 0;
            btnHello.Text = "Say Hello";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;
            // 
            // btnGoodbye
            // 
            btnGoodbye.Location = new Point(299, 134);
            btnGoodbye.Name = "btnGoodbye";
            btnGoodbye.Size = new Size(133, 54);
            btnGoodbye.TabIndex = 1;
            btnGoodbye.Text = "Say Goodbye";
            btnGoodbye.UseVisualStyleBackColor = true;
            btnGoodbye.Click += btnGoodbye_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGoodbye);
            Controls.Add(btnHello);
            Name = "Form1";
            Text = "My First App";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHello;
        private Button btnGoodbye;
    }
}
