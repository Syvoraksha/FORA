using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORA
{
    class Sausage: Product
    {
        public string name = "Sausage";

        public DateTime dateOfManufacture;


        private int price;
        public int Price
        {
            get { return 113; }
        }

        public int shelfLife = 21;


        public Sausage(DateTime _dateOfManufacture)
        {
            this.dateOfManufacture = _dateOfManufacture;
        }

        public Sausage()
        {

        }
    }
}
