
using TinyEcomStore.Client.Models;

namespace TinyEcomStore.Client.Services.Distributor
{
    public interface IDistributorService
    {
        Task<List<Products>> getProducts();
    }
}
