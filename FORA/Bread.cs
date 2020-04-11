using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORA
{
    class Bread: Product
    {
        public string name = "Bread";

        public DateTime dateOfManufacture;


        private int price;
        public int Price
        {
            get { return 12; }
        }

        public int shelfLife = 3;
        


        public Bread(DateTime _dateOfManufacture)
        {
            this.dateOfManufacture = _dateOfManufacture;
        }
        public Bread()
        {
        }
    }
}
