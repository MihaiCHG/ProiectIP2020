using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Presenter: IPresenter
    {
        private IModel _model;
        private IView _view;
        public Presenter(IView view, IModel model)
        {
            _model = model;
            _view = view;
        }
        public void addCommand(Command command)
        {
            double pret = 0.0;
            foreach(Produs p in command.CommandList)
            {
                pret += p.Pret;
            }
            command.PretComanda = pret;
            _model.addCommand(command);
        }
        public void deleteCommand(Command command)
        {
            _model.deleteCommand(command);
        }
        public void showCommands()
        {
            _view.Display();
        }
        public Produs getProductByName(string productName)
        {
            foreach(Produs p in _model.Menu.ProductList)
            {
                if (p.Nume == productName)
                    return p;
            }
            return null;
        }
    }
}
