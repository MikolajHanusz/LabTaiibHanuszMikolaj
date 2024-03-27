using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IOrderBLL
    {
        void AddOrder(int userId, OrderRequestDTO order);
        IEnumerable<OrderResponseDTO> GetOrderList();
        IEnumerable<OrderResponseDTO> GetUserOrderList(int userId);
        IEnumerable<OrderPositionResponseDTO> GetOrderPositionList(int orderId);
    }
}
