using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mango.Data;
using Mango.Domain;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AppleRepo appleRepo = new AppleRepo { };
            appleRepo.Insert( new Apple { Name = "Granny Smith", Price = 10, Organic = true });
            appleRepo.Insert(new Apple { Name = "Royal Gala", Price = 9, Organic = true });

            OrangeRepo orangeRepo = new OrangeRepo { };
            orangeRepo.Insert(new Orange { Name = "Apfelsin", Price = 5, Organic = false });

            List<Apple> apple = appleRepo.FindBy(m => m.Organic == true).ToList();

        }
    }
}
