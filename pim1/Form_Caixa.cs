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
    public partial class Form_Caixa : Form
    {
        public Form_Caixa()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;

           // Produto produto;

            foreach (var produto in DadosMercado.Produtos)
            {
                if (produto.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    decimal preco = decimal.Parse(totalpreco.Text);
                    decimal precototal = produto.Preco + preco;

                    totalpreco.Text = precototal.ToString("F2");
                    break; // Sai do loop se o produto foi encontrado
                }
            }
        }

        private void Form_Caixa_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = DadosMercado.GetAll();

            bindingSource1.ResetBindings(false);
        }
    }
}
