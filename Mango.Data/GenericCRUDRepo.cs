using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mango.Data
{
    public abstract class GenericCRUDRepo<T, C> where T : class where C : DbContext, new()
    {
        public C Context { get; set; } = new C();
        //private C _context = new C();
        //public C Context
        //{
        //    get { return _context; }
        //    set { _context = value; }
        //}

        public virtual ICollection<T> GetAll()
        {
            return Context.Set<T>().ToList();

        }

        public virtual void Insert(T Entity)
        {
            Context.Set<T>().Add(Entity);
            Context.SaveChanges();

        }

        public virtual void Remove(T Entity)
        {
            Context.Set<T>().Remove(Entity);
            Context.SaveChanges();
        }

        public virtual void Update(T Entity)
        {
            Context.Set<T>().Update(Entity);
            Context.SaveChanges();

        }

        public virtual ICollection<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate).ToList();
        }

        //Min Async/Await. p.g.a. om två ordrar skapas samtidigt med samma frukter vars kvantitet inte uppfyller orderkraven.
        //kallas genom override i OrderRepo
        public virtual async void AsyncInsert(T Entity)
        {
            await Context.Set<T>().AddAsync(Entity);
        }

    }
}

