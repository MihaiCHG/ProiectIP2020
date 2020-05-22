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
        public ComboboxProducts(int x, int y, TipProdus _products, Panel panel, ListBox listBoxProducts)
        {

            _listBoxProducts = listBoxProducts;
            _productTypeName = new Label();
            _productTypeName.AutoSize = true;
            _productTypeName.Location = new System.Drawing.Point(x * 10, y * 50+25);
            _productTypeName.Text = _products.Name;

            _comboboxProducts = new ComboBox();
            _comboboxProducts.AutoSize = true;
            _comboboxProducts.Location = new System.Drawing.Point(x * 10+ 100, y * 50+25);
            List<Produs> productList = _products.GetProducts;
            for(int i = 0; i < productList.Count; i++)
            {
                _comboboxProducts.Items.Add(productList[i].Nume);
            }

            _buttonAdd = new Button();
            _buttonAdd.Text = "Adauga";
            _buttonAdd.AutoSize=true;
            _buttonAdd.Location = new System.Drawing.Point(x * 10 + 270, y * 50+25);
            _buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            panel.Controls.Add(_productTypeName);
            panel.Controls.Add(_comboboxProducts);
            panel.Controls.Add(_buttonAdd);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string str = _comboboxProducts.SelectedItem.ToString();
                _listBoxProducts.Items.Add(str);
                _comboboxProducts.SelectedItem = null;
            }
            catch(Exception exception)
            {
                MessageBox.Show("Trebuie sa alegi un produs pentru a-l adauga in lista.");
            }
        }
    }
}
