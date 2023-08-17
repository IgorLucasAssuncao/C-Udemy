using System;

namespace Seção_4_40_classes_objetos_e_atributos
{
    class TesteClasse
    {
        static void Main(string[] args)
        {
            // Instanciando a classe Produto
            Produto p = new Produto();

            // Atribuindo valores aos atributos da classe Produto
            p.Nome = "TV";
            p.Preco = 500.00;
            p.Quantidade = 20;

            // Imprimindo os valores dos atributos da classe Produto
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}