using BLL.DTO;
using BLL.Interfaces;
using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_EF
{
    public class BasketPositionBLL : IBasketPositionBLL
    {
        private WebShopContext WebShop;
        public BasketPositionBLL(WebShopContext webShop) { WebShop = webShop; }
        public void AddProduct(int basketId, ProductResponseDTO product)
        {
            BasketPosition basket = WebShop.BasketPositions.Find(basketId);
            Product p = new Product();
            {
                p.Name = product.Name;
                p.Price = product.Price;
                p.Image = product.Image;
                p.IsActive = product.IsActive;
                p.BasketPositions = product.BasketPositions;
                p.OrderPositions = product.OrderPositions;
            }
            basket.Product = p;
            WebShop.SaveChanges();
        }

        public void ChangeAmount(int basketId, int amount)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int basketId)
        {
            BasketPosition basket = WebShop.BasketPositions.Find(basketId);
            WebShop.Products.Remove(basket.Product);
            WebShop.SaveChanges();
        }

        public List<BasketPositionResponseDTO> GetBasket(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
