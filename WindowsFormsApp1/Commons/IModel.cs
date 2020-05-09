using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public interface IModel
    {
        List<Produs> Commands { get ;}
        Meniu Menu { get; }
        void addCommand(Command comm);
        void deleteCommand(Command comm);
    }
}
