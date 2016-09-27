using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rehber
{
    public partial class FrmChangePassword : BaseRadForm
    {
        public FrmChangePassword()
        {
            InitializeComponent();
            
        }
        
        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            var userInfo = KullaniciBilgi.KullaniciBilgileri;
            lblKullanici.Text = userInfo.kullaniciAdi;
        }

        private void btnSifreChange_Click(object sender, EventArgs e)
        {
            if (txtSifreChangeYeni.Text != txtSifreChangeYeniTekrar.Text)
            {
                MessageBox.Show("Girilen şifreler farklı. Yeni şifrenizi doğrulayınız.","Şifreler Farklı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else 
            {
                var userInfo = KullaniciBilgi.KullaniciBilgileri;

                if (userInfo.sifre == txtSifreChangeEski.Text)
                {
                    SqlConnection connect = new SqlHelper().Connection();
                    connect.Open();
    
                    SqlCommand command = new SqlCommand("UPDATE dbo.login SET sifre = @sifre WHERE kullaniciId=" + userInfo.kullaniciID, connect);
                    command.Parameters.AddWithValue("@sifre", txtSifreChangeYeni.Text);
                    userInfo.sifre = txtSifreChangeYeni.Text;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Şifreniz değiştirildi");
                    this.Close();
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Eski şifrenizi doğru girdiğinizden emin olun..");
                }
            }

        }

        private void btnSifreGosterEski_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (btnSifreGosterEski.IsChecked)
            {
                txtSifreChangeEski.PasswordChar = '\0';
            }
            else
            {
                txtSifreChangeEski.PasswordChar = '*';
            }
        }

        private void btnSifreGosterYeni_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (btnSifreGosterYeni.IsChecked)
            {
                txtSifreChangeYeni.PasswordChar = '\0';
            }
            else
            {
                txtSifreChangeYeni.PasswordChar = '*';
            }
        }

        private void btnSifreGosterYeniTekrar_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (btnSifreGosterYeniTekrar.IsChecked)
            {
                txtSifreChangeYeniTekrar.PasswordChar = '\0';
            }
            else
            {
                txtSifreChangeYeniTekrar.PasswordChar = '*';
            }
        }
    }
}
