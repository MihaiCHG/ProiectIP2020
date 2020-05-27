/* Fisier creat si implementa de Heghea Mihail-Cristian.
 * Fisierul contine clasa 'ComboboxProducts'.
 * Aceasta clasa este folosita pentru a adauga in mod dinamic pe interfata tipurile de produse cu cate un combobox cu produsele de acel tip.
 * Produsele pot fi adaugate intr-o lista, ce ulterior poate fi adaugat intr-o comanda.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant;

namespace Restaurant
{
    public class ComboboxProducts
    {
        private Label _productTypeName;
        private ComboBox _comboboxProducts;
        private Button _buttonAdd;
        private ListBox _listBoxProducts;
        /// <summary>
        /// Constructorul
        /// </summary>
        /// <param name="x">pozitia pe x in panel</param>
        /// <param name="y">pozitia pe y in panel</param>
        /// <param name="_products">tipul de produs ce urmeaza a fi afisat pe interfata</param>
        /// <param name="panel">Panel-ul din interfata pe care vor fi adaugate controalele</param>
        /// <param name="listBoxProducts">Lista de produse, unde se vor adauga produsele atunci cand se apasa pe butoanele 'Adauga'.</param>
        public ComboboxProducts(int x, int y, TipProdus _products, Panel panel, ListBox listBoxProducts)
        {

            _listBoxProducts = listBoxProducts;
            //Se creaza un label pentru a afisa pe interfata denumirea tipului de produse
            _productTypeName = new Label();
            _productTypeName.AutoSize = true;//Controlul isi va lua singur dimensiunile in funtie de lungimea sirului de caractere care contine denumirea
            _productTypeName.Location = new System.Drawing.Point(x * 10, y * 50+25);// Seteaza pozitia label-ului in panel.
            _productTypeName.Text = _products.Name;//Seteaza textul label-ului

            //Se creaza un combobox din care se poate alege un produs de tipul respectiv de produs.
            _comboboxProducts = new ComboBox();
            _comboboxProducts.AutoSize = true;
            _comboboxProducts.Location = new System.Drawing.Point(x * 10+ 100, y * 50+25);
            List<Produs> productList = _products.GetProducts;
            for(int i = 0; i < productList.Count; i++)
            {
                _comboboxProducts.Items.Add(productList[i].Nume);//Se adauga in ComboBox optiunile, acestea find produsele de acel tip.
            }

            //Se creaza un buton pentru a adauga produsul ales din combobox in lista de produse.
            _buttonAdd = new Button();
            _buttonAdd.Text = "Adauga";
            _buttonAdd.AutoSize=true;
            _buttonAdd.Location = new System.Drawing.Point(x * 10 + 270, y * 50+25);
            _buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);// Seteaza handler-ul care este apelat atunci cand se apasa Click pe acest buton.
            panel.Controls.Add(_productTypeName);
            panel.Controls.Add(_comboboxProducts);
            panel.Controls.Add(_buttonAdd);
            //Controalele sunt adaugate in panel
        }
        /// <summary>
        /// Functia de call back apelata atunci cand se apasa pe butonul 'Adauga'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string str = _comboboxProducts.SelectedItem.ToString();//Se oreia produlul selectat din combobox.
                _listBoxProducts.Items.Add(str);//Se adauga produsul in lista de produse
                _comboboxProducts.SelectedItem = null;//Se deselecteaza prodului din combobox.
            }
            catch(Exception exception)
            {
                MessageBox.Show("Trebuie sa alegi un produs pentru a-l adauga in lista.");// In caz de vreo exceptie va aparea acest mesaj
            }
        }
    }
}
