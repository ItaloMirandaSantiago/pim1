using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pim1
{
    public partial class Form_EditProduct : Form
    {
        public Form_EditProduct()
        {
            InitializeComponent();
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            // Pegar os valores dos inputs
            string nome = textBox1.Text; // Nome do produto

            string apenasNumeros = Regex.Replace(maskedTextBox2.Text, "[^0-9,]", "");

            decimal preco;
            if (!decimal.TryParse(maskedTextBox2.Text.Substring(3), out preco))
            {
                MessageBox.Show("Preço inválido! Insira um valor numérico." + maskedTextBox2.Text.Substring(3));
                return; // Interrompe a execução se o valor for inválido
            }

            int quantidade;
            if (!int.TryParse(maskedTextBox1.Text, out quantidade))
            {
                MessageBox.Show("Quantidade inválida! Insira um número inteiro." + maskedTextBox1.Text);
                return; // Interrompe a execução se o valor for inválido
            }


            // Criar o produto usando a função CreateProduct
            DadosMercado.CreateProduct(nome, preco, quantidade);
            
            produtoBindingSource.DataSource = DadosMercado.GetAll();

            produtoBindingSource.ResetBindings(false);



            textBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox1.Clear();
            textBox1.Focus();

        }






        private void produtoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Produto produtoSelecionado = produtoBindingSource.Current as Produto;

            if (produtoSelecionado != null)
            {
                // Exibe os detalhes do produto selecionado nos controles da interface
                textBox1.Text = produtoSelecionado.Nome;
                maskedTextBox2.Text = produtoSelecionado.Preco.ToString("F2");
                maskedTextBox1.Text = produtoSelecionado.Quantidade.ToString();
            }

          

           

           

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
