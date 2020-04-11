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

            ListGenerator listGenerator = new ListGenerator();

            int[] arr1 = { 1, 1, 1, 0, 2, 1, 1 };

            int[] arr2 = { 5, 2, 0, 2, 0, 0, 2 };

            int[] arr3 = { 1, 1, 2, 1, 2, 1, 0 };

            int[] arr4 = { 2, 1, 0, 2, 2, 0, 1 };

            int[] arr5 = { 0, 1, 0, 0, 1, 0, 0 };

            int[] arr6 = { 0, 1, 0, 0, 1, 0, 0 };

            buyers.Enqueue(new Buyer(ListGenerator.ListOfProduct(arr1), 1110));
            buyers.Enqueue(new Buyer(ListGenerator.ListOfProduct(arr2), 2100));
            buyers.Enqueue(new Buyer(ListGenerator.ListOfProduct(arr3), 590));
            buyers.Enqueue(new Buyer(ListGenerator.ListOfProduct(arr4), 3000));
            buyers.Enqueue(new Buyer(ListGenerator.ListOfProduct(arr5), 319));
            buyers.Enqueue(new Buyer(ListGenerator.ListOfProduct(arr6), 1490));
            
            

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

        

    }
}
