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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 188);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.label2.Location = new System.Drawing.Point(14, 8);
            this.label2.MaximumSize = new System.Drawing.Size(230, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "** Görüntülemek istediğiniz alanları işaretleyiniz.";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "İsim",
            "Soyisim",
            "Telefon",
            "Doğum Tarihi",
            "Cinsiyet",
            "İş Tanımı"});
            this.checkedListBox1.Location = new System.Drawing.Point(21, 78);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(143, 105);
            this.checkedListBox1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.label1.Location = new System.Drawing.Point(18, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Seçiniz :";
            // 
            // btnExcelTamam
            // 
            this.btnExcelTamam.Location = new System.Drawing.Point(71, 246);
            this.btnExcelTamam.Name = "btnExcelTamam";
            this.btnExcelTamam.Size = new System.Drawing.Size(80, 27);
            this.btnExcelTamam.TabIndex = 22;
            this.btnExcelTamam.Text = "Tamam";
            this.btnExcelTamam.UseVisualStyleBackColor = true;
            this.btnExcelTamam.Click += new System.EventHandler(this.btnExcelTamam_Click);
            // 
            // btnExcelIptal
            // 
            this.btnExcelIptal.Location = new System.Drawing.Point(157, 246);
            this.btnExcelIptal.Name = "btnExcelIptal";
            this.btnExcelIptal.Size = new System.Drawing.Size(80, 27);
            this.btnExcelIptal.TabIndex = 23;
            this.btnExcelIptal.Text = "İptal";
            this.btnExcelIptal.UseVisualStyleBackColor = true;
            this.btnExcelIptal.Click += new System.EventHandler(this.btnExcelIptal_Click);
            // 
            // ImportExcelCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 315);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcelIptal);
            this.Controls.Add(this.btnExcelTamam);
            this.Controls.Add(this.panel1);
            this.Name = "ImportExcelCheckList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seçiniz";
            this.Load += new System.EventHandler(this.ImportExcelCheckList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcelTamam;
        private System.Windows.Forms.Button btnExcelIptal;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}