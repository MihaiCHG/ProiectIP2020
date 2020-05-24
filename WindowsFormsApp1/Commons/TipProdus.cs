/*
 * Fisier creat si implementat de Heghea Mihail-Cristian.
 * Contine clasa TipProdus, aceasta clasa contine o lista cu produsele de acel tip si denumirea tipului de produse.
 */

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
        public string ShowProducts()//intoarce un sir de caractere cu produsele din acest tip de produse.
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
            get=> _name;// getter pentru _nume
        }
        public List<Produs> GetProducts
        {
            get => _products;// getter pentru lista de produse
        }

        public void AddProduct(Produs p)
        {
            _products.Add(p);// se adauga produse in lista de produse
        }
    }

}