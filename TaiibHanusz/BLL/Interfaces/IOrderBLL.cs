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
        List<OrderResponseDTO> GetOrderList();
        List<OrderResponseDTO> GetUserOrderList(int userId);
        List<OrderPositionResponseDTO> GetOrderPositionList(int orderId);
    }
}
