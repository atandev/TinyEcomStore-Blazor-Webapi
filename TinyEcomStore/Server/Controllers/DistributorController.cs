using Microsoft.AspNetCore.Mvc;
using TinyEcomStore.BusinessLogic.Repository.Distributor;
using TinyEcomStore.BusinessLogic.Services.Distributor;
using TinyEcomStore.DataAccess.Context;

namespace TinyEcomStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributorController : ControllerBase
    {
        public IConfiguration _configuration;
        public IDistributorService _distributorService;

        public DistributorController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private void InitDependecy()
        {
            var repo = new DistributorRepository(_configuration);
            _distributorService = new DistributorService(repo);
        }

        [HttpGet]
        [Route("get-products")]
        public async Task<IActionResult> getProducts()
        {
            try
            {
                InitDependecy();
                var result = await _distributorService.getProducts();
                return Ok(result);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database.");
            }
            
        }
    }
}
