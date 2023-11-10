using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apicep.Infrastructure.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; } = "";
        public DateTime BirthDate { get; set; }
        public ICollection<CustomerPhone> CustomerPhones { get; set; } = new List<CustomerPhone>();
    }
}
