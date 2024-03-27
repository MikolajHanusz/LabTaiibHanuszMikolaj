using BLL.DTO;
using BLL.Interfaces;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL_EF
{
    public class OrderBLL : IOrderBLL
    {
        private WebShopContext WebShop;
        public OrderBLL(WebShopContext webShop) { WebShop = webShop; }

        public void AddOrder(int userId, OrderRequestDTO order)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderResponseDTO> GetOrderList()
        {

            var orders = WebShop.Orders;

            return (IEnumerable<OrderResponseDTO>)orders;
        }

        public IEnumerable<OrderPositionResponseDTO> GetOrderPositionList(int orderId)
        {
            var order = WebShop.Orders.Select(x => x.Id == orderId);

            var positions = order;
            throw new NotImplementedException();
        }

        public IEnumerable<OrderResponseDTO> GetUserOrderList(int userId)
        {
            var users = WebShop.Users.Include(x => x.Orders).ThenInclude(x => x.Positions).ToList();

            var user = users.Find(x=>x.Id== userId);

            var orders = user.Orders;

            return (IEnumerable<OrderResponseDTO>)orders;
        }
    }
}
