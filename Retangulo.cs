namespace exercicio3POO
{
    internal class Retangulo : Forma
    {
        public double lado { get; set; }
        public double altura { get; set; }
        public override double CalculaArea()
        {
            base.area = this.altura * this.lado;
            return this.area;
        }


        public override double CalculaPerimetro()
        {
            this.area = (this.altura * 2) + (this.lado * 2);
            return this.area;
        }
    }
}
