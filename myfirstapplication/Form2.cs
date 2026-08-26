using System;
using System.Drawing;
using System.Windows.Forms;

namespace myfirstapplication
{
    public partial class Form2 : Form
    {
        public string kullaniciAdi = "admin";
        public string sifre = "1234";

        private Form1 _anaForm;

        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
        }

        public Form2(Form1 anaForm) : this()
        {
            _anaForm = anaForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == kullaniciAdi && textBox2.Text == sifre)
            {
                _anaForm.girisYapildiMi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifreniz yanlış!");
            }
        }
    }
}