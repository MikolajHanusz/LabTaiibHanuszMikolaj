using BLL.DTO;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IOrderBLL orderBLL;
        OrdersController(IOrderBLL orderBLL) { this.orderBLL = orderBLL; }

        [HttpPost]
        public void PostProduct(int id,[FromBody] OrderRequestDTO orderRequestDTO)
        {
            this.orderBLL.AddOrder(id,orderRequestDTO);
        }

        [HttpGet]
        [Route("get1/{id}")]
        public IEnumerable<OrderResponseDTO> GetOrderList()
        {
            return this.orderBLL.GetOrderList();
        }
        [HttpGet]
        [Route("get2/{id}")]
        public IEnumerable<OrderResponseDTO> GetUserOrderList(int userId)
        {
            return this.GetUserOrderList(userId);
        }

        [HttpGet]
        [Route("get3/{id}")]
        public IEnumerable<OrderPositionResponseDTO> GetOrderPositionList(int orderId)
        {
            return this.GetOrderPositionList(orderId);
        }
    }
}
