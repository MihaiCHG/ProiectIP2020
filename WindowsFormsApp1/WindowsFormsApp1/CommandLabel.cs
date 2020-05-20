using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant;

namespace Restaurant
{
    public class CommandLabel
    {
        private Command _command;
        private Label _commandDesc;
        private Button _buttonResolve;
        public CommandLabel(int x, int y, Command command, Panel panel)
        {
            _command = command;
            _commandDesc = new Label();
            _commandDesc.AutoSize = true;
            _commandDesc.Location = new System.Drawing.Point(x * 10, y * 50+25);
            List<Produs> prods = _command.CommandList;
            string desc = "Nr Masa: "+ _command.NrMasa+". -";
            for (int i = 0; i < prods.Count; i++)
                desc += prods[i].Nume + "-";
            _commandDesc.Text = desc;
            _buttonResolve = new Button();
            _buttonResolve.Name = "Comanda este gata";
            _buttonResolve.AutoSize=true;
            _buttonResolve.Location = new System.Drawing.Point(x * 10 + 100, y * 50 + 50);
            _buttonResolve.Click += new System.EventHandler(this.buttonResolve_Click);
            panel.Controls.Add(_commandDesc);
            panel.Controls.Add(_buttonResolve);
        }
        private void buttonResolve_Click(object sender, EventArgs e)
        {
            //De sters comanda si actualizat panel-ul
        }
    }
}
