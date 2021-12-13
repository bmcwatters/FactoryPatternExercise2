using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "xbox", Price = 350},
            new Product() { Name = "laptop", Price = 900},
            new Product() { Name = "guitar", Price = 450},
            new Product(){ Name = "Blender", Price = 125},
        };


        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List Data Acess.");
            return Products;


        }

        public void SavaData()
        {
            Console.WriteLine("I am saving data from a List Data Access");
        }
    }
}
