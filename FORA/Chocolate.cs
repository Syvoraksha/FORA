using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORA
{
    class Chocolate: Product
    {
        public string name = "Chocolate";

        public DateTime dateOfManufacture;


        private int price;
        public int Price
        {
            get { return 33; }
        }

        public int shelfLife = 90;


        public Chocolate(DateTime _dateOfManufacture)
        {
            this.dateOfManufacture = _dateOfManufacture;
        }

        public Chocolate()
        {
        }
    }
}
