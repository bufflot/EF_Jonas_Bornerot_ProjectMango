using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mango.Domain;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Mango.Data
{
   public class MangoDatabaseContext : DbContext
    {
        public DbSet<Apple> Apples { get; set; }
        public DbSet<Banana> Bananas { get; set; }
        public DbSet<Orange> Oranges { get; set; }
        public DbSet<WaterMelon> WaterMelons { get; set; }
        public DbSet<FruitBasket> FruitBaskets { get; set; }
        public DbSet<Order> Orders { get; set; }

        public static readonly LoggerFactory mangologgerFactory
               = new LoggerFactory(new[]{
           new ConsoleLoggerProvider((category, level) => category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information, true)
               });


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
               .UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = FruitBasketStore; Trusted_connection = True;");
        }

    }

}
