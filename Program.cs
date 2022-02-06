using System;

namespace app_padaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Padaria padaria = new Padaria();
            
            Console.WriteLine("Digite o nome do cliente: ");
            padaria.SetNome = Console.ReadLine();
            
            Console.WriteLine("Digite o nome do produto: ");
            padaria.SetProduto = Console.ReadLine();
            
            Console.WriteLine("Digite a quantidade do produto: ");
            padaria.SetQuantidade = Console.Read();

            Console.WriteLine();

            Console.WriteLine("Cliente: " + padaria.GetNome);
            Console.WriteLine("Pedido: " + padaria.GetQuantidade + " " + padaria.GetProduto);
        }
    }
}
