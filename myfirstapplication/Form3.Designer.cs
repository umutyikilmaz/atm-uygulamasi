namespace myfirstapplication
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            textBox2 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(450, 28);
            label1.Name = "label1";
            label1.Size = new Size(565, 74);
            label1.TabIndex = 0;
            label1.Text = "ATM'ye Hoşgeldiniz!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(608, 182);
            label2.Name = "label2";
            label2.Size = new Size(222, 38);
            label2.TabIndex = 1;
            label2.Text = "İşleminizi seçin:";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(450, 300);
            button1.Name = "button1";
            button1.Size = new Size(156, 63);
            button1.TabIndex = 2;
            button1.Text = "Para Çek";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(859, 300);
            button2.Name = "button2";
            button2.Size = new Size(156, 63);
            button2.TabIndex = 3;
            button2.Text = "Para Yatır";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 40.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(564, 28);
            label3.Name = "label3";
            label3.Size = new Size(337, 74);
            label3.TabIndex = 4;
            label3.Text = "Para Çekme";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(537, 182);
            label4.Name = "label4";
            label4.Size = new Size(411, 38);
            label4.TabIndex = 5;
            label4.Text = "Çekilecek Para Miktarını girin:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(608, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(638, 329);
            button3.Name = "button3";
            button3.Size = new Size(156, 63);
            button3.TabIndex = 7;
            button3.Text = "Para Çek";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1, 9);
            label5.Name = "label5";
            label5.Size = new Size(162, 38);
            label5.TabIndex = 8;
            label5.Text = "Nakit Para:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.75F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1, 64);
            label6.Name = "label6";
            label6.Size = new Size(227, 38);
            label6.TabIndex = 9;
            label6.Text = "Bankadaki Para:";
            label6.Click += label6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(638, 329);
            button4.Name = "button4";
            button4.Size = new Size(156, 63);
            button4.TabIndex = 13;
            button4.Text = "Para Yatır";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(608, 271);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 23);
            textBox2.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.75F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(537, 182);
            label7.Name = "label7";
            label7.Size = new Size(422, 38);
            label7.TabIndex = 11;
            label7.Text = "Yatırılacak Para Miktarını girin:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 40.75F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(564, 28);
            label8.Name = "label8";
            label8.Size = new Size(359, 74);
            label8.TabIndex = 10;
            label8.Text = "Para Yatırma";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 648);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button3;
        private Label label5;
        private Label label6;
        private Button button4;
        private TextBox textBox2;
        private Label label7;
        private Label label8;
    }
}