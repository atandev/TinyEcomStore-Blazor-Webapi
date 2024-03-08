using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyEcomStore.Models;
using TinyEcomStore.Models.Response;

namespace TinyEcomStore.BusinessLogic.Services.Distributor
{
    public interface IDistributorService
    {
        public Task<List<ProductsResponse>> getProducts();
    }
}
