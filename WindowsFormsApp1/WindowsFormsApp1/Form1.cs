using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private int nrOfCommands = 0;
        private Meniu _meniu;
        public Form1()
        {
            _model = new Model();
            _presenter = new Presenter(this, _model);
            InitializeComponent();
            SetPresenter(_presenter);
            SetModel(_model);
            panelEmployee.Visible = false;
            _meniu = Meniu.GetInstance();
            initControls();
        }
        private void initControls()
        {
            for(int i = 0; i < _meniu.ProductList.Count; i++)
            {
                TipProdus productsType = _meniu.ProductList[i];
                ComboboxProducts comboboxProduct = new ComboboxProducts(1, i, productsType, panelMeniu, listBoxComenzi);
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
            CommandLabel cl = new CommandLabel(0,nrOfCommands,c,panelEmployee);
            _presenter.addCommand(c);
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
    }
}
