namespace eklesilgüncelle
{
    partial class Form1
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
            this.kullanıcı = new System.Windows.Forms.Label();
            this.şifre = new System.Windows.Forms.Label();
            this.girisbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kullanıcı
            // 
            this.kullanıcı.AutoSize = true;
            this.kullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcı.Location = new System.Drawing.Point(34, 62);
            this.kullanıcı.Name = "kullanıcı";
            this.kullanıcı.Size = new System.Drawing.Size(104, 18);
            this.kullanıcı.TabIndex = 0;
            this.kullanıcı.Text = "Kullanıcı Adı:";
            // 
            // şifre
            // 
            this.şifre.AutoSize = true;
            this.şifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.şifre.Location = new System.Drawing.Point(34, 120);
            this.şifre.Name = "şifre";
            this.şifre.Size = new System.Drawing.Size(48, 18);
            this.şifre.TabIndex = 1;
            this.şifre.Text = "Şifre:";
            // 
            // girisbutton
            // 
            this.girisbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbutton.Location = new System.Drawing.Point(79, 263);
            this.girisbutton.Name = "girisbutton";
            this.girisbutton.Size = new System.Drawing.Size(182, 47);
            this.girisbutton.TabIndex = 2;
            this.girisbutton.Text = "GİRİŞ";
            this.girisbutton.UseVisualStyleBackColor = true;
            this.girisbutton.Click += new System.EventHandler(this.girisbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(357, 359);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.girisbutton);
            this.Controls.Add(this.şifre);
            this.Controls.Add(this.kullanıcı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullanıcı;
        private System.Windows.Forms.Label şifre;
        private System.Windows.Forms.Button girisbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

