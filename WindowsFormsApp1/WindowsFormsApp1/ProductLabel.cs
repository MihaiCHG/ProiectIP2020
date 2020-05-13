using Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ProductLabel : Control
    {

        private System.Windows.Forms.Label _prodName;
        private System.Windows.Forms.Label _description;
        private System.Windows.Forms.Label _pret;
        private Produs _product;

        public ProductLabel(int x, int y, Produs product, Control control)
        {
            _product = product;
            _prodName = new Label();
            _description = new Label();
            _pret = new Label();
            _prodName.Location = new System.Drawing.Point(x*10, y*75);
            _prodName.AutoSize = true;
            _description.Location = new System.Drawing.Point(x*10 + 5, y*75 + 25);
            _description.AutoSize = true;
            _pret.Location = new System.Drawing.Point(x*10, y*75 + 50);
            _pret.AutoSize = true;
            _prodName.Text = _product.Nume;
            _description.Text = _product.descriere();
            _pret.Text = _product.Pret.ToString() + " lei";
            control.Controls.Add(_prodName);
            control.Controls.Add(_description);
            control.Controls.Add(_pret);
        }

    }
}
