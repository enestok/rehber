using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.Logging;
using System.IO;
using System.Data.SqlClient;
using  mailGonder;

namespace rehber
{
    public partial class FrmLogin : Form
    {

        public RehberModel _rehberModel;

        public bool Login { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
            btnGiris.Focus();
            new RehberBLL.Common().Deneme();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (!KullaniciLoginDurum())
            {
                MessageBox.Show("Hatalı Giriş. Bilgilerinizi Kontrol Edin", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Login = false;
            }
            else
            {
      
                SqlConnection baglanti = new SqlConnection(SqlHelper.ConnectionString());
                SqlCommand komut = new SqlCommand("beniHatirla", baglanti); // beniHatirla (stored procedure)
                komut.CommandType = CommandType.StoredProcedure;

                if (chkBeniHatirla.Checked)
                {
                    komut.Parameters.AddWithValue("@beniHatirla", "true");
                    komut.Parameters.AddWithValue("@kullaniciAdi", txtKullaniciAdi.Text);

                    try
                    {
                        baglanti.Open();
                        komut.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                    finally
                    {
                        baglanti.Close();
                    }

                }

                
                //////////
                
                this.Hide();
                FrmRehber _frmRehber = new FrmRehber();
                _frmRehber.ShowDialog();
                this.Close();
                //Login = true;
            }

            //if (chkBeniHatirla.Checked)          
            //{

                ////File.WriteAllText(@"D:\\Kullanici_Adi.txt", txtKullaniciAdi.Text);
                ////File.WriteAllText(@"D:\\Kullanici_Adi.txt", txtSifre.Text);

                //FileStream fs = new FileStream("D:\\Kullanici_Adi.txt", FileMode.Append, FileAccess.Write);
                //StreamWriter srWriter = new StreamWriter(fs);

                //if (fs.Length != 0)
                //{
                //    srWriter.WriteLine(txtKullaniciAdi.Text);
                //    srWriter.WriteLine(txtSifre.Text);
                //}

                //srWriter.Close();
                //fs.Close();

               // var L = new tokDBEntities1().logins.Include(q=> q.beniHatirla.Equals(0));   // ???
                
            //}

            
        }

        private bool KullaniciLoginDurum()
        {
            try
            {
                // var login = new tokDBEntities1().logins.FirstOrDefault(q => q.kullaniciAdi.Equals(txtKullaniciAdi.Text) & q.sifre.Equals(txtSifre.Text));

                var j = new tokDBEntities1().logins.ToDictionary(x => x.kullaniciAdi);
                //-> x i key olarak atayıp, database'de uniq olan kullanıcı adı'nı da x e atadık.
                //j bütün kullanıcı adlarını çekecek.
                var uName = j[txtKullaniciAdi.Text];
                // kullanıcı adı textboxtakiyle aynı olan üye varsa işleme sokacak. 

                if (uName != null && uName.sifre == txtSifre.Text)
                {
                    KullaniciBilgi.KullaniciAdi = uName.kullaniciAdi;
                    KullaniciBilgi.KullaniciID = uName.kullaniciID;

                    return true;
                }
                return false;
            }
            catch (InvalidOperationException ex)
            {
                return false;
            }
            catch(KeyNotFoundException ex)
            {
                return false;
            }
            catch (SqlException)
            {
                DialogResult result = MessageBox.Show("Veritabanı bağlantısı yapılamadı. Bağlantıyı kontrol edip tekrar deneyiniz. ", "Bağlantı Hatası", MessageBoxButtons.RetryCancel);
               
                if (result == DialogResult.Retry)
                {
                    //btnGiris_Click içinde yapılan işlemler "yeniden dene" butonuna basılırsa tekrar çağırılıyor...
                    if (!KullaniciLoginDurum())
                    {
                        MessageBox.Show("Hatalı Giriş. Bilgilerinizi Kontrol Edin", "Hatalı Giriş", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        //Login = false;
                    }
                    else
                    {
                        SqlConnection baglanti = new SqlConnection("Data Source=ENESTOK\\ENESTOK;Initial Catalog=tokDB;Integrated Security=True");
                        SqlCommand komut = new SqlCommand("beniHatirla", baglanti); // beniHatirla (stored procedure)
                        komut.CommandType = CommandType.StoredProcedure;

                        if (chkBeniHatirla.Checked)
                        {
                            komut.Parameters.AddWithValue("@beniHatirla", "true");
                            komut.Parameters.AddWithValue("@kullaniciAdi", txtKullaniciAdi.Text);

                            try
                            {
                                baglanti.Open();
                                komut.ExecuteNonQuery();
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message.ToString());
                            }

                            finally
                            {
                                baglanti.Close();
                            }

                        }

                       
                        this.Hide();
                        FrmRehber _frmRehber = new FrmRehber();
                        _frmRehber.ShowDialog();
                        this.Close();
                        //Login = true;
                    }

                    if (chkBeniHatirla.Checked)
                    {

                        ////File.WriteAllText(@"D:\\Kullanici_Adi.txt", txtKullaniciAdi.Text);
                        ////File.WriteAllText(@"D:\\Kullanici_Adi.txt", txtSifre.Text);

                        //FileStream fs = new FileStream("D:\\Kullanici_Adi.txt", FileMode.Append, FileAccess.Write);
                        //StreamWriter srWriter = new StreamWriter(fs);

                        //if (fs.Length != 0)
                        //{
                        //    srWriter.WriteLine(txtKullaniciAdi.Text);
                        //    srWriter.WriteLine(txtSifre.Text);
                        //}

                        //srWriter.Close();
                        //fs.Close();
                    }
                    return true;
                }

                return false;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            new Frm_ePostaOlustur().ShowDialog();

            SqlConnection baglanti = new SqlConnection("Data Source=ENESTOK\\ENESTOK;Initial Catalog=tokDB;Integrated Security=True");
            SqlCommand komut = new SqlCommand("SELECT * FROM dbo.login WHERE beniHatirla = 'true'", baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
           

            //List<string> lstKullanici = new List<string>();
            //lstKullanici = kullaniciListe();

            //FileStream fs = new FileStream("D:\\Kullanici_Adi.txt", FileMode.OpenOrCreate, FileAccess.Read);

            //if (fs.Length != 0)
            //{
            //    txtKullaniciAdi.Text = lstKullanici[0];
            //    txtSifre.Text = lstKullanici[1];
            //}
        }

        public List<string> kullaniciListe() // beni hatırla check box ını işaretleyerek kaydedilen kullnaıcılar ve şifreleri kayıt edilen dosyadan alınarak listeye atılıyor..
        {
                List<string> list = new List<string>();
                
             
                foreach (string line in File.ReadLines(@"D:\\Kullanici_Adi.txt"))
                {
                    list.Add(line.ToString());
                }
            
                return list;

            
        }

        private void btnKayitOlDialog_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSignUp _frmSignUp = new FrmSignUp();
            _frmSignUp.ShowDialog();
            this.Close();
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {

            var j = new tokDBEntities1().logins.ToDictionary(x => x.kullaniciAdi);
            //-> x i key olarak atayıp, database'de uniq olan kullanıcı adı'nı da x e atadık.
            //j bütün kullanıcı adlarını çekecek.
            try
            {
                var uName = j[txtKullaniciAdi.Text];
                // kullanıcı adı textboxtakiyle aynı olan üye varsa işleme sokacak. 

                if (uName.beniHatirla == true)
                {
                    txtSifre.Text = uName.sifre;
                }
                else
                {
                    txtSifre.Clear();
                }
            }
            catch (KeyNotFoundException ex)
            {
                txtSifre.Clear();
            }




            //List<string> lstKullanici = new List<string>();
            //lstKullanici = kullaniciListe();
            //int i = 0;
            //foreach (string list in lstKullanici)
            //{
            //     if (lstKullanici.Contains(txtKullaniciAdi.Text)) //
            //     {
            //         int q = lstKullanici.FindIndex(a => a.Contains(txtKullaniciAdi.Text)); // beni hatırla check box ını işaretleyen kullanıcıların kullanıcı adlarını yazdıklarında şifrelerini otomatik olarak getiriyor..
            //        txtSifre.Text = lstKullanici[q + 1];    //
            //     }

            //}

        }


    }
}
