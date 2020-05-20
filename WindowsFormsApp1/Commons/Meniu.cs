using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Meniu
    {
        private static Meniu _instance = null;
        private List<Produs> _productList;

        private Meniu()
        {
            _productList = new List<Produs>();
            SpaghettiCarbonara sc = new SpaghettiCarbonara();
            _productList.Add(sc);
        }
        public List<Produs> ProductList
        {
            get => _productList;
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
