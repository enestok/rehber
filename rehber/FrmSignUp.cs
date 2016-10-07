using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace rehber
{
    public partial class FrmSignUp : BaseRadForm
    {
       
        public FrmSignUp()
        {
            InitializeComponent();
        }

        FrmNewPerson _mailAdr = new FrmNewPerson();
        
        private void FrmSignUp_Load(object sender, EventArgs e)
        {
            IsSingle(); //kullanıcı, textbox ları doldurana kadar kullanıcı adlarının tutulduğu listeyi taraması için çağırdım.
                        //böylece yeni girilecek kullanıcı eskileriyle karşılaştırılabilecek. 
        }

        private bool IsSingle() 
        {
            var kullanici = new tokDBEntities1().logins.SingleOrDefault(q=> q.kullaniciAdi.Equals(txtKullaniciKayit.Text));

            if (kullanici != null) //  0' dan farklı değilse aynı isimde başka bir kayıt mevcuttur.
            {                      //  bu yüzden IsSingle(). yani tek mi? -hayır, başka kayıt var. (false) 
                return false; 
            }
            return true;

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtKullaniciKayit.Text == "" && txtSifreKayit.Text == "" || txtSifreKayit.Text != txtSifreTekrarKayit.Text)
            {
                RadMessageBox.SetThemeName("TelerikMetro");
                RadMessageBox.Show(" Boş alanları doldurun ve şifrelerin uyuştuğundan emin olun! ", "Kayıt Ol", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            else
            {
               
                signUpDataContextDataContext signUpDataContext = new signUpDataContextDataContext();

                var kayit = new KullaniciKayit();
                
                kayit.kullaniciAdi = txtKullaniciKayit.Text;
                kayit.sifre = txtSifreKayit.Text;
                kayit.kullaniciEmail = txtMailKayit.Text;
                kayit.beniHatirla = false;

                signUpDataContext.KullaniciKayits.InsertOnSubmit(kayit);
                signUpDataContext.SubmitChanges();

                RadMessageBox.SetThemeName("TelerikMetro");
                RadMessageBox.Show("Kayıt başarılı.", "Kayıt Ol", MessageBoxButtons.OK, RadMessageIcon.Info);
                btnKayitOl.Enabled = false;
            }
        }

        private void btnSignUpCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUpGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin _frmLogin = new FrmLogin();
            _frmLogin.ShowDialog();
            this.Close();
        }

        private void txtKullaniciKayit_Leave(object sender, EventArgs e)
        {
            if (! IsSingle()) 
            {
                btnKayitOl.Enabled = false;
                
                lblKullaniciDurum.Text = "!! Kullanıcı adı mevcut. Başka bir kullanıcı adı seçiniz.";
                lblKullaniciDurum.ForeColor = Color.Red;

            }
            else
            {  
                lblKullaniciDurum.ForeColor = Color.Black;
                lblKullaniciDurum.Text = "***";
                btnKayitOl.Enabled = true;
            }
        }

        private void txtMailKayit_Leave(object sender, EventArgs e)
        {
            var mailAdr = _mailAdr.IsMailAddress(txtMailKayit.Text);
            if (mailAdr || txtMailKayit.Text == "")
            {
                lblKullaniciDurum.ForeColor = Color.Black;
                lblKullaniciDurum.Text = "***";
                btnKayitOl.Enabled = true;
            }
            else
            {
                btnKayitOl.Enabled = false;

                lblKullaniciDurum.Text = "!! Mail formatı geçerli değil. (örnek : biri@biryer.com).";
                lblKullaniciDurum.ForeColor = Color.Red;
            }
        }

       
        
    }
}
