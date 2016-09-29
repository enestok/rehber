using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.ApplicationServices;
using Telerik.WinControls;
using System.Net.Mail;

namespace rehber
{
    public partial class FrmForgetPassword : BaseRadForm
    {
        public FrmForgetPassword()
        {
            InitializeComponent();
        }

        private void btnSifreGonder_Click(object sender, EventArgs e)
        {

                if (KullaniciKontrol() == txtEmailKontrol.Text)
                {
                    MailMessage ePosta = new MailMessage();
                    ePosta.From = new MailAddress("enestok81@gmail.com");
                    //
                    ePosta.To.Add(KullaniciKontrol().ToString());
                    ePosta.To.Add("enestok81@gmail.com");
                    //
                    ePosta.Subject = "Rehber Şifreniz..";
                    //
                    ePosta.Body = "asd";
                    //
                    SmtpClient smtp = new SmtpClient();
                    //
                    smtp.Credentials = new System.Net.NetworkCredential("enestok81@gmail.com", "81548154");
                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    object userState = ePosta;
                    bool kontrol = true;
                    try
                    {
                        smtp.SendAsync(ePosta, (object)ePosta);

                        RadMessageBox.SetThemeName("TelerikMetro");
                        RadMessageBox.Show("Şifreniz mail adresinize gönderildi.", "Şifre Kurtar");
                        Close();
                        

                    }
                    catch (SmtpException ex)
                    {
                       // kontrol = false;
                        System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
                    }
                    //return;

                    }
                else
                {
                    RadMessageBox.SetThemeName("TelerikMetro");
                    RadMessageBox.Show("Mail bilgileriniz uyuşmuyor.", "Şifre Kurtar");

                }
                
        }

        public string KullaniciKontrol()
        {
            tokDBEntities1 tokDB = new tokDBEntities1();

            var kontrol = from k in tokDB.logins
                          where k.kullaniciAdi.Contains(txtKullaniciAdiForget.Text)
                          select k.kullaniciEMail;

            string mKontrol = "";
            foreach (var a in kontrol)
            {
                string[] alanAdi = a.Split('@');
                var inChars = alanAdi[0].Substring(0, (alanAdi[0].Length - 3));

                string S = "";
                for (int i = 0; i < 3; i++)
                {
                    S += '*';
                }
                var toLabelText = string.Concat(inChars, S, '@', alanAdi[1]);
                lblEmailKontrol.Text = toLabelText;
                lblDesc.Text = "Yukarıdaki bilgilere sahip mail adresinizi aşağıya yazarak şifrenizi öğrenebilirsiniz. ";

                mKontrol = a;
            }

            return mKontrol;
        }

        private void btnSifreDevam_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdiForget.Text == "")
            {
                RadMessageBox.SetThemeName("TelerikMetro");
                RadMessageBox.Show("Lütfen kullanıcı adınızı girin.", "Hata");

            }
            else
            {
                KullaniciKontrol();

                txtEmailKontrol.Enabled = true;
                btnSifreGonder.Enabled = true;
            }

        }

    }
}
