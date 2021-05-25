using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo();
            string nome = RetornaNome("natã", "vicente");
            Console.WriteLine(nome);
        }

        static void MeuMetodo()
        {
            Console.WriteLine("C# is cool");
        }

        static string RetornaNome(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }
    }
}
