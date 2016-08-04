namespace rehber
{
    partial class FrmRehber
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
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelDogumTarihi = new System.Windows.Forms.Label();
            this.labelCinsiyet = new System.Windows.Forms.Label();
            this.labelIsTanim = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pictureBoxGoster = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnKullaniciDegistir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLBStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.lblSifreDegistir = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoster)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTelefon.Location = new System.Drawing.Point(112, 5);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(12, 18);
            this.labelTelefon.TabIndex = 14;
            this.labelTelefon.Text = "-";
            // 
            // labelDogumTarihi
            // 
            this.labelDogumTarihi.AutoSize = true;
            this.labelDogumTarihi.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDogumTarihi.Location = new System.Drawing.Point(112, 40);
            this.labelDogumTarihi.Name = "labelDogumTarihi";
            this.labelDogumTarihi.Size = new System.Drawing.Size(12, 18);
            this.labelDogumTarihi.TabIndex = 15;
            this.labelDogumTarihi.Text = "-";
            // 
            // labelCinsiyet
            // 
            this.labelCinsiyet.AutoSize = true;
            this.labelCinsiyet.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCinsiyet.Location = new System.Drawing.Point(110, 75);
            this.labelCinsiyet.Name = "labelCinsiyet";
            this.labelCinsiyet.Size = new System.Drawing.Size(12, 18);
            this.labelCinsiyet.TabIndex = 16;
            this.labelCinsiyet.Text = "-";
            // 
            // labelIsTanim
            // 
            this.labelIsTanim.AllowDrop = true;
            this.labelIsTanim.AutoEllipsis = true;
            this.labelIsTanim.AutoSize = true;
            this.labelIsTanim.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIsTanim.Location = new System.Drawing.Point(21, 132);
            this.labelIsTanim.MaximumSize = new System.Drawing.Size(250, 105);
            this.labelIsTanim.Name = "labelIsTanim";
            this.labelIsTanim.Size = new System.Drawing.Size(12, 18);
            this.labelIsTanim.TabIndex = 17;
            this.labelIsTanim.Text = "-";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuncelle.BackColor = System.Drawing.Color.DimGray;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Font = new System.Drawing.Font("Buxton Sketch", 12F);
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuncelle.Location = new System.Drawing.Point(25, 222);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(149, 35);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Kişi Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.BackColor = System.Drawing.Color.DimGray;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSil.Location = new System.Drawing.Point(25, 264);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(149, 47);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pictureBoxGoster
            // 
            this.pictureBoxGoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGoster.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxGoster.BackgroundImage = global::rehber.image.icon_user_default;
            this.pictureBoxGoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGoster.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxGoster.Name = "pictureBoxGoster";
            this.pictureBoxGoster.Size = new System.Drawing.Size(149, 179);
            this.pictureBoxGoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGoster.TabIndex = 4;
            this.pictureBoxGoster.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBoxGoster);
            this.panel3.Location = new System.Drawing.Point(19, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 189);
            this.panel3.TabIndex = 0;
            // 
            // btnKullaniciDegistir
            // 
            this.btnKullaniciDegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKullaniciDegistir.BackColor = System.Drawing.Color.DimGray;
            this.btnKullaniciDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullaniciDegistir.Font = new System.Drawing.Font("Buxton Sketch", 12F);
            this.btnKullaniciDegistir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKullaniciDegistir.Location = new System.Drawing.Point(19, 332);
            this.btnKullaniciDegistir.Name = "btnKullaniciDegistir";
            this.btnKullaniciDegistir.Size = new System.Drawing.Size(160, 42);
            this.btnKullaniciDegistir.TabIndex = 3;
            this.btnKullaniciDegistir.Text = "Kullanıcı Değiştir >>";
            this.btnKullaniciDegistir.UseVisualStyleBackColor = false;
            this.btnKullaniciDegistir.Click += new System.EventHandler(this.btnKullaniciDegistir_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnGuncelle);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.btnKullaniciDegistir);
            this.panel4.Controls.Add(this.btnSil);
            this.panel4.Location = new System.Drawing.Point(620, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 387);
            this.panel4.TabIndex = 2;
           
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnYeniKayit.BackColor = System.Drawing.Color.DimGray;
            this.btnYeniKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeniKayit.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnYeniKayit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnYeniKayit.Location = new System.Drawing.Point(13, 283);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(210, 45);
            this.btnYeniKayit.TabIndex = 1;
            this.btnYeniKayit.Text = "Kayıt Ekle";
            this.btnYeniKayit.UseVisualStyleBackColor = false;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Buxton Sketch", 11F);
            this.label4.Location = new System.Drawing.Point(11, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "~ Telefon            :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Buxton Sketch", 11F);
            this.label5.Location = new System.Drawing.Point(11, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "~ Doğum Tarihi  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Buxton Sketch", 11F);
            this.label6.Location = new System.Drawing.Point(11, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "~ Cinsiyet           :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Buxton Sketch", 11F, System.Drawing.FontStyle.Underline);
            this.label7.Location = new System.Drawing.Point(11, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "~ İş Tanımı        :";
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(10, 15);
            this.labelAdSoyad.MaximumSize = new System.Drawing.Size(280, 40);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(33, 32);
            this.labelAdSoyad.TabIndex = 13;
            this.labelAdSoyad.Text = "...";
            this.labelAdSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(13, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 242);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // textBoxAra
            // 
            this.textBoxAra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxAra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxAra.Location = new System.Drawing.Point(56, 8);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(168, 23);
            this.textBoxAra.TabIndex = 0;
            this.textBoxAra.TextChanged += new System.EventHandler(this.textBoxAra_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Buxton Sketch", 11F);
            this.label14.Location = new System.Drawing.Point(15, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 19);
            this.label14.TabIndex = 18;
            this.label14.Text = "ARA  :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblLBStatus);
            this.panel1.Location = new System.Drawing.Point(13, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 27);
            this.panel1.TabIndex = 21;
            // 
            // lblLBStatus
            // 
            this.lblLBStatus.AutoSize = true;
            this.lblLBStatus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLBStatus.Location = new System.Drawing.Point(8, 5);
            this.lblLBStatus.Name = "lblLBStatus";
            this.lblLBStatus.Size = new System.Drawing.Size(19, 14);
            this.lblLBStatus.TabIndex = 0;
            this.lblLBStatus.Text = "...";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.btnYeniKayit);
            this.panel2.Location = new System.Drawing.Point(27, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 337);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBoxAra);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(27, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 40);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.labelAdSoyad);
            this.panel6.Font = new System.Drawing.Font("Cambria", 20F);
            this.panel6.Location = new System.Drawing.Point(298, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(309, 58);
            this.panel6.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.labelIsTanim);
            this.panel7.Controls.Add(this.labelCinsiyet);
            this.panel7.Controls.Add(this.labelDogumTarihi);
            this.panel7.Controls.Add(this.labelTelefon);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(298, 96);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(309, 259);
            this.panel7.TabIndex = 28;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.btnExcelAktar);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Location = new System.Drawing.Point(298, 363);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(309, 55);
            this.panel8.TabIndex = 3;
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcelAktar.BackColor = System.Drawing.Color.DimGray;
            this.btnExcelAktar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelAktar.Font = new System.Drawing.Font("Buxton Sketch", 11F);
            this.btnExcelAktar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcelAktar.Location = new System.Drawing.Point(6, 4);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(94, 43);
            this.btnExcelAktar.TabIndex = 0;
            this.btnExcelAktar.Text = "Excell\'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = false;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // lblSifreDegistir
            // 
            this.lblSifreDegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSifreDegistir.AutoSize = true;
            this.lblSifreDegistir.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblSifreDegistir.DisabledLinkColor = System.Drawing.Color.Salmon;
            this.lblSifreDegistir.ForeColor = System.Drawing.Color.Tomato;
            this.lblSifreDegistir.LinkColor = System.Drawing.Color.Black;
            this.lblSifreDegistir.Location = new System.Drawing.Point(736, 14);
            this.lblSifreDegistir.Name = "lblSifreDegistir";
            this.lblSifreDegistir.Size = new System.Drawing.Size(79, 15);
            this.lblSifreDegistir.TabIndex = 29;
            this.lblSifreDegistir.TabStop = true;
            this.lblSifreDegistir.Text = "Şifre Değiştir";
            this.lblSifreDegistir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSifreDegistir_LinkClicked);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Buxton Sketch", 13F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(206, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Excell\'e Aktar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Buxton Sketch", 13F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(106, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Excell\'e Aktar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FrmRehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(846, 451);
            this.Controls.Add(this.lblSifreDegistir);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinimumSize = new System.Drawing.Size(862, 490);
            this.Name = "FrmRehber";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REHBER";
            this.Load += new System.EventHandler(this.FrmRehber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoster)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
       

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGoster;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelDogumTarihi;
        private System.Windows.Forms.Label labelCinsiyet;
        private System.Windows.Forms.Label labelIsTanim;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnKullaniciDegistir;
        private System.Windows.Forms.Panel panel4;

        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAdSoyad;
        protected System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLBStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnExcelAktar;
        private System.Windows.Forms.LinkLabel lblSifreDegistir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}