namespace Expense_Tracker
{
    partial class ExpenseForm
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
            components = new System.ComponentModel.Container();
            lblDate = new Label();
            lblDescription = new Label();
            lblCategory = new Label();
            lblAmount = new Label();
            dtpDate = new DateTimePicker();
            txtDescription = new TextBox();
            cboCategory = new ComboBox();
            nudAmount = new NumericUpDown();
            rbCash = new RadioButton();
            groupBox1 = new GroupBox();
            rbCard = new RadioButton();
            rbGCash = new RadioButton();
            chkRecurring = new CheckBox();
            txtNotes = new TextBox();
            lblNotes = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(23, 45);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(23, 92);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(23, 139);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(23, 187);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 20);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "Amount";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(146, 40);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(248, 27);
            dtpDate.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(146, 85);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(350, 27);
            txtDescription.TabIndex = 5;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(146, 131);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(248, 28);
            cboCategory.TabIndex = 6;
            cboCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(146, 180);
            nudAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(198, 27);
            nudAmount.TabIndex = 7;
            // 
            // rbCash
            // 
            rbCash.AutoSize = true;
            rbCash.Location = new Point(55, 53);
            rbCash.Name = "rbCash";
            rbCash.Size = new Size(61, 24);
            rbCash.TabIndex = 8;
            rbCash.TabStop = true;
            rbCash.Text = "Cash";
            rbCash.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbCard);
            groupBox1.Controls.Add(rbGCash);
            groupBox1.Controls.Add(rbCash);
            groupBox1.Location = new Point(12, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 108);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment";
            // 
            // rbCard
            // 
            rbCard.AutoSize = true;
            rbCard.Location = new Point(328, 53);
            rbCard.Name = "rbCard";
            rbCard.Size = new Size(61, 24);
            rbCard.TabIndex = 10;
            rbCard.TabStop = true;
            rbCard.Text = "Card";
            rbCard.UseVisualStyleBackColor = true;
            // 
            // rbGCash
            // 
            rbGCash.AutoSize = true;
            rbGCash.Location = new Point(198, 53);
            rbGCash.Name = "rbGCash";
            rbGCash.Size = new Size(71, 24);
            rbGCash.TabIndex = 9;
            rbGCash.TabStop = true;
            rbGCash.Text = "GCash";
            rbGCash.UseVisualStyleBackColor = true;
            // 
            // chkRecurring
            // 
            chkRecurring.AutoSize = true;
            chkRecurring.Location = new Point(23, 379);
            chkRecurring.Name = "chkRecurring";
            chkRecurring.Size = new Size(152, 24);
            chkRecurring.TabIndex = 10;
            chkRecurring.Text = "Recurring Monthly";
            chkRecurring.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(163, 433);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(466, 106);
            txtNotes.TabIndex = 11;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(23, 436);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(51, 20);
            lblNotes.TabIndex = 12;
            lblNotes.Text = "Notes:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(379, 595);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(497, 595);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // ExpenseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 638);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblNotes);
            Controls.Add(txtNotes);
            Controls.Add(chkRecurring);
            Controls.Add(groupBox1);
            Controls.Add(nudAmount);
            Controls.Add(cboCategory);
            Controls.Add(txtDescription);
            Controls.Add(dtpDate);
            Controls.Add(lblAmount);
            Controls.Add(lblCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblDate);
            Name = "ExpenseForm";
            Text = "ExpenseForm";
            Load += ExpenseForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDate;
        private Label lblDescription;
        private Label lblCategory;
        private Label lblAmount;
        private DateTimePicker dtpDate;
        private TextBox txtDescription;
        private ComboBox cboCategory;
        private NumericUpDown nudAmount;
        private RadioButton rbCash;
        private GroupBox groupBox1;
        private RadioButton rbCard;
        private RadioButton rbGCash;
        private CheckBox chkRecurring;
        private TextBox txtNotes;
        private Label lblNotes;
        private Button btnSave;
        private Button btnCancel;
        private ErrorProvider errorProvider;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
    }
}