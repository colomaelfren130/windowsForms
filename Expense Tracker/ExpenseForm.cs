using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Expense_Tracker
{
    public partial class ExpenseForm : Form
    {
        private readonly Expense expense;

        public ExpenseForm(Expense? existing = null)
        {
            InitializeComponent();


            cboCategory.Items.AddRange(new string[]
               { "Food", "Transportation", "Bills", "School", "Entertainment", "Others" });
            cboCategory.SelectedIndex = 0;
            dtpDate.MaxDate = DateTime.Today;   // no future dates
            rbCash.Checked = true;

            if (existing == null)
            {
                expense = new Expense();
                this.Text = "Add Expense";
            }
            else
            {
                expense = existing;
                this.Text = "Edit Expense";

                dtpDate.Value = existing.Date > DateTime.Today ? DateTime.Today : existing.Date;
                txtDescription.Text = existing.Description;
                cboCategory.SelectedItem = existing.Category;
                nudAmount.Value = existing.Amount;
                chkRecurring.Checked = existing.IsRecurring;
                txtNotes.Text = existing.Notes;

                if (existing.PaymentMethod == "GCash") rbGCash.Checked = true;
                else if (existing.PaymentMethod == "Card") rbCard.Checked = true;
                else rbCash.Checked = true;
            }

        }

        public Expense GetExpense() => expense;


        private bool ValidateInput()
        {
            errorProvider.Clear();
            bool ok = true;

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider.SetError(txtDescription, "Description is required.");
                ok = false;
            }
            if (cboCategory.SelectedIndex < 0)
            {
                errorProvider2.SetError(cboCategory, "Please choose a category.");
                ok = false;
            }
            if (nudAmount.Value <= 0)
            {
                errorProvider3.SetError(nudAmount, "Amount must be greater than 0.");
                ok = false;
            }
            return ok;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;  

            expense.Date = dtpDate.Value.Date;
            expense.Description = txtDescription.Text.Trim();
            expense.Category = cboCategory.Text;
            expense.Amount = nudAmount.Value;
            expense.PaymentMethod = rbCash.Checked ? "Cash"
                                  : rbGCash.Checked ? "GCash" : "Card";
            expense.IsRecurring = chkRecurring.Checked;
            expense.Notes = txtNotes.Text.Trim();

            this.DialogResult = DialogResult.OK;
        }







        private void ExpenseForm_Load(object sender, EventArgs e)
        {

        }







        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
