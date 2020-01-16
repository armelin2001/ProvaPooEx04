using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04
{
    class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, int salario) : base(nome, idade, salario)
        {
        }
        public new void Bonificacao()
        {
            int resultadoBonificacao = Salario + 5000;
            Console.WriteLine($"\nA bonificação de salario do supervisor {Nome} foi de R$ {resultadoBonificacao} e o seu salario base é de R$ {Salario}");
            Console.WriteLine($"Sendo que o acrescimo foi de R$ 5000");
        }
    }
}
