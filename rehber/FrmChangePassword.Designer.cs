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
            this.btnSifreChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifreChangeEski = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifreChangeYeni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSifreChange
            // 
            this.btnSifreChange.BackColor = System.Drawing.Color.Ivory;
            this.btnSifreChange.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnSifreChange.Location = new System.Drawing.Point(261, 222);
            this.btnSifreChange.Name = "btnSifreChange";
            this.btnSifreChange.Size = new System.Drawing.Size(110, 38);
            this.btnSifreChange.TabIndex = 3;
            this.btnSifreChange.Text = "Değiştir";
            this.btnSifreChange.UseVisualStyleBackColor = false;
            this.btnSifreChange.Click += new System.EventHandler(this.btnSifreChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Eski Şifre        :";
            // 
            // txtSifreChangeEski
            // 
            this.txtSifreChangeEski.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtSifreChangeEski.Location = new System.Drawing.Point(129, 60);
            this.txtSifreChangeEski.Name = "txtSifreChangeEski";
            this.txtSifreChangeEski.PasswordChar = '*';
            this.txtSifreChangeEski.Size = new System.Drawing.Size(200, 25);
            this.txtSifreChangeEski.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblKullanici);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSifreChangeYeni);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSifreChangeEski);
            this.panel1.Location = new System.Drawing.Point(22, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 156);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Şifre        :";
            // 
            // txtSifreChangeYeni
            // 
            this.txtSifreChangeYeni.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtSifreChangeYeni.Location = new System.Drawing.Point(129, 98);
            this.txtSifreChangeYeni.Name = "txtSifreChangeYeni";
            this.txtSifreChangeYeni.PasswordChar = '*';
            this.txtSifreChangeYeni.Size = new System.Drawing.Size(200, 25);
            this.txtSifreChangeYeni.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı     :";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(131, 34);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(35, 13);
            this.lblKullanici.TabIndex = 7;
            this.lblKullanici.Text = "label4";
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 289);
            this.Controls.Add(this.btnSifreChange);
            this.Controls.Add(this.panel1);
            this.Name = "FrmChangePassword";
            this.Text = "FrmChangePassword";
            this.Load += new System.EventHandler(this.FrmChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSifreChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifreChangeEski;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifreChangeYeni;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label label1;
    }
}