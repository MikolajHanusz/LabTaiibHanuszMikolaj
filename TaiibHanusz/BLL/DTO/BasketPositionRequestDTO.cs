using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class BasketPositionRequestDTO
    {
        public Product Product { get; set; }
        public User User { get; set; }
        public int Amount { get; set; }
    }
}
