using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos mouse = new Produtos(1, "mouse gamer", 299.99);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Nome);
            Console.WriteLine(mouse.Preco);
        }

        struct Produtos
        {

            public Produtos(int id, string nome, double preco)
            {
                Id = id;
                Nome = nome;
                Preco = preco;
            }

            public int Id;
            public string Nome;
            public double Preco;
            public double PrecoEmDolar(double dolar)
            {
                return Preco * dolar;
            }
        }
    }
}
