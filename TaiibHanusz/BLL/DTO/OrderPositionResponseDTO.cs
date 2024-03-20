using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class OrderPositionResponseDTO
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
