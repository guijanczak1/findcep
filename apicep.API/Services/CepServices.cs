using apicep.API.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace apicep.API.Services
{
    public class CepServices
    {

        HttpClient client = new HttpClient();

        public async Task<CepModel?> GetCepService(string cep)
        {
            return await client.GetFromJsonAsync<CepModel>($"https://viacep.com.br/ws/{cep}/json/");           
        }
    }
}
