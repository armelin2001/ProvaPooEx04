using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente("João", 50, 2000);
            Supervisor supervisor = new Supervisor("Ana", 30, 1200);
            Vendedor vendedor = new Vendedor("Arthur", 20, 900);
            Console.WriteLine(gerente);
            Console.WriteLine(supervisor);
            Console.WriteLine(vendedor);
            Console.WriteLine("-----------------------------------------------------------");
            gerente.Bonificacao();
            Console.WriteLine("-----------------------------------------------------------");
            supervisor.Bonificacao();
            Console.WriteLine("-----------------------------------------------------------");
            vendedor.Bonificacao();
            Console.WriteLine("-----------------------------------------------------------");

        }
    }
}
