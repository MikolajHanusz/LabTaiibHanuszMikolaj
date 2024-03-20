using Model;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO
{
    public class ProductResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<BasketPosition> BasketPositions { get; set; }
        public IEnumerable<OrderPosition> OrderPositions { get; set; }
    }
}