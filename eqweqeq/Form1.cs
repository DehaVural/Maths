using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eqweqeq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnHesap_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtMetin.Text);
            bool asalMi = true;

            for (int i = 2; i < sayi; i++) 
            {
                if (sayi % i == 0) 
                {
                    asalMi = false;
                    break;
                }
            }
            if(asalMi)
            {
                MessageBox.Show("Sayı Asaldır");
            }
            else
            {
                MessageBox.Show("Sayı Asal Değildir");
            }
            

           
            

                
                
                   
                

        }

        private void bttnKaresi_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtMetin.Text);
            int karesi = sayi * sayi;
            MessageBox.Show(karesi.ToString());

        }

        private void bttnKok_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtMetin.Text);

            double karakok = Math.Sqrt(sayi);
            MessageBox.Show(karakok.ToString());
        }

      
    }
}
