using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mango.Domain
{
    public class FruitBasket
    {
        public int Id { get; set; }
        public Apple Apple { get; set; }
        public Banana Banana { get; set; }
        public Orange Orange { get; set; }
        public WaterMelon WaterMelon { get; set; }
    }
}
