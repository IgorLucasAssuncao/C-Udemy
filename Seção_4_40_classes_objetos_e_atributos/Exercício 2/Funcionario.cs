using System;

namespace Funcionario
{
    class Funcionario
    {
        private string nome;
        private double salarioBruto;

        public Funcionario(string nome, double salarioBruto)
        {
            this.nome = nome;
            this.salarioBruto = salarioBruto;
        }
        public static Double MediaSalario(Funcionario f1, Funcionario f2)
        {
            return (f1.salarioBruto + f2.salarioBruto) / 2;
        }


    }
}