using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IBasketPositionBLL
    {
        void AddProduct(int basketId, ProductResponseDTO product);
        void DeleteProduct(int basketId);
        void ChangeAmount(int basketId, int amount);
        List<BasketPositionResponseDTO> GetBasket(int userId);
    }
}
