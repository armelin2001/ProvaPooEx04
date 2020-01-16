using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Salario { get; set; }
        public Funcionario(string nome, int idade, int salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }
        public override string ToString()
        {
            return $"Nome: {Nome} Idade: {Idade} Salario: {Salario}";
        }
        public int Bonificacao()
        {
            return Salario;
        }
    }
}
