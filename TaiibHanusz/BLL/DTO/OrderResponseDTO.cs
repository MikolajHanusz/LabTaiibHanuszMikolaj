using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class OrderResponseDTO
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public IEnumerable<OrderPosition> Positions { get; set; }
    }
}
