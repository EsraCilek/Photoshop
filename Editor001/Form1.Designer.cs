namespace Editor001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Olcekle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sec = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtw = new System.Windows.Forms.TextBox();
            this.txth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resmiYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.döndürmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dereceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sYTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griTonlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aynalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terslemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(16, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1447, 581);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Olcekle
            // 
            this.Olcekle.Location = new System.Drawing.Point(667, 33);
            this.Olcekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Olcekle.Name = "Olcekle";
            this.Olcekle.Size = new System.Drawing.Size(93, 27);
            this.Olcekle.TabIndex = 6;
            this.Olcekle.Text = "Ölçeklendir";
            this.Olcekle.UseVisualStyleBackColor = true;
            this.Olcekle.Click += new System.EventHandler(this.Olcekle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RGB",
            "Red",
            "Green",
            "Blue"});
            this.comboBox1.Location = new System.Drawing.Point(77, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sec
            // 
            this.sec.Location = new System.Drawing.Point(192, 33);
            this.sec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(137, 26);
            this.sec.TabIndex = 9;
            this.sec.Text = "Renk Kanalı Seç";
            this.sec.UseVisualStyleBackColor = true;
            this.sec.Click += new System.EventHandler(this.sec_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(16, 68);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1448, 582);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(16, 68);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1448, 582);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // txtw
            // 
            this.txtw.BackColor = System.Drawing.SystemColors.Control;
            this.txtw.Location = new System.Drawing.Point(404, 36);
            this.txtw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtw.Name = "txtw";
            this.txtw.Size = new System.Drawing.Size(83, 22);
            this.txtw.TabIndex = 15;
            this.txtw.TextChanged += new System.EventHandler(this.txtw_TextChanged);
            // 
            // txth
            // 
            this.txth.BackColor = System.Drawing.SystemColors.Control;
            this.txth.Location = new System.Drawing.Point(575, 36);
            this.txth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(83, 22);
            this.txth.TabIndex = 16;
            this.txth.TextChanged += new System.EventHandler(this.txth_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Genişlik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Yükseklik";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.düzenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1472, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.yeniSayfaToolStripMenuItem,
            this.resmiYenileToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // yeniSayfaToolStripMenuItem
            // 
            this.yeniSayfaToolStripMenuItem.Name = "yeniSayfaToolStripMenuItem";
            this.yeniSayfaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.yeniSayfaToolStripMenuItem.Text = "Yeni Sayfa";
            this.yeniSayfaToolStripMenuItem.Click += new System.EventHandler(this.yeniSayfaToolStripMenuItem_Click);
            // 
            // resmiYenileToolStripMenuItem
            // 
            this.resmiYenileToolStripMenuItem.Name = "resmiYenileToolStripMenuItem";
            this.resmiYenileToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.resmiYenileToolStripMenuItem.Text = "Resmi Yenile";
            this.resmiYenileToolStripMenuItem.Click += new System.EventHandler(this.resmiYenileToolStripMenuItem_Click);
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.döndürmeToolStripMenuItem,
            this.griTonlamaToolStripMenuItem});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // döndürmeToolStripMenuItem
            // 
            this.döndürmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dereceToolStripMenuItem,
            this.sYTToolStripMenuItem});
            this.döndürmeToolStripMenuItem.Name = "döndürmeToolStripMenuItem";
            this.döndürmeToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.döndürmeToolStripMenuItem.Text = "Döndürme";
            // 
            // dereceToolStripMenuItem
            // 
            this.dereceToolStripMenuItem.Name = "dereceToolStripMenuItem";
            this.dereceToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.dereceToolStripMenuItem.Text = "90 ° SY";
            this.dereceToolStripMenuItem.Click += new System.EventHandler(this.dereceToolStripMenuItem_Click);
            // 
            // sYTToolStripMenuItem
            // 
            this.sYTToolStripMenuItem.Name = "sYTToolStripMenuItem";
            this.sYTToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.sYTToolStripMenuItem.Text = "90 ° SYT";
            this.sYTToolStripMenuItem.Click += new System.EventHandler(this.sYTToolStripMenuItem_Click);
            // 
            // griTonlamaToolStripMenuItem
            // 
            this.griTonlamaToolStripMenuItem.Name = "griTonlamaToolStripMenuItem";
            this.griTonlamaToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.griTonlamaToolStripMenuItem.Text = "Gri Tonlama";
            this.griTonlamaToolStripMenuItem.Click += new System.EventHandler(this.griTonlamaToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aynalamaToolStripMenuItem,
            this.terslemeToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // aynalamaToolStripMenuItem
            // 
            this.aynalamaToolStripMenuItem.Name = "aynalamaToolStripMenuItem";
            this.aynalamaToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.aynalamaToolStripMenuItem.Text = "Aynalama";
            this.aynalamaToolStripMenuItem.Click += new System.EventHandler(this.aynalamaToolStripMenuItem_Click);
            // 
            // terslemeToolStripMenuItem
            // 
            this.terslemeToolStripMenuItem.Name = "terslemeToolStripMenuItem";
            this.terslemeToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.terslemeToolStripMenuItem.Text = "Tersleme";
            this.terslemeToolStripMenuItem.Click += new System.EventHandler(this.terslemeToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 34);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(47, 34);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 21);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1472, 656);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txth);
            this.Controls.Add(this.txtw);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Olcekle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Görüntü İşleme Editörü";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Olcekle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button sec;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtw;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resmiYenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem döndürmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dereceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sYTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griTonlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aynalamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terslemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

