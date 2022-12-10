namespace ProjeInternetCafe
{
    public partial class Form1 : Form
    {
 double ucr1 = 1.5, ucr2 = 1.5, ucr3 = 1.5, ucr4 = 1.5, ucr5 = 1.5, ucr6 = 1.5, ucr7 = 1.5, ucr8 = 1.5, ucr9 = 1.5, ucr10 = 1.5, ucr11 = 1.5, ucr12 = 1.5, ucr13 = 1.5, ucr14 = 1.5, ucr15 = 1.5, ucr16 = 1.5, ucr17 = 1.5, ucr18 = 1.5;

         int dkm1 = 0, dkm2 = 0, dkm3 = 0, dkm4 = 0, dkm5 = 0, dkm6 = 0, dkm7 = 0, dkm8 = 0, dkm9 = 0, dkm10 = 0, dkm11 = 0, dkm12 = 0, dkm13 = 0, dkm14 = 0, dkm15 = 0, dkm16 = 0, dkm17 = 0, dkm18 = 0;
 int sr2 = 0, sr1 = 0, sr3 = 0, sr4 = 0, sr5 = 0, sr6 = 0, sr7 = 0, sr8 = 0, sr9 = 0, sr10 = 0, sr11 = 0, sr12 = 0, sr13 = 0, sr14 = 0, sr15 = 0, sr16 = 0, sr17 = 0, sr18 = 0;
        private void buttonCont_Click(object sender, EventArgs e)
        {
            if (string.Compare(labelMasa.Text, "Masa-1")==0)
            {
                if (dkm1 != 0)
                    timer1.Start();
                else if (string.Compare(labelMasa.Text, "Masa-2")==0)
                {
                    if (dkm2 != 0)
                        timer2.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-3")==0)
                {
                    if (dkm3 != 0)
                        timer3.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-4")==0)
                {
                    if (dkm4 != 0)
                        timer4.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-5")==0)
                {
                    if (dkm5 != 0)
                        timer5.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-6")==0)
                {
                    if (dkm6 != 0)
                        timer6.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-7")==0)
                {
                    if (dkm7 != 0)
                        timer7.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-8")==0)
                {
                    if (dkm8 != 0)
                        timer8.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-9")==0)
                {
                    if (dkm9 != 0)
                        timer9.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-10")==0)
                {
                    if (dkm10 != 0)
                        timer10.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-11")==0)
                {
                    if (dkm11 != 0)
                        timer11.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-12")==0)
                {
                    if (dkm12 != 0)
                        timer12.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-13")==0)
                {
                    if (dkm13 != 0)
                        timer13.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-14")==0)
                {
                    if (dkm14 != 0)
                        timer14.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-15")==0)
                {
                    if (dkm15 != 0)
                        timer15.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-16")==0)
                {
                    if (dkm16 != 0)
                        timer16.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-17")==0)
                {
                    if (dkm17 != 0)
                        timer17.Start();
                }
                else if (string.Compare(labelMasa.Text, "Masa-18")==0)
                {
                    if (dkm18 != 0)
                        timer18.Start();
                }
                else;
            }
        }



            private void button3_Click(object sender, EventArgs e)
            {
                if (string.Compare(labelMasa.Text, "Masa-1")==0)
                {
                    sr1=Convert.ToInt32(textBoxSure.Text)+sr1;
                }
                else if (string.Compare(labelMasa.Text, "Masa-2")==0)
                {
                    sr2=Convert.ToInt32(textBoxSure.Text)+sr2;
                }
                else if (string.Compare(labelMasa.Text, "Masa-3")==0)
                {
                    sr3=Convert.ToInt32(textBoxSure.Text)+sr3;
                }
                else if (string.Compare(labelMasa.Text, "Masa-4")==0)
                {
                    sr4=Convert.ToInt32(textBoxSure.Text)+sr4;
                }
                else if (string.Compare(labelMasa.Text, "Masa-5")==0)
                {
                    sr5=Convert.ToInt32(textBoxSure.Text)+sr5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-6")==0)
                {
                    sr6=Convert.ToInt32(textBoxSure.Text)+sr6;
                }
                else if (string.Compare(labelMasa.Text, "Masa-7")==0)
                {
                    sr7=Convert.ToInt32(textBoxSure.Text)+sr7;
                }
                else if (string.Compare(labelMasa.Text, "Masa-8")==0)
                {
                    sr8=Convert.ToInt32(textBoxSure.Text)+sr8;
                }
                else if (string.Compare(labelMasa.Text, "Masa-9")==0)
                {
                    sr9=Convert.ToInt32(textBoxSure.Text)+sr9;
                }
                else if (string.Compare(labelMasa.Text, "Masa-10")==0)
                {
                    sr10=Convert.ToInt32(textBoxSure.Text)+sr10;
                }
                else if (string.Compare(labelMasa.Text, "Masa-11")==0)
                {
                    sr11=Convert.ToInt32(textBoxSure.Text)+sr11;
                }
                else if (string.Compare(labelMasa.Text, "Masa-12")==0)
                {
                    sr12=Convert.ToInt32(textBoxSure.Text)+sr12;
                }
                else if (string.Compare(labelMasa.Text, "Masa-13")==0)
                {
                    sr13=Convert.ToInt32(textBoxSure.Text)+sr13;
                }
                else if (string.Compare(labelMasa.Text, "Masa-14")==0)
                {
                    sr14=Convert.ToInt32(textBoxSure.Text)+sr14;
                }
                else if (string.Compare(labelMasa.Text, "Masa-15")==0)
                {
                    sr15=Convert.ToInt32(textBoxSure.Text)+sr15;
                }
                else if (string.Compare(labelMasa.Text, "Masa-16")==0)
                {
                    sr16=Convert.ToInt32(textBoxSure.Text)+sr16;
                }
                else if (string.Compare(labelMasa.Text, "Masa-17")==0)
                {
                    sr17=Convert.ToInt32(textBoxSure.Text)+sr17;
                }
                else if (string.Compare(labelMasa.Text, "Masa-18")==0)
                {
                    sr18=Convert.ToInt32(textBoxSure.Text)+sr18;
                }
                else;
            } 

       

        private void timer5_Tick(object sender, EventArgs e)
        {

            dkm5++;
            if (string.Compare(labelMasa.Text, "Masa-5")==0)
            {
                labelGec.Text= Convert.ToString(dkm5);
                labelKal.Text= Convert.ToString(sr5);
                labelUcret.Text= Convert.ToString(ucr5)+ "tl";
            }
            if (dkm5==0 || dkm5%15 ==0)
                ucr5+=1.5;
            if (dkm5 >= sr5) timer5.Stop();

        }

        private void masa5_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-5";
            if (dkm5==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm5);
            labelKal.Text=Convert.ToString(sr5);
            if (dkm5==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr5);
            if (dkm5==0 || dkm5==sr5) labelUcret.Text=Convert.ToString(ucr5-1.5);
            if (dkm5 >= sr5) labelKal.Text= "0";

        }

     
        public Form1()
        {
            InitializeComponent();
        }
      

        private void masa4_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-4";
            if (dkm4==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm4);
            labelKal.Text=Convert.ToString(sr4);
            if (dkm4==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr4);
            if (dkm4==0 || dkm4==sr4) labelUcret.Text=Convert.ToString(ucr4-1.5);
            if (dkm4 >= sr4) labelKal.Text= "0";

        }

       
        private void timer3_Tick(object sender, EventArgs e)
        {
            dkm3++;
            if (string.Compare(labelMasa.Text, "Masa-3")==0)
            {
                labelGec.Text= Convert.ToString(dkm3);
                labelKal.Text= Convert.ToString(sr3);
                labelUcret.Text= Convert.ToString(ucr3)+ "tl";
            }
            if (dkm3==0 || dkm3%15 ==0)
                ucr3+=1.5;
            if (dkm3 >= sr3) timer3.Stop();
        } 
        private void timer4_Tick(object sender, EventArgs e)
        {
            dkm4++;
            if (string.Compare(labelMasa.Text, "Masa-4")==0)
            {
                labelGec.Text= Convert.ToString(dkm4);
                labelKal.Text= Convert.ToString(sr4);
                labelUcret.Text= Convert.ToString(ucr4)+ "tl";
            }
            if (dkm4==0 || dkm4%15 ==0)
                ucr4+=1.5;
            if (dkm4 >= sr4) timer4.Stop();
        }

        private void masa3_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-3";
            if (dkm3==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm3);
            labelKal.Text=Convert.ToString(sr3);
            if (dkm3==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr3);
            if (dkm3==0 || dkm3==sr3) labelUcret.Text=Convert.ToString(ucr3-1.5);
            if (dkm3 >= sr3) labelKal.Text= "0";


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void masa1_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-1";
            if (dkm1==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm1);
            labelKal.Text=Convert.ToString(sr1);
            if (dkm1==0) labelKal.Text="0";
                labelUcret.Text=Convert.ToString(ucr1);
            if (dkm1==0 || dkm1==sr1) labelUcret.Text=Convert.ToString(ucr1-1.5);
            if (dkm1 >= sr1) labelKal.Text= "0";



        }

        private void masa2_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-2";
            if (dkm2==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm2);
            labelKal.Text=Convert.ToString(sr2);
            if (dkm2==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr2);
           if(dkm2==0 || dkm2==sr2) labelUcret.Text=Convert.ToString(ucr2-1.5);
            if (dkm2 >= sr2) labelKal.Text= "0";


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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.Compare(labelMasa.Text, "Masa-1")==0)
            {
               labelKal.Text = "0";
                timer1.Stop();
               dkm1 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-2")==0)
            {
                labelKal.Text = "0";
                timer2.Stop();
                dkm2 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-3")==0)
            {
                labelKal.Text = "0";
                timer3.Stop(); 
                dkm3 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-4")==0)
            {
                labelKal.Text = "0";
                timer4.Stop();
                dkm4 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-5")==0)
            {
                labelKal.Text = "0";
                timer5.Stop(); 
                dkm5 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-6")==0)
            {
                labelKal.Text = "0";
                timer6.Stop();
                dkm6 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-7")==0)
            {
                labelKal.Text = "0";
                timer7.Stop();
                dkm7 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-8")==0)
            {
                labelKal.Text = "0";
                timer8.Stop();
                dkm8 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-9")==0)
            {
                labelKal.Text = "0";
                timer9.Stop();
                dkm9 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-10")==0)
            {
                labelKal.Text = "0";
                timer10.Stop();
                dkm10 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-11")==0)
            {
                labelKal.Text = "0";
                timer11.Stop();
                dkm11 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-12")==0)
            {
                labelKal.Text = "0";
                timer12.Stop();
                dkm12 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-13")==0)
            {
                labelKal.Text = "0";
                timer13.Stop();
                dkm13 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-14")==0)
            {
                labelKal.Text = "0";
                timer14.Stop();
                dkm14 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-15")==0)
            {
                labelKal.Text = "0";
                timer15.Stop();
                dkm15 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-16")==0)
            {
                labelKal.Text = "0";
                timer16.Stop();
                dkm16 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-17")==0)
            {
                labelKal.Text = "0";
                timer17.Stop();
                dkm17 = 0;
            }
            else if (string.Compare(labelMasa.Text, "Masa-18")==0)
            {
                labelKal.Text = "0";
                timer18.Stop();
                dkm18 = 0;
            }
            else;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.Compare(labelMasa.Text, "Masa-1")==0)
            {
               timer1.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-2")==0)
            {
                timer2.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-3")==0)
            {
                timer3.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-4")==0)
            {
                timer4.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-5")==0)
            {
                timer5.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-6")==0)
            {
                timer6.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-7")==0)
            {
                timer7.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-8")==0)
            {
                timer8.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-9")==0)
            {
                timer9.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-10")==0)
            {
                timer10.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-11")==0)
            {
                timer11.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-12")==0)
            {
                timer12.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-13")==0)
            {
                timer13.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-14")==0)
            {
                timer14.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-15")==0)
            {
                timer15.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-16")==0)
            {
                timer16.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-17")==0)
            {
                timer17.Stop();
            }
            else if (string.Compare(labelMasa.Text, "Masa-18")==0)
            {
                timer18.Stop();
            }
            else;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            dkm1++;
            if (string.Compare(labelMasa.Text, "Masa-1")==0)
            {
                labelGec.Text= Convert.ToString(dkm1);
                labelKal.Text= Convert.ToString(sr1);
                labelUcret.Text= Convert.ToString(ucr1)+ "tl";
            }
            if (dkm1==0 || dkm1%15 ==0)
                ucr1+=1.5;
            if (dkm1 >= sr1) timer1.Stop();

        }

        private void buttonMAc_Click(object sender, EventArgs e)
        {
            {
                if (string.Compare(labelMasa.Text, "Masa-1")==0)
                {
                    sr1 = Convert.ToInt32(textBoxSure.Text);
                    timer1.Start();
                    dkm1=0;
                    ucr1 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-2")==0)
                {
                    sr2 = Convert.ToInt32(textBoxSure.Text);
                    timer2.Start();
                    dkm2=0;
                    ucr2 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-3")==0)
                {
                    sr3 = Convert.ToInt32(textBoxSure.Text);
                    timer3.Start();
                    dkm3=0;
                    ucr3 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-4")==0)
                {
                    sr4 = Convert.ToInt32(textBoxSure.Text);
                    timer4.Start();
                    dkm4=0;
                    ucr4 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-5")==0)
                {
                    sr5 = Convert.ToInt32(textBoxSure.Text);
                    timer5.Start();
                    dkm5=0;
                    ucr5 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-6")==0)
                {
                    sr6 = Convert.ToInt32(textBoxSure.Text);
                    timer6.Start();
                    dkm6=0;
                    ucr6 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-7")==0)
                {
                    sr7 = Convert.ToInt32(textBoxSure.Text);
                    timer7.Start();
                    dkm7=0;
                    ucr7 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-8")==0)
                {
                    sr8 = Convert.ToInt32(textBoxSure.Text);
                    timer8.Start();
                    dkm8=0;
                    ucr8 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-9")==0)
                {
                    sr9 = Convert.ToInt32(textBoxSure.Text);
                    timer9.Start();
                    dkm9=0;
                    ucr9 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-10")==0)
                {
                    sr10 = Convert.ToInt32(textBoxSure.Text);
                    timer10.Start();
                    dkm10=0;
                    ucr10 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-11")==0)
                {
                    sr11 = Convert.ToInt32(textBoxSure.Text);
                    timer11.Start();
                    dkm11=0;
                    ucr11 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-12")==0)
                {
                    sr12 = Convert.ToInt32(textBoxSure.Text);
                    timer12.Start();
                    dkm12=0;
                    ucr12 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-13")==0)
                {
                    sr13 = Convert.ToInt32(textBoxSure.Text);
                    timer13.Start();
                    dkm13=0;
                    ucr13 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-14")==0)
                {
                    sr14 = Convert.ToInt32(textBoxSure.Text);
                    timer14.Start();
                    dkm14=0;
                    ucr14 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-15")==0)
                {
                    sr15 = Convert.ToInt32(textBoxSure.Text);
                    timer15.Start();
                    dkm15=0;
                    ucr15 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-16")==0)
                {
                    sr16 = Convert.ToInt32(textBoxSure.Text);
                    timer16.Start();
                    dkm16=0;
                    ucr16 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-17")==0)
                {
                    sr17 = Convert.ToInt32(textBoxSure.Text);
                    timer17.Start();
                    dkm17=0;
                    ucr17 = 1.5;
                }
                else if (string.Compare(labelMasa.Text, "Masa-18")==0)
                {
                    sr18 = Convert.ToInt32(textBoxSure.Text);
                    timer18.Start();
                    dkm18=0;
                    ucr18 = 1.5;
                }
                else;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dkm2++;
            if (string.Compare(labelMasa.Text, "Masa-2")==0)
            {
                labelGec.Text= Convert.ToString(dkm2);
                labelKal.Text= Convert.ToString(sr2);
            labelUcret.Text= Convert.ToString(ucr2)+ "tl";
            }
            if (dkm2==0 || dkm2%15 ==0)
                ucr2+=1.5;
            if (dkm2 >= sr2) timer2.Stop();

            
          
        }
    }
}