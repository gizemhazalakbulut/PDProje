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
    public partial class KokluSayilar : Form
    {
        public KokluSayilar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1 = double.Parse(kökicitxt.Text);
            double s2 = 1 / double.Parse(derecetxt.Text); 
            double kok = Math.Pow(s1, s2);
            textBox4.Text = kok.ToString();

        }
    }
}
