using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Command
    {
        private List<Produs> _command;
        private double pret;
        public double PretComanda
        {
            get => pret;
            set => pret = value;
        }
        public List<Produs> CommandList
        {
            get => _command;
        }
        public void addProduct(Produs p)
        {
            _command.Add(p);
        }
    }
}
