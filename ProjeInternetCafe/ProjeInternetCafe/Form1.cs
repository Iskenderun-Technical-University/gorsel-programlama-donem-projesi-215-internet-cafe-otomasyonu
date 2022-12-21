using System.Windows.Forms;

namespace ProjeInternetCafe
{
    public partial class Form1 : Form
    {

        double ucr1 = 1.5, ucr2 = 1.5, ucr3 = 1.5, ucr4 = 1.5, ucr5 = 1.5, ucr6 = 1.5, ucr7 = 1.5, ucr8 = 1.5, ucr9 = 1.5, ucr10 = 1.5, ucr11 = 1.5, ucr12 = 1.5, ucr13 = 1.5, ucr14 = 1.5, ucr15 = 1.5, ucr16 = 1.5, ucr17 = 1.5, ucr18 = 1.5;
        int dkm1 = 0, dkm2 = 0, dkm3 = 0, dkm4 = 0, dkm5 = 0, dkm6 = 0, dkm7 = 0, dkm8 = 0, dkm9 = 0, dkm10 = 0, dkm11 = 0, dkm12 = 0, dkm13 = 0, dkm14 = 0, dkm15 = 0, dkm16 = 0, dkm17 = 0, dkm18 = 0;

        int sr2 = 0, sr1 = 0, sr3 = 0, sr4 = 0, sr5 = 0, sr6 = 0, sr7 = 0, sr8 = 0, sr9 = 0, sr10 = 0, sr11 = 0, sr12 = 0, sr13 = 0, sr14 = 0, sr15 = 0, sr16 = 0, sr17 = 0, sr18 = 0;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            dkm6++;
            masa6.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-6")==0)
            {
                labelGec.Text= Convert.ToString(dkm6);
                labelKal.Text= Convert.ToString(sr6);
                labelUcret.Text= Convert.ToString(ucr6)+ "tl";
            }
            if (dkm6==0 || dkm6%15 ==0)
                ucr6+=1.5;
            if (dkm6 >= sr6){ timer6.Stop();
                masa6.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 6'NIN SÜRESÝ DOLMUÞTUR!"); }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            dkm7++;
            masa7.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-7")==0)
            {
                labelGec.Text= Convert.ToString(dkm7);
                labelKal.Text= Convert.ToString(sr7);
                labelUcret.Text= Convert.ToString(ucr7)+ "tl";
            }
            if (dkm7==0 || dkm7%15 ==0)
                ucr7+=1.5;
            if (dkm7 >= sr7){ timer7.Stop();
                masa7.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 7'NÝN SÜRESÝ DOLMUÞTUR!"); }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            dkm8++;
            masa8.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-8")==0)
            {
                labelGec.Text= Convert.ToString(dkm8);
                labelKal.Text= Convert.ToString(sr8);
                labelUcret.Text= Convert.ToString(ucr8)+ "tl";
            }
            if (dkm8==0 || dkm8%15 ==0)
                ucr1+=1.5;
            if (dkm8 >= sr8){ timer8.Stop();
                masa8.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 8'ÝN SÜRESÝ DOLMUÞTUR!"); }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            dkm9++;
            masa9.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-9")==0)
            {
                labelGec.Text= Convert.ToString(dkm9);
                labelKal.Text= Convert.ToString(sr9);
                labelUcret.Text= Convert.ToString(ucr9)+ "tl";
            }
            if (dkm9==0 || dkm9%15 ==0)
                ucr9+=1.5;
            if (dkm9 >= sr9){ timer9.Stop();
                masa9.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 9'UN SÜRESÝ DOLMUÞTUR!"); }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            dkm10++;
            masa10.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-10")==0)
            {
                labelGec.Text= Convert.ToString(dkm10);
                labelKal.Text= Convert.ToString(sr10);
                labelUcret.Text= Convert.ToString(ucr10)+ "tl";
            }
            if (dkm10==0 || dkm10%15 ==0)
                ucr10+=1.5;
            if (dkm10 >= sr10){ timer10.Stop();
                masa10.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 10'UN SÜRESÝ DOLMUÞTUR!"); }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            dkm11++;
            masa11.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-11")==0)
            {
                labelGec.Text= Convert.ToString(dkm11);
                labelKal.Text= Convert.ToString(sr11);
                labelUcret.Text= Convert.ToString(ucr11)+ "tl";
            }
            if (dkm11==0 || dkm11%15 ==0)
                ucr11+=1.5;
            if (dkm11 >= sr11){ timer11.Stop();
                masa11.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 11'ÝN SÜRESÝ DOLMUÞTUR!"); }
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            dkm12++;
            masa12.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-12")==0)
            {
                labelGec.Text= Convert.ToString(dkm12);
                labelKal.Text= Convert.ToString(sr12);
                labelUcret.Text= Convert.ToString(ucr12)+ "tl";
            }
            if (dkm12==0 || dkm12%15 ==0)
                ucr12+=1.5;
            if (dkm12 >= sr12){ timer12.Stop();
                masa12.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 12'NÝN SÜRESÝ DOLMUÞTUR!"); }
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            dkm13++;
            masa13.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-13")==0)
            {
                labelGec.Text= Convert.ToString(dkm13);
                labelKal.Text= Convert.ToString(sr13);
                labelUcret.Text= Convert.ToString(ucr13)+ "tl";
            }
            if (dkm13==0 || dkm13%15 ==0)
                ucr13+=1.5;
            if (dkm13 >= sr13){ timer13.Stop();
                masa13.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 13'ÜN SÜRESÝ DOLMUÞTUR!"); }
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            dkm14++;
            masa14.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-14")==0)
            {
                labelGec.Text= Convert.ToString(dkm14);
                labelKal.Text= Convert.ToString(sr14);
                labelUcret.Text= Convert.ToString(ucr14)+ "tl";
            }
            if (dkm14==0 || dkm14%15 ==0)
                ucr14+=1.5;
            if (dkm14 >= sr14){ timer14.Stop();
                masa14.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 14'ÜN SÜRESÝ DOLMUÞTUR!"); }
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            dkm15++;
            masa15.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-15")==0)
            {
                labelGec.Text= Convert.ToString(dkm15);
                labelKal.Text= Convert.ToString(sr15);
                labelUcret.Text= Convert.ToString(ucr15)+ "tl";
            }
            if (dkm15==0 || dkm15%15 ==0)
                ucr15+=1.5;
            if (dkm15 >= sr15) {timer15.Stop();
                masa15.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 15'ÝN SÜRESÝ DOLMUÞTUR!"); }
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            dkm16++;
            masa16.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-16")==0)
            {
                labelGec.Text= Convert.ToString(dkm16);
                labelKal.Text= Convert.ToString(sr16);
                labelUcret.Text= Convert.ToString(ucr16)+ "tl";
            }
            if (dkm16==0 || dkm16%15 ==0)
                ucr16+=1.5;
            if (dkm16 >= sr16){ timer16.Stop();
                masa16.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 16'NIN SÜRESÝ DOLMUÞTUR!"); }
        }

        private void timer17_Tick(object sender, EventArgs e)
        {
            dkm17++;
            masa17.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-17")==0)
            {
                labelGec.Text= Convert.ToString(dkm17);
                labelKal.Text= Convert.ToString(sr17);
                labelUcret.Text= Convert.ToString(ucr17)+ "tl";
            }
            if (dkm17==0 || dkm17%15 ==0)
                ucr17+=1.5;
            if (dkm17 >= sr17){ timer17.Stop();
                masa17.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 17'NÝN SÜRESÝ DOLMUÞTUR!"); }
        }

        private void timer18_Tick(object sender, EventArgs e)
        {
            dkm18++;
            masa18.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-18")==0)
            {
                labelGec.Text= Convert.ToString(dkm18);
                labelKal.Text= Convert.ToString(sr18);
                labelUcret.Text= Convert.ToString(ucr18)+ "tl";
            }
            if (dkm18==0 || dkm18%15 ==0)
                ucr18+=1.5;
            if (dkm18 >= sr18){ timer18.Stop();
                masa18.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 18'ÝN SÜRESÝ DOLMUÞTUR!"); }
        }

        private void masa18_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-18";
            if (dkm18==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm18);
            labelKal.Text=Convert.ToString(sr18);
            if (dkm18==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr18);
            if (dkm18==0 || dkm18==sr18) labelUcret.Text=Convert.ToString(ucr18-1.5);
            if (dkm18 >= sr18) labelKal.Text= "0";
        }

        private void masa17_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-17";
            if (dkm17==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm17);
            labelKal.Text=Convert.ToString(sr17);
            if (dkm17==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr17);
            if (dkm17==0 || dkm17==sr17) labelUcret.Text=Convert.ToString(ucr17-1.5);
            if (dkm17 >= sr17) labelKal.Text= "0";
        }

        private void masa16_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-16";
            if (dkm16==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm16);
            labelKal.Text=Convert.ToString(sr16);
            if (dkm16==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr16);
            if (dkm16==0 || dkm16==sr16) labelUcret.Text=Convert.ToString(ucr16-1.5);
            if (dkm16 >= sr16) labelKal.Text= "0";
        }

        private void masa15_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-15";
            if (dkm15==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm15);
            labelKal.Text=Convert.ToString(sr15);
            if (dkm15==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr15);
            if (dkm15==0 || dkm15==sr15) labelUcret.Text=Convert.ToString(ucr15-1.5);
            if (dkm15 >= sr15) labelKal.Text= "0";
        }

        private void masa14_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-14";
            if (dkm14==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm14);
            labelKal.Text=Convert.ToString(sr14);
            if (dkm14==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr14);
            if (dkm14==0 || dkm14==sr14) labelUcret.Text=Convert.ToString(ucr14-1.5);
            if (dkm14 >= sr14) labelKal.Text= "0";
        }

        private void masa13_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-13";
            if (dkm13==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm13);
            labelKal.Text=Convert.ToString(sr13);
            if (dkm13==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr13);
            if (dkm13==0 || dkm13==sr13) labelUcret.Text=Convert.ToString(ucr13-1.5);
            if (dkm13 >= sr13) labelKal.Text= "0";
        }

        private void masa12_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-12";
            if (dkm12==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm12);
            labelKal.Text=Convert.ToString(sr12);
            if (dkm12==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr12);
            if (dkm12==0 || dkm12==sr12) labelUcret.Text=Convert.ToString(ucr12-1.5);
            if (dkm12 >= sr12) labelKal.Text= "0";
        }

        private void masa11_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-11";
            if (dkm11==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm11);
            labelKal.Text=Convert.ToString(sr11);
            if (dkm11==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr11);
            if (dkm11==0 || dkm11==sr11) labelUcret.Text=Convert.ToString(ucr11-1.5);
            if (dkm11 >= sr11) labelKal.Text= "0";
        }

        private void masa10_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-10";
            if (dkm10==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm10);
            labelKal.Text=Convert.ToString(sr10);
            if (dkm10==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr10);
            if (dkm10==0 || dkm10==sr10) labelUcret.Text=Convert.ToString(ucr10-1.5);
            if (dkm10 >= sr10) labelKal.Text= "0";
        }

        private void masa9_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-9";
            if (dkm9==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm9);
            labelKal.Text=Convert.ToString(sr9);
            if (dkm9==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr9);
            if (dkm9==0 || dkm9==sr9) labelUcret.Text=Convert.ToString(ucr9-1.5);
            if (dkm9 >= sr9) labelKal.Text= "0";
        }

        private void masa8_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-8";
            if (dkm8==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm8);
            labelKal.Text=Convert.ToString(sr8);
            if (dkm8==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr8);
            if (dkm8==0 || dkm8==sr8) labelUcret.Text=Convert.ToString(ucr8-1.5);
            if (dkm8 >= sr8) labelKal.Text= "0";
        }

        private void masa7_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-7";
            if (dkm7==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm7);
            labelKal.Text=Convert.ToString(sr7);
            if (dkm7==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr7);
            if (dkm7==0 || dkm7==sr7) labelUcret.Text=Convert.ToString(ucr7-1.5);
            if (dkm7 >= sr7) labelKal.Text= "0";
        }

        private void masa6_Click(object sender, EventArgs e)
        {
            labelMasa.Text="Masa-6";
            if (dkm6==0) labelGec.Text="0";
            labelGec.Text=Convert.ToString(dkm6);
            labelKal.Text=Convert.ToString(sr6);
            if (dkm6==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr6);
            if (dkm6==0 || dkm6==sr6) labelUcret.Text=Convert.ToString(ucr6-1.5);
            if (dkm6 >= sr6) labelKal.Text= "0";
        }


        private void buttonCont_Click(object sender, EventArgs e)
        {
            if (string.Compare(labelMasa.Text, "Masa-1")==0)
            {
                if (dkm1 != 0 && dkm1!=sr1) //normalde basýldýðýnda timer baþlamasýn diye
                    timer1.Start();
            }

            else if (string.Compare(labelMasa.Text, "Masa-2")==0)
            {
                if (dkm2 != 0&& dkm2!=sr2)
                    timer2.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-3")==0)
            {
                if (dkm3 != 0&& dkm3!=sr3)
                    timer3.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-4")==0)
            {
                if (dkm4 != 0&& dkm4!=sr4)
                    timer4.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-5")==0)
            {
                if (dkm5 != 0&& dkm5!=sr5)
                    timer5.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-6")==0)
            {
                if (dkm6 != 0&& dkm6!=sr6)
                    timer6.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-7")==0)
            {
                if (dkm7 != 0&& dkm7!=sr7)
                    timer7.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-8")==0)
            {
                if (dkm8 != 0&& dkm8!=sr8)
                    timer8.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-9")==0)
            {
                if (dkm9 != 0&& dkm9!=sr9)
                    timer9.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-10")==0)
            {
                if (dkm10 != 0&& dkm10!=sr10)
                    timer10.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-11")==0)
            {
                if (dkm11 != 0&& dkm11!=sr11)
                    timer11.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-12")==0)
            {
                if (dkm12 != 0&& dkm12!=sr12)
                    timer12.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-13")==0)
            {
                if (dkm13 != 0&& dkm13!=sr13)
                    timer13.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-14")==0)
            {
                if (dkm14 != 0&& dkm14!=sr14)
                    timer14.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-15")==0)
            {
                if (dkm15 != 0&& dkm15!=sr15)
                    timer15.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-16")==0)
            {
                if (dkm16 != 0&& dkm16!=sr16)
                    timer16.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-17")==0)
            {
                if (dkm17 != 0&& dkm17!=sr17)
                    timer17.Start();
            }
            else if (string.Compare(labelMasa.Text, "Masa-18")==0)
            {
                if (dkm18 != 0&& dkm18!=sr18)
                    timer18.Start();
            }
            else;
        }
      



            private void button3_Click(object sender, EventArgs e)
            {
                if (string.Compare(labelMasa.Text, "Masa-1")==0)
                {
                    sr1=Convert.ToInt32(textBoxSure.Text)+sr1;//textboxtaki sayýyý eklemek için
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
            masa5.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-5")==0)
            {
                labelGec.Text= Convert.ToString(dkm5);
                labelKal.Text= Convert.ToString(sr5);
                labelUcret.Text= Convert.ToString(ucr5)+ "tl";
            }
            if (dkm5==0 || dkm5%15 ==0)
                ucr5+=1.5;
            if (dkm5 >= sr5){ timer5.Stop();
                masa5.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 5'ÝN SÜRESÝ DOLMUÞTUR!"); }

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
            if (dkm3 >= sr3) {
                timer3.Stop();
                masa3.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 3'ÜN SÜRESÝ DOLMUÞTUR!"); }
        } 
        private void timer4_Tick(object sender, EventArgs e)
        {
            dkm4++;
            masa4.BackColor=Color.LightGreen;
            if (string.Compare(labelMasa.Text, "Masa-4")==0)
            {
                labelGec.Text= Convert.ToString(dkm4);
                labelKal.Text= Convert.ToString(sr4);
                labelUcret.Text= Convert.ToString(ucr4)+ "tl";
            }
            if (dkm4==0 || dkm4%15 ==0)
                ucr4+=1.5;
            if (dkm4 >= sr4){
                timer4.Stop();
                masa4.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 4'ÜN SÜRESÝ DOLMUÞTUR!"); }
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
            if (dkm1==0) labelGec.Text="0"; //timer kapandýðýnda 0 yazmak için
            labelGec.Text=Convert.ToString(dkm1);
            labelKal.Text=Convert.ToString(sr1);
            if (dkm1==0) labelKal.Text="0";
            labelUcret.Text=Convert.ToString(ucr1);
            if (dkm1==0 || dkm1==sr1) labelUcret.Text=Convert.ToString(ucr1-1.5);//ücreti düzgün yazdýrmak için "masalar 1 saat açýldýysa 6 tl"
            if (dkm1 >= sr1) labelKal.Text= "0";//kalan süreyi masa kapandýðýnda yazdýrmak için



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
                masa1.BackColor=Color.LightCoral;

            }
            else if (string.Compare(labelMasa.Text, "Masa-2")==0)
            {
                labelKal.Text = "0";
                timer2.Stop();
                dkm2 = 0;
                masa2.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-3")==0)
            {
                labelKal.Text = "0";
                timer3.Stop(); 
                dkm3 = 0;
                masa3.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-4")==0)
            {
                labelKal.Text = "0";
                timer4.Stop();
                dkm4 = 0;
                masa4.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-5")==0)
            {
                labelKal.Text = "0";
                timer5.Stop(); 
                dkm5 = 0;
                masa5.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-6")==0)
            {
                labelKal.Text = "0";
                timer6.Stop();
                dkm6 = 0;
                masa6.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-7")==0)
            {
                labelKal.Text = "0";
                timer7.Stop();
                dkm7 = 0;
                masa7.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-8")==0)
            {
                labelKal.Text = "0";
                timer8.Stop();
                dkm8 = 0;
                masa8.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-9")==0)
            {
                labelKal.Text = "0";
                timer9.Stop();
                dkm9 = 0;
                masa9.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-10")==0)
            {
                labelKal.Text = "0";
                timer10.Stop();
                dkm10 = 0;
                masa10.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-11")==0)
            {
                labelKal.Text = "0";
                timer11.Stop();
                dkm11 = 0;
                masa11.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-12")==0)
            {
                labelKal.Text = "0";
                timer12.Stop();
                dkm12 = 0;
                masa12.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-13")==0)
            {
                labelKal.Text = "0";
                timer13.Stop();
                dkm13 = 0;
                masa13.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-14")==0)
            {
                labelKal.Text = "0";
                timer14.Stop();
                dkm14 = 0;
                masa14.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-15")==0)
            {
                labelKal.Text = "0";
                timer15.Stop();
                dkm15 = 0;
                masa15.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-16")==0)
            {
                labelKal.Text = "0";
                timer16.Stop();
                dkm16 = 0;
                masa16.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-17")==0)
            {
                labelKal.Text = "0";
                timer17.Stop();
                dkm17 = 0;
                masa17.BackColor=Color.LightCoral;
            }
            else if (string.Compare(labelMasa.Text, "Masa-18")==0)
            {
                labelKal.Text = "0";
                timer18.Stop();
                dkm18 = 0;
                masa18.BackColor=Color.LightCoral;
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
            if (dkm1 >= sr1) {  
                timer1.Stop();
                masa1.BackColor=Color.LightCoral;
            
             MessageBox.Show("MASA 1'ÝN SÜRESÝ DOLMUÞTUR!"); }
                

        }

        private void buttonMAc_Click(object sender, EventArgs e)
        {
            {
                if (string.Compare(textBoxSure.Text, "") == 1) // TextBox boþ ise çalýþmamasýný saðlar

                {
                    if (string.Compare(labelMasa.Text, "Masa-1") == 0)// hangi masa timer'ý baþlayacak onu görmek için
                    {
                        sr1 = Convert.ToInt32(textBoxSure.Text);
                        timer1.Start();
                        dkm1 = 1;
                        ucr1 = 1.5;
                        masa1.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm1);
                        labelKal.Text= Convert.ToString(sr1);
                        labelUcret.Text= Convert.ToString(ucr1);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-2") == 0)
                    {
                        sr2 = Convert.ToInt32(textBoxSure.Text);
                        timer2.Start();
                        dkm2 = 1;
                        ucr2 = 1.5;
                        masa2.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm2);
                        labelKal.Text= Convert.ToString(sr2);
                        labelUcret.Text= Convert.ToString(ucr2);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-3") == 0)
                    {
                        sr3 = Convert.ToInt32(textBoxSure.Text);
                        timer3.Start();
                        dkm3 =1;
                        ucr3 = 1.5;
                        masa3.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm3);
                        labelKal.Text= Convert.ToString(sr3);
                        labelUcret.Text= Convert.ToString(ucr3);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-4") == 0)
                    {
                        sr4 = Convert.ToInt32(textBoxSure.Text);
                        timer4.Start();
                        dkm4 = 1;
                        ucr4 = 1.5;
                        masa4.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm4);
                        labelKal.Text= Convert.ToString(sr4);
                        labelUcret.Text= Convert.ToString(ucr4);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-5") == 0)
                    {
                        sr5 = Convert.ToInt32(textBoxSure.Text);
                        timer5.Start();
                        dkm5 = 1;
                        ucr5 = 1.5;
                        masa5.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm5);
                        labelKal.Text= Convert.ToString(sr5);
                        labelUcret.Text= Convert.ToString(ucr5);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-6") == 0)
                    {
                        sr6 = Convert.ToInt32(textBoxSure.Text);
                        timer6.Start();
                        dkm6 = 1;
                        ucr6 = 1.5;
                        masa6.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm6);
                        labelKal.Text= Convert.ToString(sr6);
                        labelUcret.Text= Convert.ToString(ucr6);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-7") == 0)
                    {
                        sr7 = Convert.ToInt32(textBoxSure.Text);
                        timer7.Start();
                        dkm7 = 1;
                        ucr7 = 1.5;
                        masa7.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm7);
                        labelKal.Text= Convert.ToString(sr7);
                        labelUcret.Text= Convert.ToString(ucr7);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-8") == 0)
                    {
                        sr8 = Convert.ToInt32(textBoxSure.Text);
                        timer8.Start();
                        dkm8 = 1;
                        ucr8 = 1.5;
                        masa8.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm8);
                        labelKal.Text= Convert.ToString(sr8);
                        labelUcret.Text= Convert.ToString(ucr8);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-9") == 0)
                    {
                        sr9 = Convert.ToInt32(textBoxSure.Text);
                        timer9.Start();
                        dkm9 = 1;
                        ucr9 = 1.5;
                        masa9.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm9);
                        labelKal.Text= Convert.ToString(sr9);
                        labelUcret.Text= Convert.ToString(ucr9);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-10") == 0)
                    {
                        sr10 = Convert.ToInt32(textBoxSure.Text);
                        timer10.Start();
                        dkm10 = 1;
                        ucr10 = 1.5;
                        masa10.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm10);
                        labelKal.Text= Convert.ToString(sr10);
                        labelUcret.Text= Convert.ToString(ucr10);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-11") == 0)
                    {
                        sr11 = Convert.ToInt32(textBoxSure.Text);
                        timer11.Start();
                        dkm11 = 1;
                        ucr11 = 1.5;
                        masa11.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm11);
                        labelKal.Text= Convert.ToString(sr11);
                        labelUcret.Text= Convert.ToString(ucr11);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-12") == 0)
                    {
                        sr12 = Convert.ToInt32(textBoxSure.Text);
                        timer12.Start();
                        dkm12 = 1;
                        ucr12 = 1.5;
                        masa12.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm12);
                        labelKal.Text= Convert.ToString(sr12);
                        labelUcret.Text= Convert.ToString(ucr12);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-13") == 0)
                    {
                        sr13 = Convert.ToInt32(textBoxSure.Text);
                        timer13.Start();
                        dkm13 = 1;
                        ucr13 = 1.5;
                        masa13.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm13);
                        labelKal.Text= Convert.ToString(sr13);
                        labelUcret.Text= Convert.ToString(ucr13);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-14") == 0)
                    {
                        sr14 = Convert.ToInt32(textBoxSure.Text);
                        timer14.Start();
                        dkm14 = 1;
                        ucr14 = 1.5;
                        masa14.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm14);
                        labelKal.Text= Convert.ToString(sr14);
                        labelUcret.Text= Convert.ToString(ucr14);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-15") == 0)
                    {
                        sr15 = Convert.ToInt32(textBoxSure.Text);
                        timer15.Start();
                        dkm15 = 1;
                        ucr15 = 1.5;
                        masa15.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm15);
                        labelKal.Text= Convert.ToString(sr15);
                        labelUcret.Text= Convert.ToString(ucr15);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-16") == 0)
                    {
                        sr16 = Convert.ToInt32(textBoxSure.Text);
                        timer16.Start();
                        dkm16 = 1;
                        ucr16 = 1.5;
                        masa16.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm16);
                        labelKal.Text= Convert.ToString(sr16);
                        labelUcret.Text= Convert.ToString(ucr16);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-17") == 0)
                    {
                        sr17 = Convert.ToInt32(textBoxSure.Text);
                        timer17.Start();
                        dkm17 = 1;
                        ucr17 = 1.5;
                        masa17.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm17);
                        labelKal.Text= Convert.ToString(sr17);
                        labelUcret.Text= Convert.ToString(ucr17);
                    }
                    else if (string.Compare(labelMasa.Text, "Masa-18") == 0)
                    {
                        sr18 = Convert.ToInt32(textBoxSure.Text);
                        timer18.Start();
                        dkm18 = 1;
                        ucr18 = 1.5;
                        masa18.BackColor=Color.LightGreen;
                        labelGec.Text= Convert.ToString(dkm18);
                        labelKal.Text= Convert.ToString(sr18);
                        labelUcret.Text= Convert.ToString(ucr18);
                    }
                    else;
                }
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
            if (dkm2 >= sr2){ timer2.Stop();
                masa2.BackColor=Color.LightCoral;
                MessageBox.Show("MASA 2'NÝN SÜRESÝ DOLMUÞTUR!"); }



        }
    }
}