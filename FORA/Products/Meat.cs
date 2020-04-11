using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORA
{
    class Meat: Product
    {
        public string name = "Meat";

        public DateTime dateOfManufacture;
       
        private int price;
        public int Price
        {
            get { return 197; }
        }

        public int shelfLife = 5;



        public Meat(DateTime _dateOfManufacture)
        {
            this.dateOfManufacture = _dateOfManufacture;
        }
        public Meat()
        {

        }
    }
}
