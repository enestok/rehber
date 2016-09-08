namespace rehber
{
    partial class ImportExcelCheckList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcelTamam = new System.Windows.Forms.Button();
            this.btnExcelIptal = new System.Windows.Forms.Button();
            this.btnListedenSec = new System.Windows.Forms.Button();
            this.chkTumunuSec = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel1.Location = new System.Drawing.Point(31, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 225);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.MaximumSize = new System.Drawing.Size(200, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "** Görüntülemek istediğiniz alanları işaretleyiniz.";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "İsim",
            "Soyisim",
            "Telefon",
            "Doğum Tarihi",
            "Cinsiyet",
            "İş Tanımı"});
            this.checkedListBox1.Location = new System.Drawing.Point(27, 89);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(143, 126);
            this.checkedListBox1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Seçiniz :";
            // 
            // btnExcelTamam
            // 
            this.btnExcelTamam.Location = new System.Drawing.Point(87, 303);
            this.btnExcelTamam.Name = "btnExcelTamam";
            this.btnExcelTamam.Size = new System.Drawing.Size(80, 27);
            this.btnExcelTamam.TabIndex = 22;
            this.btnExcelTamam.Text = "Tamam";
            this.btnExcelTamam.UseVisualStyleBackColor = true;
            this.btnExcelTamam.Click += new System.EventHandler(this.btnExcelTamam_Click);
            // 
            // btnExcelIptal
            // 
            this.btnExcelIptal.Location = new System.Drawing.Point(173, 303);
            this.btnExcelIptal.Name = "btnExcelIptal";
            this.btnExcelIptal.Size = new System.Drawing.Size(80, 27);
            this.btnExcelIptal.TabIndex = 23;
            this.btnExcelIptal.Text = "İptal";
            this.btnExcelIptal.UseVisualStyleBackColor = true;
            this.btnExcelIptal.Click += new System.EventHandler(this.btnExcelIptal_Click);
            // 
            // btnListedenSec
            // 
            this.btnListedenSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnListedenSec.Location = new System.Drawing.Point(157, 27);
            this.btnListedenSec.Name = "btnListedenSec";
            this.btnListedenSec.Size = new System.Drawing.Size(96, 28);
            this.btnListedenSec.TabIndex = 24;
            this.btnListedenSec.Text = "Listeden Seç..";
            this.btnListedenSec.UseVisualStyleBackColor = true;
            this.btnListedenSec.Click += new System.EventHandler(this.btnListedenSec_Click);
            // 
            // chkTumunuSec
            // 
            this.chkTumunuSec.AutoSize = true;
            this.chkTumunuSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkTumunuSec.Location = new System.Drawing.Point(31, 31);
            this.chkTumunuSec.Name = "chkTumunuSec";
            this.chkTumunuSec.Size = new System.Drawing.Size(115, 19);
            this.chkTumunuSec.TabIndex = 25;
            this.chkTumunuSec.Text = "Tüm Listeyi Ekle";
            this.chkTumunuSec.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTumunuSec);
            this.groupBox1.Controls.Add(this.btnListedenSec);
            this.groupBox1.Controls.Add(this.btnExcelIptal);
            this.groupBox1.Controls.Add(this.btnExcelTamam);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 350);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel\'e Gönder";
            // 
            // ImportExcelCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 375);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "ImportExcelCheckList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seçiniz";
            this.Load += new System.EventHandler(this.ImportExcelCheckList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcelTamam;
        private System.Windows.Forms.Button btnExcelIptal;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnListedenSec;
        private System.Windows.Forms.CheckBox chkTumunuSec;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}