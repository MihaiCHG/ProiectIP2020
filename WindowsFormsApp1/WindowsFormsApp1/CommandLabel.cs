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
        private Presenter _presenter;
        private Panel _panel;
        public CommandLabel(IPresenter presenter, int x, int y, Command command, Panel panel)
        {
            _presenter = (Presenter)presenter;

            _command = command;
            _panel = panel;
            _commandDesc = new Label();
            _commandDesc.AutoSize = true;
            _commandDesc.Location = new System.Drawing.Point(x * 10, y * 50 + 25);
            List<Produs> prods = _command.CommandList;
            string desc = "Nr Masa: " + _command.NrMasa + ". -";
            for (int i = 0; i < prods.Count; i++)
                desc += prods[i].Nume + "-";
            _commandDesc.Text = desc;
            _buttonResolve = new Button();
            _buttonResolve.Text = "Comanda este gata";
            _buttonResolve.AutoSize = true;
            _buttonResolve.Location = new System.Drawing.Point(x * 10 + 200, y * 50 + 75);
            _buttonResolve.Click += new System.EventHandler(this.buttonResolve_Click);
            panel.Controls.Add(_commandDesc);
            panel.Controls.Add(_buttonResolve);
        }
        private void buttonResolve_Click(object sender, EventArgs e)
        {
            _presenter.deleteCommand(_command);
            _panel.Controls.Remove(_commandDesc);
            _panel.Controls.Remove(_buttonResolve);
        }
    }
}