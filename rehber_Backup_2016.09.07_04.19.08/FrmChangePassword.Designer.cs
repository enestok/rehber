namespace rehber
{
    partial class FrmChangePassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSifreChangeEski = new Telerik.WinControls.UI.RadTextBox();
            this.txtSifreChangeYeni = new Telerik.WinControls.UI.RadTextBox();
            this.txtSifreChangeYeniTekrar = new Telerik.WinControls.UI.RadTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSifreChange = new Telerik.WinControls.UI.RadButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreChangeEski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreChangeYeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreChangeYeniTekrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreChange)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Eski Şifre             :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSifreChangeEski);
            this.panel1.Controls.Add(this.txtSifreChangeYeni);
            this.panel1.Controls.Add(this.txtSifreChangeYeniTekrar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblKullanici);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 211);
            this.panel1.TabIndex = 2;
            // 
            // txtSifreChangeEski
            // 
            this.txtSifreChangeEski.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSifreChangeEski.Location = new System.Drawing.Point(139, 63);
            this.txtSifreChangeEski.Name = "txtSifreChangeEski";
            this.txtSifreChangeEski.Size = new System.Drawing.Size(199, 23);
            this.txtSifreChangeEski.TabIndex = 10;
            this.txtSifreChangeEski.TextChanged += new System.EventHandler(this.txtSifreChangeEski_TextChanged);
            // 
            // txtSifreChangeYeni
            // 
            this.txtSifreChangeYeni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSifreChangeYeni.Location = new System.Drawing.Point(139, 101);
            this.txtSifreChangeYeni.Name = "txtSifreChangeYeni";
            this.txtSifreChangeYeni.Size = new System.Drawing.Size(199, 23);
            this.txtSifreChangeYeni.TabIndex = 10;
            this.txtSifreChangeYeni.TextChanged += new System.EventHandler(this.txtSifreChangeYeni_TextChanged);
            // 
            // txtSifreChangeYeniTekrar
            // 
            this.txtSifreChangeYeniTekrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSifreChangeYeniTekrar.Location = new System.Drawing.Point(139, 140);
            this.txtSifreChangeYeniTekrar.Name = "txtSifreChangeYeniTekrar";
            this.txtSifreChangeYeniTekrar.Size = new System.Drawing.Size(199, 23);
            this.txtSifreChangeYeniTekrar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yeni Şifre Tekrar   :";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblKullanici.Location = new System.Drawing.Point(141, 32);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(41, 15);
            this.lblKullanici.TabIndex = 7;
            this.lblKullanici.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Şifre             :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı          :";
            // 
            // btnSifreChange
            // 
            this.btnSifreChange.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnSifreChange.Location = new System.Drawing.Point(300, 263);
            this.btnSifreChange.Name = "btnSifreChange";
            this.btnSifreChange.Size = new System.Drawing.Size(129, 41);
            this.btnSifreChange.TabIndex = 4;
            this.btnSifreChange.Text = "Değiştir";
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 339);
            this.Controls.Add(this.btnSifreChange);
            this.Controls.Add(this.panel1);
            this.Name = "FrmChangePassword";
            this.Text = "FrmChangePassword";
            this.Load += new System.EventHandler(this.FrmChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreChangeEski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreChangeYeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreChangeYeniTekrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSifreChange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadTextBox txtSifreChangeEski;
        private Telerik.WinControls.UI.RadTextBox txtSifreChangeYeni;
        private Telerik.WinControls.UI.RadTextBox txtSifreChangeYeniTekrar;
        private Telerik.WinControls.UI.RadButton btnSifreChange;
    }
}