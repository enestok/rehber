namespace rehber
{
    partial class Frm_ePostaOlustur
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
            this.components = new System.ComponentModel.Container();
            this.txtAliciMail = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.txtRichMesaj = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtGonderenMail = new System.Windows.Forms.TextBox();
            this.btnAddAttach = new System.Windows.Forms.Button();
            this.btnAliciEkle = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGonderenSifre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lnkAliciTemizle = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lnkAttachTumunuTemizle = new System.Windows.Forms.LinkLabel();
            this.selectedFilePanel1 = new rehber.rehber.SelectedFilePanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAliciMail
            // 
            this.txtAliciMail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAliciMail.Location = new System.Drawing.Point(105, 38);
            this.txtAliciMail.Name = "txtAliciMail";
            this.txtAliciMail.Size = new System.Drawing.Size(201, 21);
            this.txtAliciMail.TabIndex = 3;
            this.txtAliciMail.Text = "enestok81@gmail.com;";
            this.toolTip1.SetToolTip(this.txtAliciMail, "Alıcının Mail Adresini Giriniz. (biri@biryer.com)\r\n*Birden fazla mail adresi vars" +
        "a \';\' ile ayırınız ya da Alıcı Ekle butonunu kullanınız. \r\n");
            this.txtAliciMail.TextChanged += new System.EventHandler(this.txtAliciMail_TextChanged);
            // 
            // txtKonu
            // 
            this.txtKonu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKonu.Location = new System.Drawing.Point(106, 29);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(200, 21);
            this.txtKonu.TabIndex = 5;
            this.txtKonu.Text = "deneme";
            this.toolTip1.SetToolTip(this.txtKonu, "e-Posta Başlığı Giriniz");
            // 
            // txtRichMesaj
            // 
            this.txtRichMesaj.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRichMesaj.Location = new System.Drawing.Point(19, 95);
            this.txtRichMesaj.Name = "txtRichMesaj";
            this.txtRichMesaj.Size = new System.Drawing.Size(447, 200);
            this.txtRichMesaj.TabIndex = 6;
            this.txtRichMesaj.Text = "deneme maili --";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mail      :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Konu     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesaj   :";
            // 
            // txtGonderenMail
            // 
            this.txtGonderenMail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGonderenMail.Location = new System.Drawing.Point(105, 24);
            this.txtGonderenMail.Name = "txtGonderenMail";
            this.txtGonderenMail.Size = new System.Drawing.Size(201, 21);
            this.txtGonderenMail.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtGonderenMail, "Alıcının Mail Adresini Giriniz. (example@xmail.com)");
            // 
            // btnAddAttach
            // 
            this.btnAddAttach.Image = global::rehber.Properties.Resources.attachement;
            this.btnAddAttach.Location = new System.Drawing.Point(640, 11);
            this.btnAddAttach.Name = "btnAddAttach";
            this.btnAddAttach.Size = new System.Drawing.Size(73, 80);
            this.btnAddAttach.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnAddAttach, "Dosya Ekle..");
            this.btnAddAttach.UseVisualStyleBackColor = true;
            this.btnAddAttach.Click += new System.EventHandler(this.btnAddAttach_Click);
            // 
            // btnAliciEkle
            // 
            this.btnAliciEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnAliciEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAliciEkle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAliciEkle.ForeColor = System.Drawing.Color.Transparent;
            this.btnAliciEkle.Image = global::rehber.Properties.Resources.iconAddd;
            this.btnAliciEkle.Location = new System.Drawing.Point(324, 26);
            this.btnAliciEkle.Name = "btnAliciEkle";
            this.btnAliciEkle.Size = new System.Drawing.Size(42, 42);
            this.btnAliciEkle.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAliciEkle, "Alıcı Ekle");
            this.btnAliciEkle.UseVisualStyleBackColor = false;
            this.btnAliciEkle.Click += new System.EventHandler(this.btnAliciEkle_Click);
            this.btnAliciEkle.MouseLeave += new System.EventHandler(this.btnAliciEkle_MouseLeave);
            this.btnAliciEkle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAliciEkle_MouseMove);
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.Transparent;
            this.btnGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGonder.FlatAppearance.BorderSize = 0;
            this.btnGonder.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Image = global::rehber.Properties.Resources.sendOff;
            this.btnGonder.Location = new System.Drawing.Point(722, 11);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(80, 80);
            this.btnGonder.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnGonder, "Gönder");
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            this.btnGonder.MouseLeave += new System.EventHandler(this.btnGonder_MouseLeave);
            this.btnGonder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGonder_MouseMove);
            // 
            // button1
            // 
            this.button1.Image = global::rehber.Properties.Resources.attachement;
            this.button1.Location = new System.Drawing.Point(383, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 49);
            this.button1.TabIndex = 17;
            this.toolTip1.SetToolTip(this.button1, "Dosya Ekle..");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Şifre      :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mail       :";
            // 
            // txtGonderenSifre
            // 
            this.txtGonderenSifre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGonderenSifre.Location = new System.Drawing.Point(105, 54);
            this.txtGonderenSifre.Name = "txtGonderenSifre";
            this.txtGonderenSifre.PasswordChar = '*';
            this.txtGonderenSifre.Size = new System.Drawing.Size(201, 21);
            this.txtGonderenSifre.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGonderenSifre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGonderenMail);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 91);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gönderici";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lnkAliciTemizle);
            this.groupBox2.Controls.Add(this.btnAliciEkle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAliciMail);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(439, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 91);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alıcı";
            // 
            // lnkAliciTemizle
            // 
            this.lnkAliciTemizle.AutoSize = true;
            this.lnkAliciTemizle.Location = new System.Drawing.Point(256, 62);
            this.lnkAliciTemizle.Name = "lnkAliciTemizle";
            this.lnkAliciTemizle.Size = new System.Drawing.Size(50, 15);
            this.lnkAliciTemizle.TabIndex = 18;
            this.lnkAliciTemizle.TabStop = true;
            this.lnkAliciTemizle.Text = "Temizle";
            this.lnkAliciTemizle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAliciTemizle_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lnkAttachTumunuTemizle);
            this.groupBox3.Controls.Add(this.btnAddAttach);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.selectedFilePanel1);
            this.groupBox3.Controls.Add(this.btnGonder);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtRichMesaj);
            this.groupBox3.Controls.Add(this.txtKonu);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(21, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(819, 332);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "E-Posta ";
            // 
            // lnkAttachTumunuTemizle
            // 
            this.lnkAttachTumunuTemizle.AutoSize = true;
            this.lnkAttachTumunuTemizle.Location = new System.Drawing.Point(702, 302);
            this.lnkAttachTumunuTemizle.Name = "lnkAttachTumunuTemizle";
            this.lnkAttachTumunuTemizle.Size = new System.Drawing.Size(99, 15);
            this.lnkAttachTumunuTemizle.TabIndex = 17;
            this.lnkAttachTumunuTemizle.TabStop = true;
            this.lnkAttachTumunuTemizle.Text = "Tümünü Temizle";
            this.lnkAttachTumunuTemizle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTumunuTemizle_LinkClicked);
            // 
            // selectedFilePanel1
            // 
            this.selectedFilePanel1.AutoScroll = true;
            this.selectedFilePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedFilePanel1.Location = new System.Drawing.Point(477, 95);
            this.selectedFilePanel1.Name = "selectedFilePanel1";
            this.selectedFilePanel1.Size = new System.Drawing.Size(325, 200);
            this.selectedFilePanel1.TabIndex = 16;
            // 
            // Frm_ePostaOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(880, 505);
            this.MinimumSize = new System.Drawing.Size(880, 505);
            this.Name = "Frm_ePostaOlustur";
            this.Text = "E-Posta Yaz";
            this.Load += new System.EventHandler(this.Frm_ePostaOlustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.RichTextBox txtRichMesaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnAliciEkle;
        private System.Windows.Forms.Button btnAddAttach;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGonderenSifre;
        private System.Windows.Forms.TextBox txtGonderenMail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private rehber.SelectedFilePanel selectedFilePanel1;
        public System.Windows.Forms.TextBox txtAliciMail;
        private System.Windows.Forms.LinkLabel lnkAttachTumunuTemizle;
        private System.Windows.Forms.LinkLabel lnkAliciTemizle;
    }
}

