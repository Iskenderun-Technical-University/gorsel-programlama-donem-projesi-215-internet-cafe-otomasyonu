namespace ProjeInternetCafe
{
    public partial class Form1 : Form
    {
        public int x = 0;
        public int get_x()
        {
            return x;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BÝLGÝSAYAR AKTÝF EDÝLDÝ.."); 
        }

        private void masa1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.label1.Text = "Masa-1";
            form2.Show();
            
        }

        private void masa2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.label1.Text = "Masa-2";
            form2.Show();
        }
    }
}