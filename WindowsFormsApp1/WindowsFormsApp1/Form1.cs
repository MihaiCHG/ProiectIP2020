using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Restaurant
{
    public partial class Form1 : Form, IView
    {
        private IPresenter _presenter;
        private IModel _model;
        private List<Label> prods;
        private int nrOfCommands = 0;
        public Form1()
        {
            _model = new Model();
            _presenter = new Presenter(this, _model);
            InitializeComponent();
            SetPresenter(_presenter);
            SetModel(_model);
            //Pentru meniu, se va face cate un TapPage pentru fiecare tip de produs, iar in fiecare tabPage se vor pune produsele din tipul respectiv.
            //Asta se va face din mvc, cred:))
            /*Produs prod = new SpaghettiCarbonara();
            ProductLabel p = new ProductLabel(1, 0, prod, tabPage);
            Produs prod2 = new TortCuCiocolata();
            ProductLabel p2 = new ProductLabel(1, 10, prod2, tabPage);*/
            initControls();
        }
        private void initControls()
        {
            comboBoxPaste.Items.Add("Spaghetti Carbonara");
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
            CommandLabel cl = new CommandLabel(0,nrOfCommands,c,panelEmployee);
            _presenter.addCommand(c);
        }

        private void buttonGustariReci_Click(object sender, EventArgs e)
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

        private void angajatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelEmployee.Visible = true;
            panelMeniu.Visible = false;
        }
    }
}
