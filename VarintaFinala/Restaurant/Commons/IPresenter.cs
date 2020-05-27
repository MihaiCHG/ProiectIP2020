using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public interface IPresenter
    {
        //Meniu Menu { get; }
        void addCommand(Command command);
        void deleteCommand(Command command);
        Produs getProductByName(String productName);
    }
}
