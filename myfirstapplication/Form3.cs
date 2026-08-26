using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace myfirstapplication
{
    public partial class Form3 : Form
    {
        public int kullaniciPara = 10000;
        public int kullaniciNakitPara = 10;


        public Form3()
        {
            InitializeComponent();
            anamenuac();
            this.BackColor = Color.Black;
            label6.Text = "Bankadaki Para " + kullaniciPara + " TL";
            label5.Text = "Cüzdandaki Para " + kullaniciNakitPara + " TL";
        }

        public void anamenuac()
        {
            label1.Visible = true;
            label2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            button3.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            textBox2.Visible = false;
            button4.Visible = false;
        }

        public void paracekmeac()
        {
            label1.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            button3.Visible = true;
            label7.Visible = false;
            label8.Visible = false;
            textBox2.Visible = false;
            button4.Visible = false;
        }

        public void parayatirmaac()
        {
            label1.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label7.Visible = true;
            label8.Visible = true;
            textBox2.Visible = true;
            button4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paracekmeac();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Para çekme işlemi
            try
            {
                int cekilecekMikttar = Convert.ToInt32(textBox1.Text);
                if(cekilecekMikttar > kullaniciPara)
                {
                    MessageBox.Show("Bankadaki paranız yetersiz!");
                    return;
                }
                kullaniciPara -= cekilecekMikttar;
                kullaniciNakitPara += cekilecekMikttar;
                label6.Text = "Bankadaki Para " + kullaniciPara + " TL";
                label5.Text = "Cüzdandaki Para " + kullaniciNakitPara + " TL";
                anamenuac();
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Para yatırma işlemi
            if (kullaniciNakitPara > 0)
            {
                try
                {
                    int yatirilacakMiktar = Convert.ToInt32(textBox2.Text);
                    if(yatirilacakMiktar <= kullaniciNakitPara)
                    {
                        kullaniciNakitPara -= yatirilacakMiktar;
                        kullaniciPara += yatirilacakMiktar;
                        label6.Text = "Bankadaki Para " + kullaniciPara + " TL";
                        label5.Text = "Cüzdandaki Para " + kullaniciNakitPara + " TL";
                        anamenuac();
                    }
                    else
                    {
                        MessageBox.Show("Cüzdanınızda yeterli para yok!");
                    }
                }
                catch
                {
                    MessageBox.Show("Lütfen geçerli bir sayı girin!");
                }
            }
            else
            {
                MessageBox.Show("Cüzdanınızda para yok!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(kullaniciNakitPara > 0)
            {
                parayatirmaac();
            }
            else
            {
                MessageBox.Show("Cüzdanınızda Para yok!");
            }
            
        }
    }
}
