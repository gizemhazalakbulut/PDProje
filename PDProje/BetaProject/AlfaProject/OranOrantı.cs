using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlfaProject
{
    public partial class OranOrantı : Form
    {
        public OranOrantı()
        {
            InitializeComponent();
        }

        private void OranOrantı_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var birinciİlk = Convert.ToDouble(birincitxt.Text);
            var ikinciİlk = Convert.ToDouble(ikincitxt.Text);
            var birinciİkinci = Convert.ToDouble(textBox3.Text);
            var ikinciİkinci = Convert.ToDouble(textBox2.Text);
            var Soru = 1.2;
            var birinciOran = ikinciİlk - birinciİlk;
            var ikinciOran = ikinciİkinci - birinciİkinci;
            var Oran = birinciOran / ikinciOran;
            var cozum=1.2;
            var soruSonuc = 1.2;
            if (ucuncutxt.Text == "") 
            {  
                Soru = Convert.ToDouble(textBox1.Text);
                var artıs = Soru - birinciİkinci;
                soruSonuc = birinciİlk + (artıs * Oran);
                ucuncutxt.Text =Math.Abs(soruSonuc).ToString(); 
            }
           else if (ucuncutxt.Text != "") 
            {  
                Soru = Convert.ToDouble(ucuncutxt.Text);
                var artıs = Soru - birinciİlk;
                soruSonuc = birinciİkinci + (artıs / Oran);
                textBox1.Text = Math.Abs(soruSonuc).ToString();
            }
         
        }
    }
}
