using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFFinancialPortal.Models
{
    public class Transaction
    {
    public Transaction()
        {

        }
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Date { get; set; }
        public double Amount { get; set; }
        public int TypeId { get; set; }
        public int CategoryId { get; set; }
        public string EnteredById { get; set; }
        public bool Reconciled { get; set; }
        public double ReconciledAmount { get; set; }
        public string EnteredBy_Id { get; set; }

        public virtual Category Category { get; set; }
        public virtual ApplicationUser EnteredBy { get; set; }
        public virtual Account Account { get; set; }
        public virtual TransactionType Type { get; set; }
    }
}