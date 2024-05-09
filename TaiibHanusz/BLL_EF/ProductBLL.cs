using BLL.DTO;
using BLL.Interfaces;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL_EF
{
    public class ProductBLL : IProductBLL
    {
        private WebShopContext WebShop;
        public ProductBLL(WebShopContext webShop) { WebShop = webShop; }


        public void ActivateProduct(int id)
        {
            Product p = (Product)WebShop.Products.Select(x => x.Id);
            p.IsActive = true;
            WebShop.SaveChanges();
        }

        public ProductRequestDTO AddProduct(ProductRequestDTO product)
        {
            if(product.Price <= 0) throw new ArgumentOutOfRangeException();
            Product p = new Product();
            {
                p.Name = product.Name;
                p.Price = product.Price;      
                p.Image = product.Image;
                p.IsActive = product.IsActive;
                p.BasketPositions = product.BasketPositions;
                p.OrderPositions = product.OrderPositions;
            }
            WebShop.Products.Add(p);
            WebShop.SaveChanges();

            return product;
        }

        public void DeleteProduct(int id)
        {
            Product p = (Product)WebShop.Products.Select(x => x.Id);
            WebShop.Products.Remove(p);
            WebShop.SaveChanges();
        }

        public List<ProductResponseDTO> GetProductList(ProductListProperties properties)
        {
            List<ProductResponseDTO > productsList = new List<ProductResponseDTO>();
            var products = WebShop.Products;
            foreach (var product in products) 
            { 
                ProductResponseDTO productResponse = new ProductResponseDTO();
                productResponse.Id = product.Id;
                productResponse.Name = product.Name;
                productResponse.Price = product.Price;
                productResponse.Image = product.Image;
                productResponse.IsActive = product.IsActive;
                productResponse.BasketPositions = product.BasketPositions;
                productResponse.OrderPositions = product.OrderPositions;

                productsList.Add(productResponse);
            }
            return productsList;
        }

        public void UpdateProduct(ProductRequestDTO product, int id)
        {
            Product p = (Product)WebShop.Products.Select(x => x.Id);
            p.Name = product.Name;
            p.Price = product.Price;
            p.Image = product.Image;
            p.IsActive = product.IsActive;
            p.BasketPositions = product.BasketPositions;
            p.OrderPositions = product.OrderPositions;
            WebShop.SaveChanges();
        }
    }
}
