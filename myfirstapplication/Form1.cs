using System.Diagnostics.Eventing.Reader;

namespace myfirstapplication
{
    public partial class Form1 : Form
    {
        public bool girisYapildiMi = false;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.Text = "ATM Uygulaması";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (girisYapildiMi)
            {
                MessageBox.Show("Zaten giriş yaptınız!");
            }
            else
            {
                girisSekmesiAc();
            }

        }

        public void sekme1Ac()
        {
            this.Controls.Clear();
            this.Show();
        }

        public void girisSekmesiAc()
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (girisYapildiMi == false)
            {
                MessageBox.Show("Lütfen önce giriş yapın!");

            }
            else
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
        }
    }
}
