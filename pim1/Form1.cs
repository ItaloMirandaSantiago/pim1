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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do segundo formulário
            Form_Caixa Form_Caixa = new Form_Caixa();

            // Exibe o novo formulário
            Form_Caixa.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do segundo formulário
            Form_Admin Form_Admin = new Form_Admin();

            // Exibe o novo formulário
            Form_Admin.Show();  // Abre o novo formulário sem bloquear o anterior
                           // form2.ShowDialog();  // Abre o formulário em modo modal, bloqueando o anterior até que seja fechado
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
