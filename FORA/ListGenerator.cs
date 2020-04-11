using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORA
{
    class ListGenerator
    {
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
