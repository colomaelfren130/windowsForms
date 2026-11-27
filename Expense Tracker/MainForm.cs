using System.Text.Json;

namespace Expense_Tracker
{
    public partial class MainForm : Form
    {

        private readonly List<Expense> expenses = new();
        private string? currentFile = null;
        private bool isDirty = false;


        public MainForm()
        {
            InitializeComponent();

            cboFilterCategory.Items.Add("All");
            cboFilterCategory.SelectedIndex = 0;
            tsbAdd.Click += AddExpense;
            mnuEdit.Click += EditExpense; tsbEdit.Click += EditExpense;
            mnuDelete.Click += DeleteExpense; tsbDelete.Click += DeleteExpense;
            mnuExit.Click += (s, e) => Close();
            mnuNew.Click += NewFile;
            mnuOpen.Click += OpenFile;
            mnuSave.Click += SaveFile;
            tsbSave.Click += SaveFile;
            mnuAbout.Click += ShowAbout;

            dgvExpenses.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) EditExpense(s, e); };

        }


        private void MainForm_Load(object sender, EventArgs e)
        {

            ShowTime();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show(
               "Do you really want to exit?",
               "Confirm Exit",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                e.Cancel = true;

            }

        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using (ExpenseForm expenseForm = new ExpenseForm())
            {
                expenseForm.ShowDialog();
            }
        }



        private void NewFile(object? sender, EventArgs e)
        {
            if (!ConfirmDiscardOrSave()) return;

            expenses.Clear();
            currentFile = null;
            isDirty = false;
            RefreshGrid();
            UpdateTitle();
            tslStatus.Text = "New file.";
        }



        private void OpenFile(object? sender, EventArgs e)
        {
            if (!ConfirmDiscardOrSave()) return;

            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (dialog.ShowDialog(this) != DialogResult.OK) return;   // user cancelled

            try
            {
                string json = File.ReadAllText(dialog.FileName);
                List<Expense>? loaded = JsonSerializer.Deserialize<List<Expense>>(json);

                expenses.Clear();
                if (loaded != null) expenses.AddRange(loaded);

                currentFile = dialog.FileName;
                isDirty = false;
                RefreshGrid();
                UpdateTitle();
                tslStatus.Text = $"Opened {Path.GetFileName(currentFile)}.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the file.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SaveFile(object? sender, EventArgs e)
        {
            SaveToCurrent();
        }


        private bool SaveToCurrent()
        {
            if (currentFile == null) return SaveAs();
            return WriteFile(currentFile);
        }

        private bool SaveAs()
        {
            using SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            dialog.FileName = "expenses.json";
            if (dialog.ShowDialog(this) != DialogResult.OK) return false;

            return WriteFile(dialog.FileName);
        }

        private bool WriteFile(string path)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(expenses, options);
                File.WriteAllText(path, json);

                currentFile = path;
                isDirty = false;
                UpdateTitle();
                tslStatus.Text = $"Saved {expenses.Count} expense(s) to {Path.GetFileName(path)}.";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the file.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private bool ConfirmDiscardOrSave()
        {
            if (!isDirty) return true;

            DialogResult answer = MessageBox.Show(
                "You have unsaved changes. Save them first?", "Unsaved Changes",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes) return SaveToCurrent();
            if (answer == DialogResult.No) return true;
            return false;
        }





        private void RefreshGrid()
        {
            IEnumerable<Expense> query = expenses;


            if (cboFilterCategory.SelectedIndex > 0)
                query = query.Where(x => x.Category == cboFilterCategory.Text);


            string term = txtSearch.Text.Trim();
            if (term != "")
                query = query.Where(x =>
                    x.Description.Contains(term, StringComparison.OrdinalIgnoreCase));





            List<Expense> shown = query
                .OrderByDescending(x => x.Date)
                .ThenByDescending(x => x.Id)
                .ToList();

            dgvExpenses.DataSource = shown;
            ConfigureColumns();
            UpdateSummary();
        }

        private void ConfigureColumns()
        {
            if (dgvExpenses.Columns.Count == 0) return;

            dgvExpenses.Columns["Id"]!.Visible = false;
            dgvExpenses.Columns["Notes"]!.Visible = false;

            dgvExpenses.Columns["Date"]!.DefaultCellStyle.Format = "MM/dd/yyyy";
            dgvExpenses.Columns["Amount"]!.DefaultCellStyle.Format = "N2";
            dgvExpenses.Columns["Amount"]!.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvExpenses.Columns["Amount"]!.HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleRight;
        }

        private void UpdateSummary()
        {

            var shown = dgvExpenses.DataSource as List<Expense> ?? new List<Expense>();
            decimal total = shown.Sum(x => x.Amount);
            tslCount.Text = $"Shown: {shown.Count}    Total: PHP {total:N2}";
            lblTotalValue.Text = total.ToString("N2");


            DateTime today = DateTime.Today;
            decimal spentThisMonth = expenses
                .Where(x => x.Date.Year == today.Year && x.Date.Month == today.Month)
                .Sum(x => x.Amount);
            decimal remaining = nudBudget.Value - spentThisMonth;

            lblRemaining.Text = $"Remaining this month: PHP {remaining:N2}";
            lblRemaining.ForeColor = remaining < 0 ? Color.Red : Color.Green;

            tslCount.Text = $"{expenses.Count} records";
        }






        private void tmrClock_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void ShowTime()
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void tmrClock_Tick_1(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void darkmodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void lightmodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void ShowAbout(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Expense Tracker (Offline Activity - 11/20/2026)\n\nColoma Elfren A.",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddExpense(object? sender, EventArgs e)
        {
            using (ExpenseForm form = new ExpenseForm())
            {
                if (form.ShowDialog(this) != DialogResult.OK) return;

                Expense newExpense = form.GetExpense();
                newExpense.Id = expenses.Count == 0 ? 1 : expenses.Max(x => x.Id) + 1;
                expenses.Add(newExpense);
            }
            MarkDirty();
            RefreshGrid();
            tslStatus.Text = "Expense added.";
        }



        private void EditExpense(object? sender, EventArgs e)
        {
            Expense? selected = dgvExpenses.CurrentRow?.DataBoundItem as Expense;
            if (selected == null)
            {
                MessageBox.Show("Select an expense to edit.", "Edit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (ExpenseForm form = new ExpenseForm())
            {

                if (form.ShowDialog(this) != DialogResult.OK) return;
            }
            MarkDirty();
            RefreshGrid();
            tslStatus.Text = "Expense updated.";
        }


        private void DeleteExpense(object? sender, EventArgs e)
        {
            Expense? selected = dgvExpenses.CurrentRow?.DataBoundItem as Expense;
            if (selected == null)
            {
                MessageBox.Show("Select an expense to delete.", "Delete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult answer = MessageBox.Show(
                $"Delete \"{selected.Description}\"?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes) return;

            expenses.Remove(selected);
            MarkDirty();
            RefreshGrid();
            tslStatus.Text = "Expense deleted.";
        }



        private void MarkDirty()
        {
            isDirty = true;
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            string name = currentFile == null ? "Untitled" : Path.GetFileName(currentFile);
            this.Text = "Expense Tracker - " + name + (isDirty ? "*" : "");
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {

        }
    }
}
