using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mango.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int FruitBasketId { get; set; }
        public FruitBasket FruitBasket { get; set; }
    }
}
