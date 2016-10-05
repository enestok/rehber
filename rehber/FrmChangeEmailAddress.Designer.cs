namespace rehber
{
    partial class FrmChangeEmailAddress
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnEMailChange = new Telerik.WinControls.UI.RadButton();
            this.txtNewEMail = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEMailChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewEMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(31, 62);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(121, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Yeni E-Mail Adresi ";
            // 
            // btnEMailChange
            // 
            this.btnEMailChange.Font = new System.Drawing.Font("Buxton Sketch", 12F);
            this.btnEMailChange.Location = new System.Drawing.Point(320, 102);
            this.btnEMailChange.Name = "btnEMailChange";
            this.btnEMailChange.Size = new System.Drawing.Size(110, 39);
            this.btnEMailChange.TabIndex = 1;
            this.btnEMailChange.Text = "Değiştir";
            this.btnEMailChange.ThemeName = "TelerikMetro";
            this.btnEMailChange.Click += new System.EventHandler(this.btnEMailChange_Click);
            // 
            // txtNewEMail
            // 
            this.txtNewEMail.Location = new System.Drawing.Point(169, 62);
            this.txtNewEMail.Name = "txtNewEMail";
            this.txtNewEMail.Size = new System.Drawing.Size(261, 22);
            this.txtNewEMail.TabIndex = 2;
            this.txtNewEMail.ThemeName = "TelerikMetro";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(153, 62);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(10, 21);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = ":";
            // 
            // FrmChangeEmailAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 217);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txtNewEMail);
            this.Controls.Add(this.btnEMailChange);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(482, 252);
            this.MinimumSize = new System.Drawing.Size(482, 252);
            this.Name = "FrmChangeEmailAddress";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(482, 252);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E-Mail Değiştir";
            this.Load += new System.EventHandler(this.FrmChangeEmailAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEMailChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewEMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnEMailChange;
        private Telerik.WinControls.UI.RadTextBox txtNewEMail;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}