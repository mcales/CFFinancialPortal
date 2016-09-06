using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFFinancialPortal.Models
{
    public class BudgetItems
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BudgetId { get; set; }
        public double Amount { get; set; }

        public virtual Category Category { get; set; }
        public virtual budget Budget { get; set; }
    }
}