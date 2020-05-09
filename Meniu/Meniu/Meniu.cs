using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class Meniu
    {
        private static Meniu _instance=null;
        private List<TipProdus> _productList;


        private Meniu()
        {

        }

        public static Meniu GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Meniu();
            }
            return _instance;
        }
    }
}
