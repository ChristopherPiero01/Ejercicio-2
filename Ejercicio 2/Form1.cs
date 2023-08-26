namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = int.Parse(this.txtMin.Text);
            int horas = min / 60;
            int minres = min % 60;
            txtHyM.Text = horas.ToString() + " horas y " + minres.ToString() + " minutos";
        }
    }
}