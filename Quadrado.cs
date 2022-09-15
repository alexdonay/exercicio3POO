namespace exercicio3POO
{
    internal class Quadrado : Retangulo
    {

        public override double CalculaArea()
        {

            return base.lado * base.lado;
        }
        public override double CalculaPerimetro()
        {
            base.altura = this.lado;
            return base.CalculaPerimetro();
        }
    }
}
