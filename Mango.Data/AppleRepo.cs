using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mango.Domain;

namespace Mango.Data
{
    public class AppleRepo:GenericCRUDRepo<Apple,MangoDatabaseContext>
    {
        //Test
        public override ICollection<Apple> GetAll()
        {
            return base.GetAll();
        }
    }
}
