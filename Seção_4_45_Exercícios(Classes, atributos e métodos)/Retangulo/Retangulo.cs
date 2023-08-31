using System;

namespace Retangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }
        public Retangulo()
        {
            this.Largura = 0;
            this.Altura = 0;
        }
        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }
}