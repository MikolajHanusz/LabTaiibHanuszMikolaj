using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class OrderPositionRequestDTO
    {
        public int Amount { get; set; }
        public double Price { get; set; }
        public Order ?Order { get; set; }
        public Product ?Product { get; set; }
    }
}
