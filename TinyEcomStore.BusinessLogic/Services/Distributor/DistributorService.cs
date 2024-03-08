using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyEcomStore.BusinessLogic.Repository.Distributor;
using TinyEcomStore.DataAccess.Context;
using TinyEcomStore.Models.Response;

namespace TinyEcomStore.BusinessLogic.Services.Distributor
{
    public class DistributorService : IDistributorService
    {
        public IDistributorRepository _distributorRepo;
        public DistributorService(IDistributorRepository distributorRepo)
        {
            _distributorRepo = distributorRepo;
        }

        public async Task<List<ProductsResponse>> getProducts()
        {
            return await _distributorRepo.getProducts();
        }
    }
}
