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
            var _frmNewPerson = new FrmNewPerson();
            var userInfo = KullaniciBilgi.KullaniciBilgileri;

            if (_frmNewPerson.IsMailAddress(txtNewEMail.Text))
            {
                SqlConnection connect = new SqlHelper().Connection();
                connect.Open();

                SqlCommand command =
                    new SqlCommand(
                        "UPDATE dbo.login SET kullaniciEMail = @KullaniciEMail WHERE kullaniciId=" +
                        userInfo.kullaniciID, connect);
                command.Parameters.AddWithValue("@KullaniciEMail", txtNewEMail.Text);
                userInfo.sifre = txtNewEMail.Text;
                command.ExecuteNonQuery();

                RadMessageBox.SetThemeName("TelerikMetro");
                RadMessageBox.Show("E Mail adresiniz değiştirildi");

                this.Close();
                connect.Close();
            }
            else
            {
                RadMessageBox.SetThemeName("TelerikMetro");
                RadMessageBox.Show("Mail adresini doğru formatta giriniz. (biri@biryer.com)");
            }


                
        }
    }
}
