using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Expense_Tracker
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Today;
        public string Description { get; set; } = "";
        public string Category { get; set; } = "";
        public decimal Amount { get; set; }
        [DisplayName("Payment")]
        public string PaymentMethod { get; set; } = "";
        [DisplayName("Recurring")]
        public bool IsRecurring { get; set; }
        public string Notes { get; set; } = "";
    }
}
