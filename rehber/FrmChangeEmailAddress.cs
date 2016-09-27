using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace rehber
{
    public partial class FrmChangeEmailAddress : BaseRadForm
    {
        public FrmChangeEmailAddress()
        {
            InitializeComponent();
        }

        private void FrmChangeEmailAddress_Load(object sender, EventArgs e)
        {

        }

        private void btnEMailChange_Click(object sender, EventArgs e)
        {
            var userInfo = KullaniciBilgi.KullaniciBilgileri;

            //signUpDataContextDataContext signUpDataContext = new signUpDataContextDataContext();

            //var kayit = new KullaniciKayit();
            

            //kayit.kullaniciEmail = txtNewEMail.Text;

            

            //signUpDataContext.KullaniciKayits.InsertOnSubmit(kayit);
            //signUpDataContext.SubmitChanges();

            SqlConnection connect = new SqlHelper().Connection();
            connect.Open();

            SqlCommand command = new SqlCommand("UPDATE dbo.login SET kullaniciEMail = @KullaniciEMail WHERE kullaniciId=" + userInfo.kullaniciID, connect);
            command.Parameters.AddWithValue("@KullaniciEMail", txtNewEMail.Text);
            userInfo.sifre = txtNewEMail.Text;
            command.ExecuteNonQuery();
            MessageBox.Show("E Mail adresiniz değiştirildi");
            this.Close();
            connect.Close();

            //RadMessageBox.SetThemeName("TelerikMetro");
            //RadMessageBox.Show("Mail adresiniz değiştirildi!", "E Mail Adresini Değiştir", MessageBoxButtons.OK, RadMessageIcon.Info);
                
        }
    }
}
