/*
	Fisier creat de Tanasă Ciprian-Ionut
	Acest fisier contine partea de presenter
	din arhitectura MVP care apeleaza metodele
	de adaugare si stergere a comenzilor in/din baza
	de date
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
            try
            {
                _model.addCommand(command);
            }
            catch (SqlException sqlEx)
            {
                throw sqlEx;
            }
        }
        public void deleteCommand(Command command)
        {
            try
            {
                _model.deleteCommand(command);
            }
            catch (SqlException sqlEx)
            {
                throw sqlEx;
            }
        }
        public void showCommands()
        {
            _view.Display();
        }
        public Produs getProductByName(string productName)
        {
            foreach(TipProdus prodType in _model.Menu.ProductList){
                foreach (Produs p in prodType.GetProducts)
                {
                    if (p.Nume == productName)
                        return p;
                }
            }
            return null;
        }
    }
}
