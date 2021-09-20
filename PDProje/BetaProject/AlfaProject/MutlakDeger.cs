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
    public partial class MutlakDeger : Form
    {
        public MutlakDeger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var birinciDegisken =birincitxt.Text;
            var ikinciDegisken = Convert.ToInt32(ikincitxt.Text);
            var ucuncuDegisken = Convert.ToInt32(ucuncutxt.Text);
            string isaret = "";
            float sonuc = 0;
            if (radioButton6.Checked==true)
            {
                sonuc = ucuncuDegisken - ikinciDegisken;
            }
            else if (radioButton5.Checked == true)
            {
                sonuc = ucuncuDegisken + ikinciDegisken;
            }
           else if (radioButton4.Checked == true)
            {
                sonuc = ucuncuDegisken / ikinciDegisken;

            }
           else if (radioButton7.Checked == true)
            {
                sonuc = ucuncuDegisken * ikinciDegisken;
            }
            if(checkBox1.Checked==true)
            {
                isaret = checkBox1.Text;
            }
           else if (checkBox2.Checked == true)
            {
                isaret = checkBox2.Text;
            }
           else if (checkBox3.Checked == true)
            {
                isaret = checkBox3.Text;
            }
            sonuctxt.Text = "x" + isaret + sonuc;
        }

      
    }
}
