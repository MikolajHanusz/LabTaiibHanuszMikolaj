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
        public ProductsController(IProductBLL productBLL) { this.productBLL = productBLL; }

        [HttpPost]
        public void PostProduct([FromBody] ProductRequestDTO productRequestDTO)
        {
            this.productBLL.AddProduct(productRequestDTO);
        }

        [HttpPut("{id}")]
        public void PutProduct(int id, [FromQuery] ProductRequestDTO productRequestDTO)
        {
            this.productBLL.UpdateProduct(productRequestDTO, id);
        }
        //[HttpPut("{id}")]
        //[Route("put2/{id}")]
        //public void ActivateProduct(int id, [FromQuery] ProductRequestDTO productRequestDTO)
        //{
        //    this.productBLL.UpdateProduct(productRequestDTO, id);
        //}

        [HttpGet]
        public IEnumerable<ProductResponseDTO> GetProducts([FromQuery] ProductListProperties p)
        {
            return this.productBLL.GetProductList(p);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.productBLL.DeleteProduct(id);
        }
    }
}
