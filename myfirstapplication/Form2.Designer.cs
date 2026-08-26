namespace myfirstapplication
{
    partial class Form2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(593, 26);
            label1.Name = "label1";
            label1.Size = new Size(258, 74);
            label1.TabIndex = 0;
            label1.Text = "Giriş yap";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(593, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(593, 310);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(593, 173);
            label2.Name = "label2";
            label2.Size = new Size(190, 38);
            label2.TabIndex = 3;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(593, 269);
            label3.Name = "label3";
            label3.Size = new Size(86, 38);
            label3.TabIndex = 4;
            label3.Text = "Şifre:";
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(626, 392);
            button1.Name = "button1";
            button1.Size = new Size(184, 45);
            button1.TabIndex = 5;
            button1.Text = "Gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 648);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}