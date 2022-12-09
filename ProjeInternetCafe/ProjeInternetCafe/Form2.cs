using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeInternetCafe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        int dkm1 =0, dkm2=0;

          


private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonSuresiz_Click(object sender, EventArgs e)
        {

        }

        private void buttonMasaAc_Click(object sender, EventArgs e)
        {
            if (string.Compare(label1.Text, "Masa-1")==0)
            {
                timerM1.Start();
            }
            else if (string.Compare(label1.Text, "Masa-2")==0)
            {
                timerM2.Start();
            }
            
               
            
        
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
           Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void timerM1_Tick(object sender, EventArgs e)
        {
            dkm1++;
            labelGecen.Text= Convert.ToString(dkm1);
        }

  

        private void timerM2_Tick(object sender, EventArgs e)
        {
            dkm2++;
            labelGecen.Text= Convert.ToString(dkm2);
        }
    }

}
