using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pim1
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingSourceProdutos_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_EditProduct Form_EditProduct = new Form_EditProduct();


            Form_EditProduct.Show();
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            // Defina a fonte de dados do BindingSource como a lista de produtos
            bindingSourceProdutos.DataSource = DadosMercado.GetAll();
        }
    

    }
}
