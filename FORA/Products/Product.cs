using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORA
{
    abstract class Product
    {
        public string name ="product";
       
        public DateTime dateOfManufacture;

        private int price;

        public int Price
        {
            get { return price; }
        }

        private int shelfLife;
        public int ShelfLife
        {
            get { return shelfLife; }
        }


    }
}
