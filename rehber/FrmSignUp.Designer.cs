namespace rehber
{
    partial class FrmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUp));
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtKullaniciKayit = new System.Windows.Forms.TextBox();
            this.txtSifreKayit = new System.Windows.Forms.TextBox();
            this.txtSifreTekrarKayit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSignUpCikis = new System.Windows.Forms.Button();
            this.lblKullaniciDurum = new System.Windows.Forms.Label();
            this.btnSignUpGiris = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMailKayit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.Ivory;
            this.btnKayitOl.FlatAppearance.BorderSize = 3;
            this.btnKayitOl.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.btnKayitOl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnKayitOl.Font = new System.Drawing.Font("Buxton Sketch", 14F);
            this.btnKayitOl.ForeColor = System.Drawing.Color.Black;
            this.btnKayitOl.Location = new System.Drawing.Point(435, 250);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(161, 72);
            this.btnKayitOl.TabIndex = 0;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // txtKullaniciKayit
            // 
            this.txtKullaniciKayit.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciKayit.Location = new System.Drawing.Point(162, 66);
            this.txtKullaniciKayit.Name = "txtKullaniciKayit";
            this.txtKullaniciKayit.Size = new System.Drawing.Size(211, 27);
            this.txtKullaniciKayit.TabIndex = 1;
            this.txtKullaniciKayit.Leave += new System.EventHandler(this.txtKullaniciKayit_Leave);
            // 
            // txtSifreKayit
            // 
            this.txtSifreKayit.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreKayit.Location = new System.Drawing.Point(162, 105);
            this.txtSifreKayit.Name = "txtSifreKayit";
            this.txtSifreKayit.PasswordChar = '*';
            this.txtSifreKayit.Size = new System.Drawing.Size(211, 27);
            this.txtSifreKayit.TabIndex = 2;
            // 
            // txtSifreTekrarKayit
            // 
            this.txtSifreTekrarKayit.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreTekrarKayit.Location = new System.Drawing.Point(162, 141);
            this.txtSifreTekrarKayit.Name = "txtSifreTekrarKayit";
            this.txtSifreTekrarKayit.PasswordChar = '*';
            this.txtSifreTekrarKayit.Size = new System.Drawing.Size(211, 27);
            this.txtSifreTekrarKayit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(40, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(40, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre             :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(40, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre Tekrar   :";
            // 
            // btnSignUpCikis
            // 
            this.btnSignUpCikis.BackColor = System.Drawing.Color.Ivory;
            this.btnSignUpCikis.FlatAppearance.BorderSize = 3;
            this.btnSignUpCikis.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.btnSignUpCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnSignUpCikis.Font = new System.Drawing.Font("Buxton Sketch", 14F);
            this.btnSignUpCikis.Location = new System.Drawing.Point(179, 250);
            this.btnSignUpCikis.Name = "btnSignUpCikis";
            this.btnSignUpCikis.Size = new System.Drawing.Size(112, 60);
            this.btnSignUpCikis.TabIndex = 7;
            this.btnSignUpCikis.Text = "ÇIKIŞ";
            this.btnSignUpCikis.UseVisualStyleBackColor = false;
            this.btnSignUpCikis.Click += new System.EventHandler(this.btnSignUpCikis_Click);
            // 
            // lblKullaniciDurum
            // 
            this.lblKullaniciDurum.AutoSize = true;
            this.lblKullaniciDurum.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciDurum.Location = new System.Drawing.Point(159, 180);
            this.lblKullaniciDurum.Name = "lblKullaniciDurum";
            this.lblKullaniciDurum.Size = new System.Drawing.Size(28, 13);
            this.lblKullaniciDurum.TabIndex = 8;
            this.lblKullaniciDurum.Text = "***";
            // 
            // btnSignUpGiris
            // 
            this.btnSignUpGiris.BackColor = System.Drawing.Color.Ivory;
            this.btnSignUpGiris.FlatAppearance.BorderSize = 3;
            this.btnSignUpGiris.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightBlue;
            this.btnSignUpGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnSignUpGiris.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnSignUpGiris.Location = new System.Drawing.Point(29, 250);
            this.btnSignUpGiris.Name = "btnSignUpGiris";
            this.btnSignUpGiris.Size = new System.Drawing.Size(130, 60);
            this.btnSignUpGiris.TabIndex = 10;
            this.btnSignUpGiris.Text = "Giriş Yap >>";
            this.btnSignUpGiris.UseVisualStyleBackColor = false;
            this.btnSignUpGiris.Click += new System.EventHandler(this.btnSignUpGiris_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMailKayit);
            this.panel1.Controls.Add(this.lblKullaniciDurum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSifreTekrarKayit);
            this.panel1.Controls.Add(this.txtSifreKayit);
            this.panel1.Controls.Add(this.txtKullaniciKayit);
            this.panel1.Location = new System.Drawing.Point(31, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 214);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(40, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mail Adresi     :";
            // 
            // txtMailKayit
            // 
            this.txtMailKayit.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMailKayit.Location = new System.Drawing.Point(162, 26);
            this.txtMailKayit.Name = "txtMailKayit";
            this.txtMailKayit.Size = new System.Drawing.Size(211, 27);
            this.txtMailKayit.TabIndex = 9;
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(625, 355);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSignUpGiris);
            this.Controls.Add(this.btnSignUpCikis);
            this.Controls.Add(this.btnKayitOl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol ";
            this.Load += new System.EventHandler(this.FrmSignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox txtKullaniciKayit;
        private System.Windows.Forms.TextBox txtSifreKayit;
        private System.Windows.Forms.TextBox txtSifreTekrarKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSignUpCikis;
        private System.Windows.Forms.Label lblKullaniciDurum;
        private System.Windows.Forms.Button btnSignUpGiris;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMailKayit;
    }
}