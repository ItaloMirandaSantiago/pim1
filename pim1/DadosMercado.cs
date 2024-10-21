using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace pim1
{
    internal class DadosMercado
    {
        // Inicializando a lista de produtos


        public static List<Produto> Produtos { get; set; } = new List<Produto>();

        public static List<string> Vendas { get; set; } = new List<string>();

        // Método para criar um produto

        public static void CreateProduct(string nome, decimal preco, int quantidade)
        {
            Produto novoProduto = new Produto
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                Preco = preco,
                Quantidade = quantidade
            };

            Produtos.Add(novoProduto);

            // Mensagem para confirmar a criação do produto
            //    MessageBox.Show($"Produto criado: {novoProduto.Nome} (Preço: {novoProduto.Preco}, Quantidade: {novoProduto.Quantidade})");
            MessageBox.Show(GetAllProductsAsString());
        }

        public static string GetAllProductsAsString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var produto in Produtos)
            {
                sb.AppendLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco:C}, Quantidade: {produto.Quantidade}");
            }

            return sb.ToString();
        }





        public static List<Produto> GetAll()
        {
            return Produtos;
        }
    }

    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }  
    }
}
