namespace Değişkenler_Doublw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double sayi;
            //sayi = 4.25;
            //label1.Text = sayi.ToString(); 


            //double sınav1, sınav2, sınav3,ortalama;
            //sınav1 = 60;
            //sınav2 = 70;
            //sınav3 = 79;
            //ortalama = (sınav1 + sınav2 + sınav3)/3;

            //label1.Text = ortalama.ToString("0.00");


            double sayi = Convert.ToDouble(textBox1.Text);
            label1.Text = sayi.ToString();
        }
    }
}
