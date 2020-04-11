using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORA
{
    class ListGenerator
    {
        public static List<Product> ListOfProduct(int[] arrCount)
        {
            List<Product> list = new List<Product>();
            Random random = new Random();
            for (int i = 0; i < arrCount[0]; i++)
            {
                list.Add(new Milk());
            }

            for (int i = 0; i < arrCount[1]; i++)
            {
                list.Add(new Bread());
            }

            for (int i = 0; i < arrCount[2]; i++)
            {
                list.Add(new Cake());
            }

            for (int i = 0; i < arrCount[3]; i++)
            {
                list.Add(new Chocolate());
            }

            for (int i = 0; i < arrCount[4]; i++)
            {
                list.Add(new Meat());
            }

            for (int i = 0; i < arrCount[5]; i++)
            {
                list.Add(new Sausage());
            }

            for (int i = 0; i < arrCount[6]; i++)
            {
                list.Add(new ToiletPaper());
            }

            return list;
        }
    }
}
