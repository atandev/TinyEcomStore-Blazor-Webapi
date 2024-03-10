using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyEcomStore.Models.Response
{
    public class ProductsResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public string? FilePath { get; set; }
        public decimal SRP { get; set; }
        public decimal DP { get; set; }
        public decimal WSP { get; set; }
        public decimal EP { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
