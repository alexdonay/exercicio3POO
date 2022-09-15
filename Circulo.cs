using System;
namespace exercicio3POO
{
    internal class Circulo : Forma
    {
        public double raio { get; set; }
        public double pi = 3.14;

        public override double CalculaArea()
        {
            return pi * Math.Pow(this.raio, 2);
        }
        public override double CalculaPerimetro()
        {
            return 2 * pi * this.raio;
        }
    }
}
