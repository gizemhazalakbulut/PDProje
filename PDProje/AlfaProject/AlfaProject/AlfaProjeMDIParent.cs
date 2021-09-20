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
    public partial class AlfaProjeMDIParent : Form
    {
        private int childFormNumber = 0;

        public AlfaProjeMDIParent()
        {
            InitializeComponent();
        }
        public void OpenForm(Form formName)
        {
            panel1.Controls.Clear();
            formName.MdiParent = this;
            formName.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(formName);
            formName.Show();
        }

        private void bölünebilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bolunebilme bolunebilme = new Bolunebilme();
            OpenForm(bolunebilme);
        }

        private void oranOrantıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OranOrantı oranOrantı = new OranOrantı();
            OpenForm(oranOrantı);
        }

        private void üslüSayılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsluSayilar usluSayilar = new UsluSayilar();
            OpenForm(usluSayilar);
        }

       
        private void köklüSayılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KokluSayilar kokluSayilar = new KokluSayilar();
            OpenForm(kokluSayilar);
        }

        private void hızProblemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsciProblemleri ısciProblemleri = new IsciProblemleri();
            OpenForm(ısciProblemleri);
        }

        private void yolProblemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YolProblemleri yolProblemleri = new YolProblemleri();
            OpenForm(yolProblemleri);
        }

        private void AlfaProjeMDIParent_Load(object sender, EventArgs e)
        {
            Bolunebilme bolunebilme = new Bolunebilme();
            OpenForm(bolunebilme);
        }

        
    }
}
