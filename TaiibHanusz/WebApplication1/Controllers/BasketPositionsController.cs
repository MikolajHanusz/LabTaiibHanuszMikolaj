using BLL.DTO;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketPositionsController : ControllerBase
    {
        private IBasketPositionBLL basketPositionBLL;
        BasketPositionsController(IBasketPositionBLL basketPositionBLL) { this.basketPositionBLL = basketPositionBLL; }

        [HttpPost]
        public void PostProduct(int id, [FromBody] ProductResponseDTO productResponseDTO)
        {
            this.basketPositionBLL.AddProduct(id, productResponseDTO);
        }

        [HttpPut]
        public void PutBasket(int basketId, int amount)
        {
            this.basketPositionBLL.ChangeAmount(basketId, amount);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.basketPositionBLL.DeleteProduct(id);
        }

        [HttpGet]
        public List<BasketPositionResponseDTO> GetBasket(int userId)
        {
            return this.basketPositionBLL.GetBasket(userId);
        }
    }
}