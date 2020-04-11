using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORA
{
    class Cake: Product
    {
        public string name = "Cake";

        public DateTime dateOfManufacture;
        

        private int price;
        public int Price
        {
            get { return 132; }
        }

        public int shelfLife = 5;



        public Cake(DateTime _dateOfManufacture)
        {
            this.dateOfManufacture = _dateOfManufacture;
        }
        public Cake()
        {

        }
    }
}
