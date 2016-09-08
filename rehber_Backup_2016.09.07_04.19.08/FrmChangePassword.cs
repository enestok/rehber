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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
            
        }
        


        private void btnSifreChange_Click(object sender, EventArgs e)
        {
            var userInfo = KullaniciBilgi.KullaniciBilgileri;

            lblKullanici.Text = userInfo.kullaniciAdi;

            if (userInfo.sifre==txtSifreChangeEski.Text)
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

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            var userInfo = KullaniciBilgi.KullaniciBilgileri;
            lblKullanici.Text = userInfo.kullaniciAdi;
        }

        private void txtSifreChangeEski_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifreChangeYeni_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
