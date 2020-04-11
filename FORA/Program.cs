using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORA
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.AddProductToShop();
            shop.Decommissione();
            //shop.showFreshProducts();
            /////////////////////////////////////////
            


            Queue<Buyer> buyers = new Queue<Buyer>();
            //Milk, Bread, Cake, Chocolate, Meat, Sausage, ToiletPaper

              
            buyers.Enqueue(new Buyer(ListOfProduct(1, 1, 1, 0, 2, 1, 1), 1110));
            buyers.Enqueue(new Buyer(ListOfProduct(5, 2, 0, 2, 0, 0, 2), 2100));
            buyers.Enqueue(new Buyer(ListOfProduct(1, 1, 2, 1, 2, 1, 0), 590));
            buyers.Enqueue(new Buyer(ListOfProduct(2, 1, 0, 2, 2, 0, 1), 3000));
            buyers.Enqueue(new Buyer(ListOfProduct(0, 1, 0, 0, 1, 0, 0), 319));
            buyers.Enqueue(new Buyer(ListOfProduct(0, 1, 0, 0, 1, 0, 0), 1490));


            int countOfBuyers = buyers.Count;

            for (int i = 0; i < countOfBuyers; i++)
            {
                shop.showFreshProducts();
                shop.SaleToBuyer(buyers.Dequeue());
                Console.WriteLine("Press any key to start another customer");
                Console.ReadLine();
                
            }

            //Console.WriteLine("Press any key to start another customer");
            Console.ReadLine();


        }

        static List<Product> ListOfProduct(int countOfMilk, int countOfBread, int countOfCake, int countOfChocolate, int countOfMeat, int countOfSausage, int countOfToiletPaper)
        {
            List<Product> list = new List<Product>();
            Random random = new Random();
            for (int i = 0; i < countOfMilk; i++)
            {
                list.Add(new Milk());
            }

            for (int i = 0; i < countOfBread; i++)
            {
                list.Add(new Bread());
            }

            for (int i = 0; i < countOfCake; i++)
            {
                list.Add(new Cake());
            }

            for (int i = 0; i < countOfChocolate; i++)
            {
                list.Add(new Chocolate());
            }

            for (int i = 0; i < countOfMeat; i++)
            {
                list.Add(new Meat());
            }

            for (int i = 0; i < countOfSausage; i++)
            {
                list.Add(new Sausage());
            }

            for (int i = 0; i < countOfToiletPaper; i++)
            {
                list.Add(new ToiletPaper());
            }

            return list;
        }

    }
}
