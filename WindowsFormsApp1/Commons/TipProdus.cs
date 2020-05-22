using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class TipProdus
    {
        protected List<Produs> _products;
        protected string _name;

        public TipProdus(string name)
        {
            _products = new List<Produs>();
            _name = name;
        }
        public string ShowProducts()
        {
            string products = "";
            for (int i = 0; i < _products.Count; i++)
            {
                products += _products[i].descriere() + "\n";
            }
            return products;
        }

        public string Name
        {
            get=> _name;
        }
        public List<Produs> GetProducts
        {
            get => _products;
        }

        public void AddProduct(Produs p)
        {
            _products.Add(p);
        }
    }

}