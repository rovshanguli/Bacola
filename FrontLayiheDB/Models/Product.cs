using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontLayiheDB.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool IsDelete { get; set; } = false;
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
