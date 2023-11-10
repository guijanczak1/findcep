using apicep.Application.Features;
using apicep.Application.Features.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace apicep.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        readonly CustomerService customerService;
        public CustomerController(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateCustomerRequest request)
        {
            await customerService.CreateAsync(request);

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] GetAllCustomerRequest request)
        {
            var response = await customerService.GetAllAsync(request);
            return Ok(response);
        }
    }
}
