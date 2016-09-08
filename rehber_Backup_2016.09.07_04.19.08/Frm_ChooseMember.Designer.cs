namespace rehber
{
    partial class Frm_ChooseMember
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKayitAra = new System.Windows.Forms.TextBox();
            this.btnKayitSec = new System.Windows.Forms.Button();
            this.chkLstKayitlar = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtKayitAra);
            this.groupBox1.Controls.Add(this.btnKayitSec);
            this.groupBox1.Controls.Add(this.chkLstKayitlar);
            this.groupBox1.Location = new System.Drawing.Point(36, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 432);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Seçiniz";
            // 
            // btnIptal
            // 
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Font = new System.Drawing.Font("Buxton Sketch", 14F);
            this.btnIptal.Location = new System.Drawing.Point(94, 374);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(90, 33);
            this.btnIptal.TabIndex = 20;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Buxton Sketch", 11F);
            this.label14.Location = new System.Drawing.Point(41, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 19);
            this.label14.TabIndex = 19;
            this.label14.Text = "ARA    :";
            // 
            // txtKayitAra
            // 
            this.txtKayitAra.Location = new System.Drawing.Point(100, 40);
            this.txtKayitAra.Name = "txtKayitAra";
            this.txtKayitAra.Size = new System.Drawing.Size(180, 20);
            this.txtKayitAra.TabIndex = 1;
            // 
            // btnKayitSec
            // 
            this.btnKayitSec.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnKayitSec.Font = new System.Drawing.Font("Buxton Sketch", 14F);
            this.btnKayitSec.Location = new System.Drawing.Point(190, 366);
            this.btnKayitSec.Name = "btnKayitSec";
            this.btnKayitSec.Size = new System.Drawing.Size(90, 49);
            this.btnKayitSec.TabIndex = 8;
            this.btnKayitSec.Text = "Seç";
            this.btnKayitSec.UseVisualStyleBackColor = true;
            // 
            // chkLstKayitlar
            // 
            this.chkLstKayitlar.FormattingEnabled = true;
            this.chkLstKayitlar.HorizontalScrollbar = true;
            this.chkLstKayitlar.Location = new System.Drawing.Point(45, 92);
            this.chkLstKayitlar.Name = "chkLstKayitlar";
            this.chkLstKayitlar.Size = new System.Drawing.Size(235, 259);
            this.chkLstKayitlar.TabIndex = 6;
            // 
            // Frm_ChooseMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 497);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ChooseMember";
            this.Text = "Frm_ChooseMember";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtKayitAra;
        private System.Windows.Forms.Button btnKayitSec;
        private System.Windows.Forms.CheckedListBox chkLstKayitlar;
    }
}