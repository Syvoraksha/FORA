using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORA
{
    class Milk: Product
    {
        public string name = "Milk";

        public DateTime dateOfManufacture;
        

        private int price;
        public int Price
        {
            get { return 24; }
        }

        public int shelfLife =5;
 


        public Milk(DateTime _dateOfManufacture)
        {
            dateOfManufacture = _dateOfManufacture;

        }
        public Milk()
        {
        }
    }
}
