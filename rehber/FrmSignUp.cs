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

namespace rehber
{
    public partial class FrmSignUp : Form
    {
       
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtKullaniciKayit.Text == "" && txtSifreKayit.Text == "" || txtSifreKayit.Text != txtSifreTekrarKayit.Text)
            {
                MessageBox.Show(" Boş alanları doldurunn ve şifrelerin uyuştuğundan emin olun! ", "Kayıt Ol", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                signUpDataContextDataContext signUpDataContext = new signUpDataContextDataContext();

                KullaniciKayit kayit = new KullaniciKayit();

                kayit.kullaniciAdi = txtKullaniciKayit.Text;
                kayit.sifre = txtSifreKayit.Text;
                kayit.beniHatirla = false;

                
                signUpDataContext.KullaniciKayits.InsertOnSubmit(kayit);
                
                signUpDataContext.SubmitChanges();

                MessageBox.Show("Kayıt başarılı.", "Kayıt Ol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnKayitOl.Enabled = false;
            }
        }
        
        private void FrmSignUp_Load(object sender, EventArgs e)
        {
            IsSingle(); //kullanıcı, textbox ları doldurana kadar kullanıcı adlarının tutulduğu listeyi taraması için çağırdım.
                        //böylece yeni girilecek kullanıcı eskileriyle karşılaştırılabilecek. 
        }

        private bool IsSingle() 
        {
            
            var aa = new tokDBEntities1().logins.SingleOrDefault(q=> q.kullaniciAdi.Equals(txtKullaniciKayit.Text));

            if (aa !=null) 
            {
                return false; 
            }
            return true;

        }

        private void btnSignUpCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKullaniciKayit_Leave(object sender, EventArgs e)
        {
            if (!IsSingle())
            {
                btnKayitOl.Enabled = false;

                lblKullaniciDurum.Text = "!! Kullanıcı adı mevcut. Başka bir kullanıcı adı seçiniz.";
                lblKullaniciDurum.ForeColor = Color.Red;

            }
            else
            {
                lblKullaniciDurum.ForeColor = Color.Black;
                lblKullaniciDurum.Text="***";
                btnKayitOl.Enabled = true;
            }
        }

        private void btnSignUpGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin _frmLogin = new FrmLogin();
            _frmLogin.ShowDialog();
            this.Close();

        }
        
    }
}
