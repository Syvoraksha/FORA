using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORA
{
    class Shop
    {
        public List<Product> products = new List<Product>();
        //Product product; 
        public List<string> decommissioned = new List<string>();
        DateTime dataStart = new DateTime(2020, 3, 1);
        DateTime dataToday = DateTime.Today;

        public void AddProductToShop()
        {
            Random rand = new Random();

            for (int i = 0; i < 15; i++)
            {
                products.Add(new Milk(new DateTime(2020, rand.Next(3, 4), rand.Next(1, 31))));
            }
            /////////////////////////////////////////////////
           
            for (int i = 0; i < 12; i++)
            {
                products.Add(new Bread(new DateTime(2020, 4, rand.Next(1, 31))));
            }
            /////////////////////////////////////////////////
            for (int i = 0; i < 12; i++)
            {
                products.Add(new Cake(new DateTime(2020, rand.Next(2, 4), rand.Next(1, 31))));
            }
            /////////////////////////////////////////////////
            ///
            for (int i = 0; i < 7; i++)
            {
                products.Add(new Chocolate(new DateTime(2020, rand.Next(2, 4), rand.Next(1, 31))));
            }

            /////////////////////////////////////////////////
            ///
            for (int i = 0; i < 9; i++)
            {
                products.Add(new Sausage(new DateTime(2020, rand.Next(2, 4), rand.Next(1, 31))));
            }
            ////////////////////////////////////////////////

            for (int i = 0; i < 9; i++)
            {
                products.Add(new Meat(new DateTime(2020, rand.Next(2, 4), rand.Next(1, 31))));
            }

            ////////////////////////////////////////////////

            for (int i = 0; i < 9; i++)
            {
                products.Add(new ToiletPaper(new DateTime(2020, rand.Next(2, 4), rand.Next(1, 31))));
            }
        }

        public void Decommissione()
        {
            Product product;
            int iter = 0;
            DateTime temp;
            int pastDueMilk = 0;
            int pastDueBread = 0;
            int pastDueCake = 0;
            int pastDueChocolate = 0;
            int pastDueMeat = 0;
            int pastDueSausage = 0;
            int pastDueToiletPaper = 0;
            int sum = 0;
            for (DateTime start = dataStart; ; iter++)
            {
                temp = start.AddDays(iter);
                if (temp.CompareTo(dataToday) == 0)
                {
                    break;
                }
                for (int i = 0; i < products.Count; i++)
                {
                    //////////// Milk  ////////////////////
                    if (products[i] is Milk)
                    {
                        int days = ((Milk)products[i]).shelfLife;

                        if (((Milk)products[i]).dateOfManufacture.AddDays(days) < temp)
                        {
                            //Console.WriteLine(((Milk)products[i]).dateOfManufacture + "   Milk");
                            products.RemoveAt(i);
                            pastDueMilk++;

                        }
                    }
                    //////////// Bread  ////////////////////
                    if (products[i] is Bread)
                    {
                        int days = ((Bread)products[i]).shelfLife;

                        if (((Bread)products[i]).dateOfManufacture.AddDays(days) < temp)
                        {
                            //Console.WriteLine(((Bread)products[i]).dateOfManufacture + "   Bread");
                            products.RemoveAt(i);
                            pastDueBread++;

                        }
                    }
                    //////////// Cake  ////////////////////
                    if (products[i] is Cake)
                    {
                        int days = ((Cake)products[i]).shelfLife;

                        if (((Cake)products[i]).dateOfManufacture.AddDays(days) < temp)
                        {
                            //Console.WriteLine(((Cake)products[i]).dateOfManufacture + "   Cake");
                            products.RemoveAt(i);
                            pastDueCake++;

                        }
                    }

                    //////////// Chocolate  ////////////////////
                    if (products[i] is Chocolate)
                    {
                        int days = ((Chocolate)products[i]).shelfLife;

                        if (((Chocolate)products[i]).dateOfManufacture.AddDays(days) < temp)
                        {
                            //Console.WriteLine(((Chocolate)products[i]).dateOfManufacture + "   Chocolate");
                            products.RemoveAt(i);
                            pastDueChocolate++;

                        }
                    }

                    //////////// Meat  ////////////////////
                    if (products[i] is Meat)
                    {
                        int days = ((Meat)products[i]).shelfLife;

                        if (((Meat)products[i]).dateOfManufacture.AddDays(days) < temp)
                        {
                            //Console.WriteLine(((Meat)products[i]).dateOfManufacture + "   Meat");
                            products.RemoveAt(i);
                            pastDueMeat++;
                        }
                    }

                    //////////// Meat  ////////////////////
                    if (products[i] is Sausage)
                    {
                        int days = ((Sausage)products[i]).shelfLife;

                        if (((Sausage)products[i]).dateOfManufacture.AddDays(days) < temp)
                        {
                            //Console.WriteLine(((Sausage)products[i]).dateOfManufacture + "   Sausage");
                            products.RemoveAt(i);
                            pastDueSausage++;
                        }
                    }

                    //////////// ToiletPaper  ////////////////////
                    if (products[i] is ToiletPaper)
                    {
                        int days = ((ToiletPaper)products[i]).shelfLife;

                        if (((ToiletPaper)products[i]).dateOfManufacture.AddDays(days) < temp)
                        {
                            //Console.WriteLine(((ToiletPaper)products[i]).dateOfManufacture + "   ToiletPaper");
                            products.RemoveAt(i);
                            pastDueToiletPaper++;
                        }
                    }                    

                }
                if (temp.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine("[From " + temp.AddDays(-6).ToString("dddd, dd MMMM yyyy") + "] to [" + temp.ToString("dddd, dd MMMM yyyy") + "] was decommissioned:");
                    

                    if (pastDueMilk > 0)
                    {
                        product = new Milk();
                        Console.WriteLine(pastDueMilk + " " + ((Milk)product).name + " " + (((Milk)product).Price)*pastDueMilk + " (UAH)");
                        
                        sum += (((Milk)product).Price) * pastDueMilk;
                        pastDueMilk = 0;
                    }

                    if (pastDueBread > 0)
                    {
                        product = new Bread();
                        Console.WriteLine(pastDueBread + " " + ((Bread)product).name + " " + (((Bread)product).Price) * pastDueBread + " (UAH)");
                        
                        sum += (((Bread)product).Price) * pastDueBread;
                        pastDueBread = 0;
                    }

                    if (pastDueCake > 0)
                    {
                        product = new Cake();
                        Console.WriteLine(pastDueCake + " " + ((Cake)product).name + " " + (((Cake)product).Price) * pastDueCake + " (UAH)");
                        
                        sum += (((Cake)product).Price) * pastDueCake;
                        pastDueCake = 0;
                    }

                    if (pastDueChocolate > 0)
                    {
                        product = new Chocolate();
                        Console.WriteLine(pastDueCake + " " + ((Chocolate)product).name + " " + (((Chocolate)product).Price) * pastDueChocolate + " (UAH)");
                        
                        sum += (((Chocolate)product).Price) * pastDueChocolate;
                        pastDueChocolate = 0;
                    }

                    if (pastDueMeat > 0)
                    {
                        product = new Meat();
                        Console.WriteLine(pastDueMeat + " " + ((Meat)product).name + " " + (((Meat)product).Price) * pastDueMeat + " (UAH)");
                        
                        sum += (((Meat)product).Price) * pastDueMeat;
                        pastDueMeat = 0;
                    }

                    if (pastDueSausage > 0)
                    {
                        product = new Sausage();
                        Console.WriteLine(pastDueSausage + " " + ((Sausage)product).name + " " + (((Sausage)product).Price) * pastDueSausage + " (UAH)");
                        
                        sum += (((Sausage)product).Price) * pastDueSausage;
                        pastDueSausage = 0;
                    }

                    if (pastDueToiletPaper > 0)
                    {
                        product = new ToiletPaper();
                        Console.WriteLine(pastDueToiletPaper + " " + ((ToiletPaper)product).name + " " + (((ToiletPaper)product).Price) * pastDueToiletPaper + " (UAH)");
                        
                        sum += (((ToiletPaper)product).Price) * pastDueToiletPaper;
                        pastDueToiletPaper = 0;
                    }
                    Console.WriteLine("Total weekly loss:" + sum + " (UAH)");
                    sum = 0;
                    Console.WriteLine("-----------------------------------------------------------------------");

                }
            }


        }

        public void showFreshProducts()
        {
            Product product;
            int countMilk = 0;
            int countBread = 0;
            int countCake = 0;
            int countChocolate = 0;
            int countMeat = 0;
            int countSausage = 0;
            int countToiletPaper = 0;

            Console.WriteLine("Today we have such fresh products:");

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i] is Bread)
                {
                    //Console.WriteLine( ((Bread)products[i]).name);
                    countBread++;
                }
                if (products[i] is Cake)
                {
                    //Console.WriteLine(((Cake)products[i]).name);
                    countCake++;
                }
                if (products[i] is Chocolate)
                {
                    //Console.WriteLine(((Chocolate)products[i]).name);
                    countChocolate++;
                }
                if (products[i] is Meat)
                {
                    //Console.WriteLine(((Meat)products[i]).name);
                    countMeat++;
                }
                if (products[i] is Milk)
                {
                    //Console.WriteLine(((Milk)products[i]).name);
                    countMilk++;
                }
                if (products[i] is Sausage)
                {
                    //Console.WriteLine(((Sausage)products[i]).name);
                    countSausage++;
                }
                if (products[i] is ToiletPaper)
                {
                    //Console.WriteLine(((ToiletPaper)products[i]).name);
                    countToiletPaper++;
                }
            }
            product = new Milk();
            Console.WriteLine(countMilk + " - " + ((Milk)product).name  + " ---------- " + ((Milk)product).Price + " (UAH)");

            product = new Bread();
            Console.WriteLine(countBread + " - " + ((Bread)product).name + " --------- " + ((Bread)product).Price + " (UAH)");

            product = new Cake();
            Console.WriteLine(countCake + " - " + ((Cake)product).name + " --------- " + ((Cake)product).Price + " (UAH)");

            product = new Chocolate();
            Console.WriteLine(countChocolate + " - " + ((Chocolate)product).name + " ----- " + ((Chocolate)product).Price + " (UAH)");

            product = new Meat();
            Console.WriteLine(countMeat + " - " + ((Meat)product).name + " --------- " + ((Meat)product).Price + " (UAH)");

            product = new Sausage();
            Console.WriteLine(countSausage + " - " + ((Sausage)product).name + " ------ " + ((Sausage)product).Price + " (UAH)");

            product = new ToiletPaper();
            Console.WriteLine(countToiletPaper + " - " + ((ToiletPaper)product).name + " -- " + ((ToiletPaper)product).Price + " (UAH)");

        }

        public void SaleToBuyer(Buyer buyer)
        {
            int countOfMilk=0, milkOfCheck = 0;
            int countOfBread=0, breadOfCheck = 0;
            int countOfCake=0, cakeOfCheck = 0;
            int countOfChocolate=0, chocolateOfCheck = 0;
            int countOfMeat=0, meatOfCheck = 0;
            int countOfSausage=0, sausageOfCheck = 0;
            int countOfToiletPaper=0, toiletPaperOfCheck = 0;
            int countCash = 0;
            int moneySpent = 0;




            int number = 1;

            for (int i = 0; i < buyer._listOfProducts.Count; i++)
            {
                
                if (buyer._listOfProducts[i] is Milk)
                {
                    //Console.WriteLine( ((Milk)buyer._listOfProducts[i]).name);
                    countCash += ((Milk)buyer._listOfProducts[i]).Price;
                    countOfMilk++;
                }
                if (buyer._listOfProducts[i] is Bread)
                {
                    //Console.WriteLine(((Bread)buyer._listOfProducts[i]).name);
                    countCash += ((Bread)buyer._listOfProducts[i]).Price;
                    countOfBread++;
                }
                if (buyer._listOfProducts[i] is Cake)
                {
                    //Console.WriteLine(((Cake)buyer._listOfProducts[i]).name);
                    countCash += ((Cake)buyer._listOfProducts[i]).Price;
                    countOfCake++;
                }
                if (buyer._listOfProducts[i] is Chocolate)
                {
                    //Console.WriteLine(((Chocolate)buyer._listOfProducts[i]).name);
                    countCash += ((Chocolate)buyer._listOfProducts[i]).Price;
                    countOfChocolate++;
                }
                if (buyer._listOfProducts[i] is Meat)
                {
                    //Console.WriteLine(((Meat)buyer._listOfProducts[i]).name);
                    countCash += ((Meat)buyer._listOfProducts[i]).Price;
                    countOfMeat++;
                }
                if (buyer._listOfProducts[i] is Sausage)
                {
                    //Console.WriteLine(((Sausage)buyer._listOfProducts[i]).name);
                    countCash += ((Sausage)buyer._listOfProducts[i]).Price;
                    countOfSausage++;
                }
                if (buyer._listOfProducts[i] is ToiletPaper)
                {
                    //Console.WriteLine(((ToiletPaper)buyer._listOfProducts[i]).name);
                    countCash += ((ToiletPaper)buyer._listOfProducts[i]).Price;
                    countOfToiletPaper++;
                }
            }

            Console.WriteLine("List of Buyer:");
            {
                if (countOfMilk > 0)
                {
                    Console.WriteLine(number + ") " + "Milk ---------- " + countOfMilk);
                    number++;
                }

                if (countOfBread > 0)
                {
                    Console.WriteLine(number + ") " + "Bread --------- " + countOfBread);
                    number++;
                }
                if (countOfCake > 0)
                {
                    Console.WriteLine(number + ") " + "Cake ---------- " + countOfCake);
                    number++;
                }
                if (countOfChocolate > 0)
                {
                    Console.WriteLine(number + ") " + "Chocolate ----- " + countOfChocolate);
                    number++;
                }
                if (countOfMeat > 0)
                {
                    Console.WriteLine(number + ") " + "Meat ---------- " + countOfMeat);
                    number++;
                }
                if (countOfSausage > 0)
                {
                    Console.WriteLine(number + ") " + "Sausage ------- " + countOfSausage);
                    number++;
                }
                if (countOfToiletPaper > 0)
                {
                    Console.WriteLine(number + ") " + "Toilet Paper -- " + countOfToiletPaper);
                    number++;
                }
            }
            Console.WriteLine("The buyer has " + countCash + " (UAH)");
            List<string> listBuyer = new List<string>();
            if (buyer._cash >= countCash)
            {
                for (int i = 0; i < buyer._listOfProducts.Count; i++)
                {
                    if (buyer._listOfProducts[i] is Milk)
                    {
                        for (int j = 0; j < products.Count; j++)
                        {
                            if (products[j] is Milk)
                            {
                                moneySpent += ((Milk)products[j]).Price;
                                milkOfCheck++;
                                products.RemoveAt(j);
 
                                 
                                
                                break;
                            }

                        }
                    }
                    if (buyer._listOfProducts[i] is Bread)
                    {
                        for (int j = 0; j < products.Count; j++)
                        {
                            if (products[j] is Bread)
                            {
                                moneySpent += ((Bread)products[j]).Price;
                                breadOfCheck++;
                                products.RemoveAt(j);
                                break;
                            }

                        }
                    }
                    if (buyer._listOfProducts[i] is Cake)
                    {
                        for (int j = 0; j < products.Count; j++)
                        {
                            if (products[j] is Cake)
                            {
                                moneySpent += ((Cake)products[j]).Price;
                                cakeOfCheck++;
                                products.RemoveAt(j);
                                break;
                            }

                        }
                    }
                    if (buyer._listOfProducts[i] is Chocolate)
                    {
                        for (int j = 0; j < products.Count; j++)
                        {
                            if (products[j] is Chocolate)
                            {
                                moneySpent += ((Chocolate)products[j]).Price;
                                chocolateOfCheck++;
                                products.RemoveAt(j);
                                break;
                            }

                        }
                    }
                    if (buyer._listOfProducts[i] is Meat)
                    {
                        for (int j = 0; j < products.Count; j++)
                        {
                            if (products[j] is Meat)
                            {
                                moneySpent += ((Meat)products[j]).Price;
                                meatOfCheck++;
                                products.RemoveAt(j);

                                break;
                            }

                        }
                    }
                    if (buyer._listOfProducts[i] is Sausage)
                    {
                        for (int j = 0; j < products.Count; j++)
                        {
                            if (products[j] is Sausage)
                            {
                                moneySpent += ((Sausage)products[j]).Price;
                                sausageOfCheck++;
                                products.RemoveAt(j);
                                
                                break;
                            }

                        }
                    }
                    if (buyer._listOfProducts[i] is ToiletPaper)
                    {
                        for (int j = 0; j < products.Count; j++)
                        {
                            if (products[j] is ToiletPaper)
                            {
                                moneySpent += ((ToiletPaper)products[j]).Price;
                                toiletPaperOfCheck++;
                                products.RemoveAt(j);
                                
                                break;
                            }
                        }
                    }
                }              
            }
            else
            {
                Console.WriteLine("You don’t have enough money. Go home");
            }
            Console.WriteLine();
            if (moneySpent > 0)
            {
                Console.WriteLine("Purchase check " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            }
            if (milkOfCheck > 0)
            {
                Console.WriteLine("Milk ------------ " + milkOfCheck);
            }
            if (breadOfCheck > 0)
            {
                Console.WriteLine("Bread-------------" + breadOfCheck);
            }
            if (cakeOfCheck > 0)
            {
                Console.WriteLine("Cake ------------ " + cakeOfCheck);
            }
            if (chocolateOfCheck > 0)
            {
                Console.WriteLine("Chocolate ------- " + chocolateOfCheck);
            }
            if (meatOfCheck > 0)
            {
                Console.WriteLine("Meat -------------" + meatOfCheck);
            }
            if (sausageOfCheck > 0)
            {
                Console.WriteLine("Sausage ----------" + sausageOfCheck);
            }
            if (toiletPaperOfCheck > 0)
            {
                Console.WriteLine("Toilet Paper ---- " + toiletPaperOfCheck);
            }



            if (moneySpent > 0)
            {
                Console.WriteLine("You spent  " + moneySpent + " (UAH)");

                if (countOfMilk != milkOfCheck)
                {
                    Console.WriteLine("Sorry, " + (countOfMilk - milkOfCheck) + " of milk were not found.");
                }
                if (countOfBread != breadOfCheck)
                {
                    Console.WriteLine("Sorry, " + (countOfBread - breadOfCheck) + " bread of milk were not found.");
                }
                if (countOfCake != cakeOfCheck)
                {
                    Console.WriteLine("Sorry, " + (countOfCake - cakeOfCheck) + " cake of milk were not found.");
                }
                if (countOfChocolate != chocolateOfCheck)
                {
                    Console.WriteLine("Sorry, " + (countOfChocolate - chocolateOfCheck) + " chocolate of milk were not found.");
                }
                if (countOfMeat != meatOfCheck)
                {
                    Console.WriteLine("Sorry, " + (countOfMeat - meatOfCheck) + " meat of milk were not found.");
                }
                if (countOfSausage != sausageOfCheck)
                {
                    Console.WriteLine("Sorry, " + " sausage of milk were not found.");
                }
                if (countOfToiletPaper != toiletPaperOfCheck)
                {
                    Console.WriteLine("Sorry, " + " toilet aper of milk were not found.");
                }
            }
        }
    }
}
