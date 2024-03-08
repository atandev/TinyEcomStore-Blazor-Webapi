using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyEcomStore.DataAccess.Context;
using TinyEcomStore.Models.Response;

namespace TinyEcomStore.BusinessLogic.Repository.Distributor
{
    public class DistributorRepository : IDistributorRepository
    {
        public IConfiguration _configuration;
        public DistributorRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<ProductsResponse>> getProducts()
        {
            try
            {
                using (TinyEcomStoreDBContext context = new TinyEcomStoreDBContext(_configuration))
                {
                    var products = context.Products.ToList();

                    var result = (from p in products
                                  select new ProductsResponse()
                                  {
                                      Id = p.Id,
                                      Name = p.Name,
                                      Price = p.Price,
                                      Description = p.Description,
                                      CreatedDate = p.CreatedDate
                                  }).ToList();
                    return result;
                }
            }
            catch
            {
                throw;   
            }
        }
    }
}
