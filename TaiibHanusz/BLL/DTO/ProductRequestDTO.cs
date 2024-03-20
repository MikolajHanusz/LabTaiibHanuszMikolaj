using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ProductRequestDTO
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<BasketPosition> ?BasketPositions { get; set; }
        public IEnumerable<OrderPosition> ?OrderPositions { get; set; }
    }
}
