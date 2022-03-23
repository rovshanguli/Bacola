using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontLayiheDB.Models
{
    public class BasketProduct
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public float OldPrice { get; set; }
        public float NewPrice { get; set; }
    }
}
