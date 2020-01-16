using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04
{
    class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, int salario) : base(nome, idade, salario)
        {
        }
        public new int Bonificacao()
        {
            int resultadoBonificacao = Salario + 10000;

            Console.WriteLine($"\nA bonificação de salario do gerente {Nome} foi de R$ {resultadoBonificacao} e o seu salario base é de R$ {Salario}");
            Console.WriteLine($"Sendo que o acrescimo foi de R$ 10000");
            return 0;
        }
    }
}
