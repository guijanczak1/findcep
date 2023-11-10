using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apicep.Infrastructure.Models
{
    public class CustomerPhone
    {
        public Guid CustomerPhoneId { get; set; }
        public Guid CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public string PhoneNumber { get; set; } = "";
    }
}
