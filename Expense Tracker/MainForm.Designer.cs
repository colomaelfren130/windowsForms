namespace Expense_Tracker
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mnuNew = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            mnuSave = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            expenseToolStripMenuItem = new ToolStripMenuItem();
            mnuAdd = new ToolStripMenuItem();
            mnuEdit = new ToolStripMenuItem();
            mnuDelete = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            mnuAbout = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            darkmodeToolStripMenuItem = new ToolStripMenuItem();
            lightmodeToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            tsbSave = new ToolStripButton();
            label1 = new Label();
            cboFilterCategory = new ComboBox();
            label3 = new Label();
            txtSearch = new TextBox();
            dgvExpenses = new DataGridView();
            label4 = new Label();
            tslCount = new Label();
            label7 = new Label();
            lblTotalValue = new Label();
            label9 = new Label();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            tslStatus = new ToolStripStatusLabel();
            lblTime = new Label();
            tmrClock = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            nudBudget = new NumericUpDown();
            lblRemaining = new Label();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBudget).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, expenseToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(804, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuNew, mnuOpen, mnuSave, mnuExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // mnuNew
            // 
            mnuNew.Name = "mnuNew";
            mnuNew.ShortcutKeyDisplayString = "Ctrl+N";
            mnuNew.ShortcutKeys = Keys.Control | Keys.N;
            mnuNew.Size = new Size(189, 26);
            mnuNew.Text = "&New";
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.ShortcutKeyDisplayString = "Ctrl + O";
            mnuOpen.ShortcutKeys = Keys.Control | Keys.O;
            mnuOpen.Size = new Size(189, 26);
            mnuOpen.Text = "Open";
            // 
            // mnuSave
            // 
            mnuSave.Name = "mnuSave";
            mnuSave.ShortcutKeyDisplayString = "Ctrl + S";
            mnuSave.ShortcutKeys = Keys.Control | Keys.S;
            mnuSave.Size = new Size(189, 26);
            mnuSave.Text = "Save";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(189, 26);
            mnuExit.Text = "Exit";
            // 
            // expenseToolStripMenuItem
            // 
            expenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuAdd, mnuEdit, mnuDelete });
            expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            expenseToolStripMenuItem.Size = new Size(77, 24);
            expenseToolStripMenuItem.Text = "&Expense";
            // 
            // mnuAdd
            // 
            mnuAdd.Name = "mnuAdd";
            mnuAdd.Size = new Size(136, 26);
            mnuAdd.Text = "Add";
            mnuAdd.Click += tsbAdd_Click;
            // 
            // mnuEdit
            // 
            mnuEdit.Name = "mnuEdit";
            mnuEdit.Size = new Size(224, 26);
            mnuEdit.Text = "Edit";
            mnuEdit.Click += EditExpense;
            // 
            // mnuDelete
            // 
            mnuDelete.Name = "mnuDelete";
            mnuDelete.Size = new Size(224, 26);
            mnuDelete.Text = "Delete";
            mnuDelete.Click += DeleteExpense;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuAbout, settingsToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // mnuAbout
            // 
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new Size(145, 26);
            mnuAbout.Text = "&About";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkmodeToolStripMenuItem, lightmodeToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(145, 26);
            settingsToolStripMenuItem.Text = "&Settings";
            // 
            // darkmodeToolStripMenuItem
            // 
            darkmodeToolStripMenuItem.Name = "darkmodeToolStripMenuItem";
            darkmodeToolStripMenuItem.Size = new Size(164, 26);
            darkmodeToolStripMenuItem.Text = "&Darkmode";
            darkmodeToolStripMenuItem.Click += darkmodeToolStripMenuItem_Click;
            // 
            // lightmodeToolStripMenuItem
            // 
            lightmodeToolStripMenuItem.Name = "lightmodeToolStripMenuItem";
            lightmodeToolStripMenuItem.Size = new Size(164, 26);
            lightmodeToolStripMenuItem.Text = "&Lightmode";
            lightmodeToolStripMenuItem.Click += lightmodeToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbDelete, tsbSave });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(804, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(41, 24);
            tsbAdd.Text = "&Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(39, 24);
            tsbEdit.Text = "&Edit";
            tsbEdit.Click += EditExpense;
            // 
            // tsbDelete
            // 
            tsbDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(57, 24);
            tsbDelete.Text = "&Delete";
            tsbDelete.Click += DeleteExpense;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbSave.Image = (Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(44, 24);
            tsbSave.Text = "&Save";
            tsbSave.Click += tsbSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 94);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "Category: ";
            // 
            // cboFilterCategory
            // 
            cboFilterCategory.FormattingEnabled = true;
            cboFilterCategory.Items.AddRange(new object[] { "Food", "Transportation", "Bills", "School", "Entertainment", "Others" });
            cboFilterCategory.Location = new Point(94, 86);
            cboFilterCategory.Name = "cboFilterCategory";
            cboFilterCategory.Size = new Size(151, 28);
            cboFilterCategory.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 94);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "Search: ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(326, 86);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(301, 27);
            txtSearch.TabIndex = 6;
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AllowUserToOrderColumns = true;
            dgvExpenses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Location = new Point(0, 143);
            dgvExpenses.MultiSelect = false;
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.RowHeadersWidth = 51;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.Size = new Size(804, 311);
            dgvExpenses.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 465);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 17;
            label4.Text = "Shown:";
            // 
            // tslCount
            // 
            tslCount.AutoSize = true;
            tslCount.Location = new Point(58, 465);
            tslCount.Name = "tslCount";
            tslCount.Size = new Size(17, 20);
            tslCount.TabIndex = 18;
            tslCount.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(186, 465);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 19;
            label7.Text = "Total:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(237, 465);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(60, 20);
            lblTotalValue.TabIndex = 20;
            lblTotalValue.Text = "0000.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2, 531);
            label9.Name = "label9";
            label9.Size = new Size(122, 20);
            label9.TabIndex = 21;
            label9.Text = "Monthly Budget: ";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 20);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslStatus, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 564);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(804, 26);
            statusStrip1.TabIndex = 16;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            tslStatus.Name = "tslStatus";
            tslStatus.Size = new Size(121, 20);
            tslStatus.Text = "Expenses Added.";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(623, 531);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(45, 20);
            lblTime.TabIndex = 22;
            lblTime.Text = "Time:";
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(572, 531);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 23;
            label2.Text = "Time:";
            // 
            // nudBudget
            // 
            nudBudget.Location = new Point(130, 524);
            nudBudget.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudBudget.Name = "nudBudget";
            nudBudget.Size = new Size(150, 27);
            nudBudget.TabIndex = 24;
            // 
            // lblRemaining
            // 
            lblRemaining.AutoSize = true;
            lblRemaining.Location = new Point(297, 526);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(0, 20);
            lblRemaining.TabIndex = 25;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 590);
            Controls.Add(lblRemaining);
            Controls.Add(nudBudget);
            Controls.Add(label2);
            Controls.Add(lblTime);
            Controls.Add(label9);
            Controls.Add(lblTotalValue);
            Controls.Add(label7);
            Controls.Add(tslCount);
            Controls.Add(label4);
            Controls.Add(statusStrip1);
            Controls.Add(dgvExpenses);
            Controls.Add(txtSearch);
            Controls.Add(label3);
            Controls.Add(cboFilterCategory);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBudget).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem expenseToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem mnuAbout;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbDelete;
        private ToolStripButton tsbSave;
        private Label label1;
        private ComboBox cboFilterCategory;
        private Label label3;
        private TextBox txtSearch;
        private DataGridView dgvExpenses;
        private Label label4;
        private Label tslCount;
        private Label label7;
        private Label lblTotalValue;
        private Label label9;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem darkmodeToolStripMenuItem;
        private ToolStripMenuItem lightmodeToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslStatus;
        private Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer tmrClock;
        private Label label2;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuSave;
        private ToolStripMenuItem mnuExit;
        private NumericUpDown nudBudget;
        private Label lblRemaining;
        private ToolStripMenuItem mnuAdd;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuDelete;
    }
}
