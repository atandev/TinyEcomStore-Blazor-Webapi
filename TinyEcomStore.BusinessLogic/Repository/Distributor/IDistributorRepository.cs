using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyEcomStore.Models.Response;

namespace TinyEcomStore.BusinessLogic.Repository.Distributor
{
    public interface IDistributorRepository
    {
        public Task<List<ProductsResponse>> getProducts();
    }
}
