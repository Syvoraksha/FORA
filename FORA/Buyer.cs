using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORA
{
    class Buyer
    {
        public List<Product> _listOfProducts = new List<Product>();
        public int _cash;

        public Buyer(List<Product> listOfProducts, int cash)
        {
            this._listOfProducts = listOfProducts;
            this._cash = cash;
        }
    }
}
