using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apicep.Application.Features.Dtos
{
    public class GetAllCustomerPhoneResponse
    {
        public Guid CustomerPhoneId { get; set; }
        public string PhoneNumber { get; set; } = "";
    }

    public class GetAllCustomerResponse
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; } = "";
        public DateTime BirthDate { get; set; }
        public IEnumerable<GetAllCustomerPhoneResponse> Phones { get; set; } = new List<GetAllCustomerPhoneResponse>();
    }
}
