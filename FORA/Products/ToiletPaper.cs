using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORA
{
    class ToiletPaper: Product
    {
        public string name = "Toilet Paper";

        public DateTime dateOfManufacture;


        private int price;
        public int Price
        {
            get { return 14; }
        }

        public int shelfLife = 720;


        public ToiletPaper(DateTime _dateOfManufacture)
        {
            this.dateOfManufacture = _dateOfManufacture;
        }

        public ToiletPaper()
        {

        }
    }
}
