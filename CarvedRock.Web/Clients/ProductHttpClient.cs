using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CarvedRock.Web.Models;

namespace CarvedRock.Web.HttpClients
{
    public class ProductHttpClient
    {
        private readonly HttpClient _httpClient;

        public ProductHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Response<ProductsContainer>> GetProducts()
        {
            var response = await _httpClient.GetAsync(@"?query= 
            { products 
                { id name price rating photoFileName } 
            }");
            var stringResult = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Response<ProductsContainer>>(stringResult, new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
        }
    }
}
