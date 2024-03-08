
using TinyEcomStore.Client.Models;

namespace TinyEcomStore.Client.Services.Distributor
{
    public interface IDistributorService
    {
        List<Products> Products { get; set; }
        Task getProducts();
    }
}
