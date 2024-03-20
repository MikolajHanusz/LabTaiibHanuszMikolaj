using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class OrderRequestDTO
    {
        public DateTime Date { get; set; }
        public User ?User { get; set; }
        public IEnumerable<OrderPosition> ?Positions { get; set; }
    }
}
