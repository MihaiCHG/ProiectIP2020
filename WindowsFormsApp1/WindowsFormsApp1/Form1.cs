using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form, IView
    {
        private IPresenter _presenter;
        private IModel _model;
        public Form1()
        {
            InitializeComponent();
            SetPresenter(_presenter);
            SetModel(_model);
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
    }
}
