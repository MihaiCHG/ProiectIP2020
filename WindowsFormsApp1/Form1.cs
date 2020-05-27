using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant
{
    public partial class Form1 : Form, IView
    {
        private IPresenter _presenter;
        private IModel _model;
        private int nrOfCommands = 0;
        private Meniu _meniu;
        public Form1()
        {
            try
            {
                _model = new Model();
                _presenter = new Presenter(this, _model);
                InitializeComponent();
                SetPresenter(_presenter);
                SetModel(_model);
                panelEmployee.Visible = false;
                _meniu = Meniu.GetInstance();
                initControls();
                loadCommandsFromDB();
            } catch (SqlException sqlEx)
            {
                MessageBox.Show("Eroare la deschiderea bazei de date:\r\n" + sqlEx.Message, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        public void closeApp()
        {
            ((Model)_model).Disconnect();
        }
        private void initControls()
        {
            //Implementare Heghea Mihail-Cristian
            for(int i = 0; i < _meniu.ProductList.Count; i++)
            {// se parcurge lista de tipuri de produse si se creaza un obiect ComboboxProducts folosit pentru a afisa tipurile de prosuse impreuna cu
                // produsele in panel-ul de meniu.
                TipProdus productsType = _meniu.ProductList[i];
                ComboboxProducts comboboxProduct = new ComboboxProducts(1, i, productsType, panelMeniu, listBoxComenzi);
            }
        }
        private void loadCommandsFromDB()
        {
            try { 
                List<string> commandsFromDB = _model.Commands;
                foreach(string commandStr in commandsFromDB)
                {
                    nrOfCommands++;
                    //creare lista de Produs cu pentru comenzile stocate in baza de date
                    List<Produs> productList = new List<Produs>();
                    //Sirul de carctere cu datele din baza de date este de forma:
                    //id#lista de produse#Pret comanda-NrMasa
                    string[] productListStr = commandStr.Split('#');
                    string[] productListStr2 = productListStr[1].Split('-');
                    string[] infoCommandStr = productListStr[2].Split('-');
                    foreach (string p in productListStr2)
                    {
                        //se obtine din meniu produsul dupa nume si se adauga in lista de Produse
                        Produs pr = _presenter.getProductByName(p);
                        if(pr != null)
                            productList.Add(pr);
                    }
                    //creare comanda si setarea detaliilor acesteia
                    Command command = new Command(productList);
                    command.PretComanda = Convert.ToDouble(infoCommandStr[0]);
                    command.NrMasa = Convert.ToInt32(infoCommandStr[1]);
                
                    CommandLabel cl = new CommandLabel(_presenter, 0, nrOfCommands, command, panelEmployee);
                }
            } catch (SqlException sqlEx)
            {
                MessageBox.Show("Eroare la citirea comenzilor din baza de date: \r\n" + sqlEx.Message, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetModel(IModel model)
        {
            _model = model;
        }
        public void SetPresenter(IPresenter presenter)
        {
            _presenter = presenter;
        }
        public void Display()
        {

        }
        public void SetPresenter()
        {

        }

        private void clentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelEmployee.Visible = false;
            panelMeniu.Visible = true;
        }

        private void labelGustariReci_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            nrOfCommands++;
            List<Produs> produseComanda = new List<Produs>();
            
            foreach(string com in listBoxComenzi.Items)
            {
                Produs p = _presenter.getProductByName(com);
                produseComanda.Add(p);
            }
            Command c = new Command(produseComanda);
            CommandLabel cl = new CommandLabel(_presenter,0,nrOfCommands,c,panelEmployee);
            try
            {
                _presenter.addCommand(c);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Eroare la adaugarea comenzii in baza de date:\r\n" + sqlEx.Message, "EROARE", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            listBoxComenzi.Items.Clear();
        }

/*        private void buttonGustariReci_Click(object sender, EventArgs e)
        {
            string str = comboBoxGustariReci.SelectedItem.ToString();
            listBoxComenzi.Items.Add(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = comboBoxPaste.SelectedItem.ToString();
            listBoxComenzi.Items.Add(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = comboBoxSupe.SelectedItem.ToString();
            listBoxComenzi.Items.Add(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = comboBoxPui.SelectedItem.ToString();
            listBoxComenzi.Items.Add(str);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = comboBoxPorc.SelectedItem.ToString();
            listBoxComenzi.Items.Add(str);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = comboBoxDesert.SelectedItem.ToString();
            listBoxComenzi.Items.Add(str);
        }
        */
        private void angajatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelEmployee.Visible = true;
            panelMeniu.Visible = false;
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicatie pentru gestionarea comenzilor unui restaurant.", "Despre");
        }

        private void manualDeUtilizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "HelpProject.chm");
        }
    }
}
