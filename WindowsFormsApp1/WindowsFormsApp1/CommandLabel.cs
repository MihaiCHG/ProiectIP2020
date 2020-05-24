/* Fisier creat de Heghea Mihail-Cristian si implementat de Tanasa Ionut-Ciprian si Heghea Mihail-Cristian
 * Fisierul contine clasa 'CommandLabel' folosita pentru a afisa pe interfata comnenzile
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Restaurant;

namespace Restaurant
{
    //Impelemntare Heghea Mihail-Cristian, pana la functia buttonResolve_Click
    public class CommandLabel
    {
        private Command _command;
        private Label _commandDesc;
        private Button _buttonResolve;
        private Presenter _presenter;
        private Panel _panel;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="presenter"></param>
        /// <param name="x">Pozitia pe x a controalelor(un offset)</param>
        /// <param name="y">Pozitia pe y a controalelor(un offset)</param>
        /// <param name="command">Comanda ce va fi afisata pe interfata</param>
        /// <param name="panel">Panel-ul in care vor fi adaugate controalele</param>
        public CommandLabel(IPresenter presenter, int x, int y, Command command, Panel panel)
        {
            _presenter = (Presenter)presenter;

            _command = command;
            _panel = panel;
            //Se creaza un label in care va fi afisata descrierea comenzii.
            _commandDesc = new Label();
            _commandDesc.AutoSize = true;//Label-ul isi va lua dimensiunile in functie de textul pe care il va contine
            _commandDesc.Location = new System.Drawing.Point(x * 10, y * 50 + 25);//Se pozitioneaza label-ul in panel
            List<Produs> prods = _command.CommandList;
            string desc = "Nr Masa: " + _command.NrMasa + ". -";
            for (int i = 0; i < prods.Count; i++)
                desc += prods[i].Nume + "-";// Se contruieste descrierea comenzii
            _commandDesc.Text = desc;//Se pune in text-ul label-ului descrierea comenzii

            //Se creaza un buton ce va fi folosit pentru stergerea comenzii, atunci cand ea este rezolvata.
            _buttonResolve = new Button();
            _buttonResolve.Text = "Comanda este gata";
            _buttonResolve.AutoSize = true;
            _buttonResolve.Location = new System.Drawing.Point(x * 10 + 200, y * 50 + 75);
            _buttonResolve.Click += new System.EventHandler(this.buttonResolve_Click);// Seteaza handler-ul care este apelat la apasarea butonului
            panel.Controls.Add(_commandDesc);
            panel.Controls.Add(_buttonResolve);
            //Controalele sunt adaugate in panel-ul pentru comenzi, primit ca parametru in constructor.
        }
        //Implementare Tanasa Ionut-Ciprian:
        private void buttonResolve_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter.deleteCommand(_command);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Eroare la stergerea comenzii din baza de date:\r\n" + sqlEx.Message, "Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            _panel.Controls.Remove(_commandDesc);
            _panel.Controls.Remove(_buttonResolve);
        }
    }
}