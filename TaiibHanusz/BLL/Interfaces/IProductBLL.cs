using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IProductBLL
    {
        List<ProductResponseDTO> GetProductList(ProductListProperties properties);
        void AddProduct(ProductRequestDTO product);
        void UpdateProduct(ProductRequestDTO product, int id);
        void DeleteProduct(int id);
        void ActivateProduct(int id);
    }
}
