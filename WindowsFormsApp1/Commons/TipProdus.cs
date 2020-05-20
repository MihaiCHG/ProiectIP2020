using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class TipProdus
    {
        protected List<Produs> _products;
        public string ShowProducts()
        {
            string products = "";
            for(int i = 0; i < _products.Count; i++)
            {
                products += _products[i].descriere() + "\n";
            }
            return products;
        }
    }

}
