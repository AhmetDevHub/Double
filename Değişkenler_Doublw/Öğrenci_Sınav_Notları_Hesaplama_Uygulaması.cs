using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değişkenler_Doublw
{
    public partial class Öğrenci_Sınav_Notları_Hesaplama_Uygulaması : Form
    {
        public Öğrenci_Sınav_Notları_Hesaplama_Uygulaması()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int sınav1, sınav2, proje;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            sınav1 = Convert.ToInt16(textBox3.Text);
            sınav2 = Convert.ToInt16(textBox4.Text);
            proje = Convert.ToInt16(textBox5.Text);
            ortalama = (sınav1 + sınav2 + proje) / 3;
            listBox1.Items.Add(ad + " " + soyad + " " + "Ortalama:" + ortalama);


        }
    }
}
