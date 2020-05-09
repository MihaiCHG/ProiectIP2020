using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Meniu
    {
        private List<Produs> fel1;
        private List<Produs> fel2;
        private List<Produs> fel3;
        public string Fel1
        {
            get
            {
                string str = "";
                foreach(Produs p in fel1)
                {
                    str += p.ToString()+"\r\n";
                }
                return str;
            }
        }
        public string Fel2
        {
            get
            {
                string str = "";
                foreach (Produs p in fel2)
                {
                    str += p.ToString() + "\r\n";
                }
                return str;
            }
        }
        public string Fel3
        {
            get
            {
                string str = "";
                foreach (Produs p in fel3)
                {
                    str += p.ToString() + "\r\n";
                }
                return str;
            }
        }
    }
}
