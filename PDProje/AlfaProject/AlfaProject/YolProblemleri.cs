using System;
using System.Windows.Forms;

namespace AlfaProject
{
    public partial class YolProblemleri : Form
    {
        public YolProblemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc;
            if (yoltxt.Text == "" && hıztxt.Text == "" && zamantxt.Text == "")
            {
                MessageBox.Show("Lütfen Verileri giriniz");
            }
            else if (yoltxt.Text == "" && hıztxt.Text != "" && zamantxt.Text != "")
            {
                var hız = Convert.ToDouble(hıztxt.Text);
                var zaman = Convert.ToDouble(zamantxt.Text);
                sonuc = hız * zaman;
                textBox4.Text ="Yol = "+sonuc.ToString();

            }
            else if (yoltxt.Text != "" && hıztxt.Text == "" && zamantxt.Text != "")
            {
                var yol = Convert.ToDouble(yoltxt.Text);
                var zaman = Convert.ToDouble(zamantxt.Text);
                sonuc = yol / zaman;
                textBox4.Text ="Hız = "+sonuc.ToString();
            }
            else if (yoltxt.Text != "" && hıztxt.Text != "" && zamantxt.Text == "")
            {
                var yol = Convert.ToDouble(yoltxt.Text);
                var hız = Convert.ToDouble(hıztxt.Text);
                sonuc = yol / hız;
                textBox4.Text ="Zaman = "+ sonuc.ToString();
            }
            else if (yoltxt.Text == "" && hıztxt.Text != "" && zamantxt.Text == "")
            {
                MessageBox.Show("Lütfen Verileri giriniz");
            }
            else if (yoltxt.Text != "" && hıztxt.Text == "" && zamantxt.Text == "")
            {
                MessageBox.Show("Lütfen Verileri giriniz");
            }
            else if (yoltxt.Text == "" && hıztxt.Text == "" && zamantxt.Text != "")
            {
                MessageBox.Show("Lütfen Verileri giriniz");
            }
            else
            {
                MessageBox.Show("Hata Oluştu");
            }

            
        }
    }
}
