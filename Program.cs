using System;
using System.Threading;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;
            do {
                Console.Clear();
                correctInput = true;

                Console.WriteLine("What database would you like to use?");
                Console.WriteLine("Type: sql, mongo or list");
                userInput = Console.ReadLine();

                if(userInput != "sql" && userInput != "mongo" && userInput != "list")
                {
                    correctInput = false;
                    Console.WriteLine("Bad Input!");
                    Thread.Sleep(1000);
                }

            } while (!correctInput); ; 
               Console.Clear ();


            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);
            var products = db.LoadData();
            db.SavaData();

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name} {product.Price}");

            }



        }
    }
}
