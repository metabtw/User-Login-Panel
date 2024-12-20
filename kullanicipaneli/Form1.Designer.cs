namespace kullanicipaneli
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kullaniciaditxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.sifregoster = new System.Windows.Forms.CheckBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.yenisifretxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifretekrartxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginbtn);
            this.groupBox1.Controls.Add(this.sifregoster);
            this.groupBox1.Controls.Add(this.sifretxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kullaniciaditxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Girişi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exitbtn);
            this.groupBox2.Controls.Add(this.savebtn);
            this.groupBox2.Controls.Add(this.sifretekrartxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.yenisifretxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(316, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifre Değiştir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // kullaniciaditxt
            // 
            this.kullaniciaditxt.Location = new System.Drawing.Point(120, 53);
            this.kullaniciaditxt.Name = "kullaniciaditxt";
            this.kullaniciaditxt.Size = new System.Drawing.Size(100, 26);
            this.kullaniciaditxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre :";
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(120, 99);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(100, 26);
            this.sifretxt.TabIndex = 3;
            // 
            // sifregoster
            // 
            this.sifregoster.AutoSize = true;
            this.sifregoster.Location = new System.Drawing.Point(21, 163);
            this.sifregoster.Name = "sifregoster";
            this.sifregoster.Size = new System.Drawing.Size(114, 24);
            this.sifregoster.TabIndex = 4;
            this.sifregoster.Text = "Şifre Göster";
            this.sifregoster.UseVisualStyleBackColor = true;
            this.sifregoster.CheckedChanged += new System.EventHandler(this.sifregoster_CheckedChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(154, 155);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(113, 38);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Giriş Yap";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // yenisifretxt
            // 
            this.yenisifretxt.Location = new System.Drawing.Point(160, 53);
            this.yenisifretxt.Name = "yenisifretxt";
            this.yenisifretxt.Size = new System.Drawing.Size(100, 26);
            this.yenisifretxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yeni Şifre :";
            // 
            // sifretekrartxt
            // 
            this.sifretekrartxt.Location = new System.Drawing.Point(160, 99);
            this.sifretekrartxt.Name = "sifretekrartxt";
            this.sifretekrartxt.Size = new System.Drawing.Size(100, 26);
            this.sifretekrartxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yeni Şifre Tekrar :";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(20, 155);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(113, 38);
            this.savebtn.TabIndex = 6;
            this.savebtn.Text = "Kaydet";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(160, 155);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(113, 38);
            this.exitbtn.TabIndex = 8;
            this.exitbtn.Text = "Çıkış Yap";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(623, 235);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.CheckBox sifregoster;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullaniciaditxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox sifretekrartxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yenisifretxt;
        private System.Windows.Forms.Label label3;
    }
}

