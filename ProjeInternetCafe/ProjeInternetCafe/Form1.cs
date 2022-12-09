namespace ProjeInternetCafe
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int dkm1 = 0, sr1 = 0, dkm2 = 0;
        double ucr1 = 1.5;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void masa1_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-1";
            labelGec.Text="0";




        }

        private void masa2_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-2";
            labelGec.Text="0";
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            dkm1++;
            if (string.Compare(labelMasa.Text, "Masa-1")==0)
                labelGec.Text= Convert.ToString(dkm1);
        }

        private void buttonMAc_Click(object sender, EventArgs e)
        {
            {
                if (string.Compare(labelMasa.Text, "Masa-1")==0)
                {
                   sr1 = Convert.ToInt32(textBoxSure.Text);
                    timer1.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-2")==0)
                {
                    sr1 = Convert.ToInt32(textBoxSure.Text);
                    timer2.Start();
                }
                else;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dkm2++;
            if (string.Compare(labelMasa.Text, "Masa-2")==0)
                labelGec.Text= Convert.ToString(dkm2);
            if (dkm2 <= sr1) timer2.Stop();
            if (dkm2==0 || dkm2%15 ==0)
                ucr1+=1.5;
            labelUcret.Text= Convert.ToString(ucr1);
        }
    }
}