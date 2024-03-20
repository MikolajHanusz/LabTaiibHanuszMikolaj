using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public class ProductListProperties
    {
        public int Pages { get; set; }
        public int PageSize { get; set; }
        public bool FilterByName { get; set; }
        public bool FilterByActive { get; set; }
        public string ?OrderBy { get; set; }
        public bool Sort { get; set; }
    }
}
