using System.Collections.Generic;
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

        public async Task<List<Products>> getProducts()
        {
            try
            {
                Console.WriteLine("asdas");
                var response = await _http.GetAsync("api/distributor/get-products");
                if (response.IsSuccessStatusCode)
                {
                    var products = await response.Content.ReadFromJsonAsync<List<Products>>();
                    return products;
                }
                else
                {
                    return null;
                }
                
            }
            catch (Exception ex) 
            {
                return null;
            }
        }
    }
}
