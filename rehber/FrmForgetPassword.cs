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
                    tokDBEntities1 tokDB = new tokDBEntities1();

                    var sifreBilgi = from p in tokDB.logins
                                  where p.kullaniciAdi.Contains(txtKullaniciAdiForget.Text)
                                  select p.sifre;

                    MailMessage ePosta = new MailMessage();
                    ePosta.From = new MailAddress("enestok81@gmail.com");
                    //
                    ePosta.To.Add(KullaniciKontrol());
                    ePosta.To.Add("enestok81@gmail.com");
                    //
                    ePosta.Subject = "Rehber Sifreniz..";
                    //
                    foreach (var sifre in sifreBilgi)
                    {
                        ePosta.Body = "Sifreniz : " + sifre;
                    }
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
                       MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
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
                          select k.kullaniciEMail;   //  LINQ ifadesiyle txtKullaniciAdiForget isimli textbox'a 
                                                     //  yazılan ifadenin login tablosunun kullaniciAdi sütununda 
                                                     //  karşılığı olup olmadığına bakılıyor. Varsa, kullanıcıya ait 
                                                     //  E Mail bilgisi 'kontrol' değişkenine atanıyor. 

            string mKontrol = "";
            foreach (var mail in kontrol)
            {
                string[] alanAdi = mail.Split('@'); //  alan adını split fonksiyonunu kullanarak 
                                                    //  '@' karakteriyle bölüyor.   

                var inChars = alanAdi[0].Substring(0, (alanAdi[0].Length - 3));  
                                                    // alan adının sondan 3 karakterini siliyor.

                string S = "";
                for (int i = 0; i < 3; i++) //  silinen karakter kadar yıldız bastırılıyor.
                {
                    S += '*';
                }
                var toLabelText = string.Concat(inChars, S, '@', alanAdi[1]); // sondan 3 karakteri silinmiş string ifadeyi
                                                                              // silinen karakterlerin yerine gelecek yıldızları
                                                                              // ve domain i CONCAT metoduyla birleştiriliyor.
                lblEmailKontrol.Text = toLabelText;
                lblDesc.Text = "Yukarıdaki bilgilere sahip mail adresinizi aşağıya yazarak şifrenizi öğrenebilirsiniz. ";

                mKontrol = mail;
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
