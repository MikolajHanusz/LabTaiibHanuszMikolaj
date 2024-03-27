using BLL.DTO;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductBLL productBLL;
        ProductsController(IProductBLL productBLL) { this.productBLL = productBLL; }

        [HttpPost]
        ActionResult<ProductRequestDTO> AddProduct(ProductRequestDTO product)
        {
            var prod = productBLL.AddProduct(product);
            return CreatedAtAction(nameof(AddProduct),prod);
        }
    }
}
