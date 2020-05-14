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
        public Form1()
        {
            InitializeComponent();
            SetPresenter(_presenter);
            SetModel(_model);
            //Pentru meniu, se va face cate un TapPage pentru fiecare tip de produs, iar in fiecare tabPage se va pune produsele din tipul respectiv.
            //Asta se va face din mvc, cred:))
            Produs prod = new SpaghettiCarbonara();
            ProductLabel p = new ProductLabel(1, 0, prod, tabPage);
            Produs prod2 = new TortCuCiocolata();
            ProductLabel p2 = new ProductLabel(1, 10, prod2, tabPage);


            //Pentru creare comanda:
            //Trebuie sa se adauge cate un label si cate un combobox cu produsele din acel tip in mod dinamic, in functie de cate tipuri de produse exista
            Label numeTipProd = new Label();
            numeTipProd.Text = "TipProdus1";
            numeTipProd.Location = new Point(0, 50);
            ComboBox tipProdus1 = new ComboBox();
            tipProdus1.Location = new Point(100, 50);
            tipProdus1.Items.Add("Produs 1");
            tipProdus1.Items.Add("Produs 2");
            panelAddCommand.Controls.Add(tipProdus1);
            panelAddCommand.Controls.Add(numeTipProd);

            //Pentru a vizualiza comenzile

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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            panelEmployee.Visible = false;
            panelAddCommand.Visible = false;
            panelMeniu.Visible = true;
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            panelEmployee.Visible = true;
            panelAddCommand.Visible = false;
            panelMeniu.Visible = false;
        }

        private void buttonAddCommand_Click(object sender, EventArgs e)
        {
            panelEmployee.Visible = false;
            panelAddCommand.Visible = true;
            panelMeniu.Visible = false;
        }
    }
}
