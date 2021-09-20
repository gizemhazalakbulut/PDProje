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
    public partial class UsluSayilar : Form
    {
        public UsluSayilar()
        {
            InitializeComponent();
        }

        private void UsluSayilar_Load(object sender, EventArgs e)
        {
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabantxt.Text != "" && üstxt.Text != "")
            {
                var taban = double.Parse(tabantxt.Text);
                var üs = double.Parse(üstxt.Text);
                if (taban != 0 && üs != 0)
                {
                    var sonuc = Math.Pow(taban, üs);
                    textBox4.Text = sonuc.ToString();
                }
            }
        }
    }
}
