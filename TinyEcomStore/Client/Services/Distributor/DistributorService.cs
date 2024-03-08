using System.Net.Http.Json;
using TinyEcomStore.Client.Models;

namespace TinyEcomStore.Client.Services.Distributor
{
    public class DistributorService : IDistributorService
    {
        private readonly HttpClient _http;
        public DistributorService(HttpClient http)
        {
            _http = http;
        }
        public List<Products> Products { get; set; } = new List<Products>();

        public async Task getProducts()
        {
            var result = await _http.GetFromJsonAsync<List<Products>>("api/distributor/get-products");
            Products = result;
        }
    }
}
