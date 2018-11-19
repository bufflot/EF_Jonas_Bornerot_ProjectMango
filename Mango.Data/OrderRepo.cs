using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mango.Domain;

namespace Mango.Data
{
    public class OrderRepo: GenericCRUDRepo<Order,MangoDatabaseContext>
    {
        
        public override void AsyncInsert(Order Entity)
        {
            base.AsyncInsert(Entity);
        }

    }
}
