using System;
using System.Globalization;

namespace primeiro_projeto_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 10.45;
            int idade = 32;
            string nome = "Maria";

            Console.WriteLine($"{nome} tem {idade} anos e possui {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais na conta");
        }
    }
}
