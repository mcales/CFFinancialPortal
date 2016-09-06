using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFFinancialPortal.Models
{
    public class budget
    {
        public budget()
        {
            this.BudgetItems = new HashSet<BudgetItems>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int HouseholdId { get; set; }

        public virtual Household Household { get; set; }
        public virtual ICollection<BudgetItems> BudgetItems { get; set; }
    }
}