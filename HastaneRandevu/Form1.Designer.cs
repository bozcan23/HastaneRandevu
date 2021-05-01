
namespace HastaneRandevu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbpoliklinik = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbdoktor = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.lbsaat = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbltcno = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbpoliklinik
            // 
            this.lbpoliklinik.FormattingEnabled = true;
            this.lbpoliklinik.ItemHeight = 20;
            this.lbpoliklinik.Location = new System.Drawing.Point(440, 264);
            this.lbpoliklinik.Name = "lbpoliklinik";
            this.lbpoliklinik.Size = new System.Drawing.Size(150, 144);
            this.lbpoliklinik.TabIndex = 0;
            this.lbpoliklinik.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbpoliklinik_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(465, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Poliklinikler";
            // 
            // lbdoktor
            // 
            this.lbdoktor.FormattingEnabled = true;
            this.lbdoktor.ItemHeight = 20;
            this.lbdoktor.Location = new System.Drawing.Point(596, 264);
            this.lbdoktor.Name = "lbdoktor";
            this.lbdoktor.Size = new System.Drawing.Size(150, 144);
            this.lbdoktor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(635, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doktorlar";
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(752, 264);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(257, 27);
            this.dttarih.TabIndex = 4;
            this.dttarih.ValueChanged += new System.EventHandler(this.dttarih_ValueChanged);
            // 
            // lbsaat
            // 
            this.lbsaat.FormattingEnabled = true;
            this.lbsaat.ItemHeight = 20;
            this.lbsaat.Location = new System.Drawing.Point(1018, 264);
            this.lbsaat.Name = "lbsaat";
            this.lbsaat.Size = new System.Drawing.Size(257, 84);
            this.lbsaat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(823, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Randevu Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1088, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Randevu Saati";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 414);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(965, 188);
            this.dataGridView1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(965, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1008, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(394, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(463, 59);
            this.label5.TabIndex = 11;
            this.label5.Text = "T.C. SAĞLIK BAKANLIĞI";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.BackColor = System.Drawing.Color.White;
            this.lbladsoyad.Location = new System.Drawing.Point(50, 264);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(78, 20);
            this.lbladsoyad.TabIndex = 12;
            this.lbladsoyad.Text = "Ad-Soyad:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 264);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 27);
            this.textBox1.TabIndex = 13;
            // 
            // lbltcno
            // 
            this.lbltcno.AutoSize = true;
            this.lbltcno.BackColor = System.Drawing.Color.White;
            this.lbltcno.Location = new System.Drawing.Point(50, 315);
            this.lbltcno.Name = "lbltcno";
            this.lbltcno.Size = new System.Drawing.Size(104, 20);
            this.lbltcno.TabIndex = 14;
            this.lbltcno.Text = "T.C. Kimlik No:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 315);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 27);
            this.textBox2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(394, 626);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Soru ve sorunlarınız için Alo182 hattından bize ulaşabilirsiniz";
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Lime;
            this.btnkaydet.Location = new System.Drawing.Point(1015, 426);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(257, 56);
            this.btnkaydet.TabIndex = 17;
            this.btnkaydet.Text = "Randevu Al";
            this.btnkaydet.UseVisualStyleBackColor = false;
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.Red;
            this.btniptal.Location = new System.Drawing.Point(1015, 511);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(257, 61);
            this.btniptal.TabIndex = 18;
            this.btniptal.Text = "Randevu İptal";
            this.btniptal.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1287, 675);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbltcno);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbladsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbsaat);
            this.Controls.Add(this.dttarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbdoktor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbpoliklinik);
            this.Name = "Form1";
            this.Text = "HASTANE RANDEVU SİSTEMİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbpoliklinik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbdoktor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.ListBox lbsaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbltcno;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btniptal;
    }
}

