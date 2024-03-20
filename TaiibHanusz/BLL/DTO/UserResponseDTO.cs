using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public enum Type
    {
        Casual = 1, Admin = 2
    }
    public class UserResponseDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Type Type { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<BasketPosition> BasketPositions { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
