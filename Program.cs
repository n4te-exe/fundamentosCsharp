using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Produtos(1, "mouse gamer", 299.99, ETipoDeProduto.Produto);
            var manutencao = new Produtos(2, "eletrica", 100.00, ETipoDeProduto.Servico);
            mouse.Id = 55;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Nome);
            Console.WriteLine(mouse.Preco);
            Console.WriteLine((int)mouse.Tipo);
        }

        struct Produtos
        {

            public Produtos(int id, string nome, double preco, ETipoDeProduto tipo)
            {
                Id = id;
                Nome = nome;
                Preco = preco;
                Tipo = tipo;
            }

            public int Id;
            public string Nome;
            public double Preco;
            public ETipoDeProduto Tipo;
            public double PrecoEmDolar(double dolar)
            {
                return Preco * dolar;
            }
        }

        enum ETipoDeProduto
        {
            Produto = 1,
            Servico = 2
        }
    }
}
