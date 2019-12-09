namespace SirketClient
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btn_must_ekle = new System.Windows.Forms.Button();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.txt_tckimlik = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(404, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(402, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(550, 35);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(112, 44);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_must_ekle
            // 
            this.btn_must_ekle.Location = new System.Drawing.Point(40, 35);
            this.btn_must_ekle.Name = "btn_must_ekle";
            this.btn_must_ekle.Size = new System.Drawing.Size(125, 44);
            this.btn_must_ekle.TabIndex = 2;
            this.btn_must_ekle.Text = "Ekle";
            this.btn_must_ekle.UseVisualStyleBackColor = true;
            this.btn_must_ekle.Click += new System.EventHandler(this.btn_must_ekle_Click);
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(28, 130);
            this.txt_isim.Multiline = true;
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(198, 26);
            this.txt_isim.TabIndex = 3;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(28, 187);
            this.txt_soyisim.Multiline = true;
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(198, 26);
            this.txt_soyisim.TabIndex = 4;
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(12, 313);
            this.txt_Adres.Multiline = true;
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(329, 184);
            this.txt_Adres.TabIndex = 6;
            // 
            // txt_tckimlik
            // 
            this.txt_tckimlik.Location = new System.Drawing.Point(28, 247);
            this.txt_tckimlik.Multiline = true;
            this.txt_tckimlik.Name = "txt_tckimlik";
            this.txt_tckimlik.Size = new System.Drawing.Size(198, 26);
            this.txt_tckimlik.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 534);
            this.Controls.Add(this.txt_tckimlik);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.btn_must_ekle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btn_must_ekle;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.TextBox txt_tckimlik;
    }
}

