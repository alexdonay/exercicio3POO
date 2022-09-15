namespace exercicio3POO
{

    public class Forma
    {
        public double area;
        public double perimetro;
        public virtual double CalculaArea()
        {
            return this.area;
        }
        public virtual double CalculaPerimetro()
        {
            return this.perimetro;
        }
    }
}
