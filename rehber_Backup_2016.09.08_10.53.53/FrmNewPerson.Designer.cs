namespace rehber
{
    partial class FrmNewPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewPerson));
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.textIsim = new System.Windows.Forms.TextBox();
            this.textSoyisim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTxtNumara = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Location = new System.Drawing.Point(343, 323);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(79, 31);
            this.btnKapat.TabIndex = 11;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSec
            // 
            this.btnSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSec.Font = new System.Drawing.Font("Buxton Sketch", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Location = new System.Drawing.Point(326, 203);
            this.btnSec.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(96, 30);
            this.btnSec.TabIndex = 8;
            this.btnSec.Text = "Fotoğraf Seç...";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click_1);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.Font = new System.Drawing.Font("Buxton Sketch", 12F);
            this.btnTemizle.Location = new System.Drawing.Point(326, 252);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(96, 43);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("Buxton Sketch", 12F);
            this.btnKaydet.Location = new System.Drawing.Point(101, 338);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(113, 53);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // textIsim
            // 
            this.textIsim.Font = new System.Drawing.Font("Cambria", 10F);
            this.textIsim.Location = new System.Drawing.Point(101, 33);
            this.textIsim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textIsim.Name = "textIsim";
            this.textIsim.Size = new System.Drawing.Size(173, 23);
            this.textIsim.TabIndex = 1;
            this.textIsim.Tag = "Model.Isim";
            this.textIsim.Leave += new System.EventHandler(this.textIsim_Leave);
            // 
            // textSoyisim
            // 
            this.textSoyisim.Font = new System.Drawing.Font("Cambria", 10F);
            this.textSoyisim.Location = new System.Drawing.Point(101, 69);
            this.textSoyisim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textSoyisim.Name = "textSoyisim";
            this.textSoyisim.Size = new System.Drawing.Size(173, 23);
            this.textSoyisim.TabIndex = 2;
            this.textSoyisim.Leave += new System.EventHandler(this.textSoyisim_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "İSİM              :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "SOYİSİM       :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "NUMARA      :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Buxton Sketch", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "DOĞUM T.  :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox.Location = new System.Drawing.Point(290, 33);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(132, 163);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.CustomFormat = "   dd.MM.yyyy";
            this.dtDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDogumTarihi.Location = new System.Drawing.Point(101, 174);
            this.dtDogumTarihi.Margin = new System.Windows.Forms.Padding(5, 3, 2, 3);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtDogumTarihi.Size = new System.Drawing.Size(113, 22);
            this.dtDogumTarihi.TabIndex = 5;
            this.dtDogumTarihi.Value = new System.DateTime(2016, 4, 27, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "E",
            "K"});
            this.comboBox1.Location = new System.Drawing.Point(101, 212);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Buxton Sketch", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "CİNSİYET    :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Cambria", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(101, 250);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBox1.MaxLength = 169;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(173, 82);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Buxton Sketch", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "İŞ TANIMI   :";
            // 
            // maskedTxtNumara
            // 
            this.maskedTxtNumara.Location = new System.Drawing.Point(101, 103);
            this.maskedTxtNumara.Mask = "(9999)-000-0000";
            this.maskedTxtNumara.Name = "maskedTxtNumara";
            this.maskedTxtNumara.Size = new System.Drawing.Size(173, 22);
            this.maskedTxtNumara.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Buxton Sketch", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(26, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "E - MAİL      :";
            // 
            // textMail
            // 
            this.textMail.Font = new System.Drawing.Font("Cambria", 10F);
            this.textMail.Location = new System.Drawing.Point(101, 137);
            this.textMail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(173, 23);
            this.textMail.TabIndex = 4;
            this.textMail.TextChanged += new System.EventHandler(this.textMail_TextChanged);
            // 
            // FrmNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(442, 424);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.maskedTxtNumara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtDogumTarihi);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSoyisim);
            this.Controls.Add(this.textIsim);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.btnKapat);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Buxton Sketch", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmNewPerson";
            this.RightToLeftLayout = true;
            this.Text = "Yeni Kişi Ekle";
            this.Load += new System.EventHandler(this.FrmNewPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox textIsim;
        private System.Windows.Forms.TextBox textSoyisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox;
        private getDate date1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.MaskedTextBox maskedTxtNumara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textMail;
    }
}

