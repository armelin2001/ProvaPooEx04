using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04
{
    class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, int salario) : base(nome, idade, salario)
        {
        }
        public new int Bonificacao()
        {
            int resultadoBonificacao = Salario + 3000;
            Console.WriteLine($"\nA bonificação de salario do vendedor {Nome} foi de R$ {resultadoBonificacao} e o seu salario base é de R$ {Salario}");
            Console.WriteLine($"Sendo que o acrescimo foi de R$ 3000");
            return 0;
        }
    }
}
