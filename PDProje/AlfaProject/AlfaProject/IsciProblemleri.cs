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
    public partial class IsciProblemleri : Form
    {
        public IsciProblemleri()
        {
            InitializeComponent();
        }
        int isciSayısı;
       

       


        private void button2_Click(object sender, EventArgs e)
        {
            isciSayısı = Convert.ToInt32(isçitxt.Text);
            for (int i = 0; i < isciSayısı; i++)
            {
                var txtBox = new TextBox();
                txtBox.Name = "isci" + i+1;
                var label = new Label();
                 label.Text = i+1 + ". işçi yaptığı süre/iş";
                this.tableLayoutPanel1.Controls.Add(label);
                this.tableLayoutPanel1.Controls.Add(txtBox);
                
            }
            
        }
        double ilkIsci;
        double ikiniIsci;
        double ucuncuIsci;
        double dorduncuIsci;
        double besinciIsci;
        double altıncıIsci;
        double yedinciIsci;

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {
            var txtBox = sender as TextBox;
           
            switch (txtBox.Name)
            {
                case "isci1":
                    ilkIsci = Convert.ToDouble(txtBox.Text);
                    break;
                case "isci2":
                    ikiniIsci = Convert.ToDouble(txtBox.Text);
                    break;
                case "isci3":
                    ucuncuIsci = Convert.ToDouble(txtBox.Text);
                    break;
                case "isci4":
                    dorduncuIsci = Convert.ToDouble(txtBox.Text);
                    break;
                case "isci5":
                    besinciIsci = Convert.ToDouble(txtBox.Text);
                    break;
                case "isci6":
                    altıncıIsci = Convert.ToDouble(txtBox.Text);
                    break;
                case "isci7":
                    yedinciIsci = Convert.ToDouble(txtBox.Text);
                    break;
             
                default:
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var toplamIs = ilkIsci + ikiniIsci + ucuncuIsci + dorduncuIsci + besinciIsci + altıncıIsci + yedinciIsci;
            toplamIs = toplamIs;
            textBox4.Text = "İşin Toplamı = " + toplamIs.ToString();
        }
    }
}
