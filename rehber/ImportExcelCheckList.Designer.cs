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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkExcelAlan = new System.Windows.Forms.CheckedListBox();
            this.btnListedenSec = new Telerik.WinControls.UI.RadButton();
            this.btnExcelTamam = new Telerik.WinControls.UI.RadButton();
            this.btnExcelIptal = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnListedenSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcelTamam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcelIptal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnExcelIptal);
            this.radGroupBox1.Controls.Add(this.btnExcelTamam);
            this.radGroupBox1.Controls.Add(this.radPanel1);
            this.radGroupBox1.Controls.Add(this.btnListedenSec);
            this.radGroupBox1.HeaderText = "Seçiniz";
            this.radGroupBox1.Location = new System.Drawing.Point(16, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(284, 411);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Seçiniz";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.label2);
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Controls.Add(this.chkExcelAlan);
            this.radPanel1.Location = new System.Drawing.Point(30, 87);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(221, 246);
            this.radPanel1.TabIndex = 30;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F);
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.MaximumSize = new System.Drawing.Size(200, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 38);
            this.label2.TabIndex = 25;
            this.label2.Text = "** Görüntülemek istediğiniz alanları işaretleyiniz.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Seçiniz :";
            // 
            // chkExcelAlan
            // 
            this.chkExcelAlan.BackColor = System.Drawing.Color.Honeydew;
            this.chkExcelAlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkExcelAlan.CheckOnClick = true;
            this.chkExcelAlan.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkExcelAlan.FormattingEnabled = true;
            this.chkExcelAlan.Items.AddRange(new object[] {
            "İsim",
            "Soyisim",
            "Telefon",
            "Doğum Tarihi",
            "Cinsiyet",
            "İş Tanımı"});
            this.chkExcelAlan.Location = new System.Drawing.Point(41, 97);
            this.chkExcelAlan.Name = "chkExcelAlan";
            this.chkExcelAlan.Size = new System.Drawing.Size(143, 126);
            this.chkExcelAlan.TabIndex = 2;
            // 
            // btnListedenSec
            // 
            this.btnListedenSec.Font = new System.Drawing.Font("Buxton Sketch", 11F);
            this.btnListedenSec.Location = new System.Drawing.Point(30, 44);
            this.btnListedenSec.Name = "btnListedenSec";
            this.btnListedenSec.Size = new System.Drawing.Size(151, 37);
            this.btnListedenSec.TabIndex = 1;
            this.btnListedenSec.Text = "Listeden Kişi Seçiniz >>>";
            this.btnListedenSec.ThemeName = "Office2010Silver";
            this.btnListedenSec.Click += new System.EventHandler(this.btnListedenSec_Click);
            // 
            // btnExcelTamam
            // 
            this.btnExcelTamam.Location = new System.Drawing.Point(167, 344);
            this.btnExcelTamam.Name = "btnExcelTamam";
            this.btnExcelTamam.Size = new System.Drawing.Size(84, 39);
            this.btnExcelTamam.TabIndex = 4;
            this.btnExcelTamam.Text = "TAMAM";
            this.btnExcelTamam.ThemeName = "TelerikMetro";
            this.btnExcelTamam.Click += new System.EventHandler(this.btnExcelTamam_Click);
            // 
            // btnExcelIptal
            // 
            this.btnExcelIptal.Location = new System.Drawing.Point(71, 356);
            this.btnExcelIptal.Name = "btnExcelIptal";
            this.btnExcelIptal.Size = new System.Drawing.Size(90, 27);
            this.btnExcelIptal.TabIndex = 3;
            this.btnExcelIptal.Text = "İptal";
            this.btnExcelIptal.ThemeName = "TelerikMetro";
            this.btnExcelIptal.Click += new System.EventHandler(this.btnExcelIptal_Click);
            // 
            // ImportExcelCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 436);
            this.ControlBox = false;
            this.Controls.Add(this.radGroupBox1);
            this.Name = "ImportExcelCheckList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Excel\'e Gönder";
            this.Load += new System.EventHandler(this.ImportExcelCheckList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnListedenSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcelTamam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcelIptal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkExcelAlan;
        private Telerik.WinControls.UI.RadButton btnListedenSec;
        private Telerik.WinControls.UI.RadButton btnExcelIptal;
        private Telerik.WinControls.UI.RadButton btnExcelTamam;

    }
}