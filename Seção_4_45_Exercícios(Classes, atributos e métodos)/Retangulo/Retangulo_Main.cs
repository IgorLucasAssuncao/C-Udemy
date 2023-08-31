using System;


namespace Retangulo
{
    public class Retangulo_Main
    {
        public static void Main(string[] Args)
        {
            Console.WriteLine("Entre com a largura e altura do retângulo:");
            Retangulo retangulo;
            double altura, largura;
            largura = double.Parse(Console.ReadLine() ?? "0");
            altura = double.Parse(Console.ReadLine() ?? "0");
            retangulo = new Retangulo(largura, altura);
            Console.WriteLine($"Área: {retangulo.Area()}");
            Console.WriteLine($"Perímetro: {retangulo.Perimetro()}");
            Console.WriteLine($"Diagonal: {retangulo.Diagonal().ToString("F2")}");

        }
    }
}
