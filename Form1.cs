using System.Windows.Forms;
using System;
namespace exercicio3POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Circulo circulo = new Circulo();
            circulo.raio = 3;
            

            MessageBox.Show(Convert.ToString(circulo.CalculaPerimetro()));
            MessageBox.Show(Convert.ToString(circulo.CalculaArea()));
        }
    }
}
