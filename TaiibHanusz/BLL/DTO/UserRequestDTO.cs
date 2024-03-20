using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class UserRequestDTO
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Type Type { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<BasketPosition> ?BasketPositions { get; set; }
        public IEnumerable<Order> ?Orders { get; set; }
    }
}
