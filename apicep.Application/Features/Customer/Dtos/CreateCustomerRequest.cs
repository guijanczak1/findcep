using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apicep.Application.Features.Dtos
{
    public class CreateCustomerPhoneRequest
    {
        public string PhoneNumber { get; set; } = "";
    }
    public class CreateCustomerRequest
    {
        public string Name { get; set; } = "";
        public DateTime BirthDate { get; set; }
        public IEnumerable<CreateCustomerPhoneRequest> Phones { get; set; } = new List<CreateCustomerPhoneRequest>();   
    }
}
