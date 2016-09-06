using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFFinancialPortal.Models
{
    public class Household
    {
        public Household()
        {
            this.Accounts = new HashSet<Account>();
            this.Users = new HashSet<ApplicationUser>();
            this.Categories = new HashSet<Category>();
            this.Budget = new HashSet<budget>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<budget> Budget { get; set; }
    }
}