using apicep.API.Models;
using apicep.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apicep.API.Controllers
{
    [Route("api/findcep")]
    [ApiController]
    public class CepController : ControllerBase   
    {


        [HttpGet("{cep}")]
        public async Task<IActionResult> GetCepAsync(string cep, [FromServices] CepServices cepServices)
        {         
            return Ok(await cepServices.GetCepService(cep));
        }
    }
}
