namespace Factorial_JP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = 1;
            int.TryParse(txtnumero.Text, out int numero);

            for(int i = 1; i<=numero; i++)
            {
                resultado = resultado * i;
            }
            MessageBox.Show("El factorial es: " + resultado);
        }
    }
}
