using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Model: IModel
    {
        private List<Produs> _commands;
        private Meniu _menu;
        public Model()
        {
            _commands = new List<Produs>();
        }
        private void loadMenu()
        {
            
        }
        public Meniu Menu
        {
            get => _menu;
        }
        public List<Produs> Commands
        {
            get => _commands;
        }
        public void addCommand(Command cmd)
        {

        }
        public void deleteCommand(Command cmd)
        {

        }
    }
}
