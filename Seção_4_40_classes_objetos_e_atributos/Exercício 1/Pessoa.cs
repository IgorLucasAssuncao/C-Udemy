using System;
using System.Runtime.InteropServices;

namespace pessoa
{
    class Pessoa
    {
        private string nome;
        private int idade;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        public static void compararIdade(Pessoa p1, Pessoa p2)
        {
            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }
        }
    }
}