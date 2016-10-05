using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Microsoft.SqlServer.Server;
using Telerik.WinControls;

namespace rehber
{
    public partial class FrmNewPerson : BaseRadForm //yeni kayıt ekleme formu..
    {
        FrmRehber _frmRehber;

        public FrmNewPerson(FrmRehber frmRehber)
        {
            InitializeComponent();
            _frmRehber = frmRehber;

            var aa = new Dictionary<string, string>() { { "K", "Kadın" }, { "E", "Erkek" } };
            cmbCinsiyet.DataSource = aa;
            cmbCinsiyet.DisplayMember = "Value";
            cmbCinsiyet.ValueMember = "Key";
        }

        public FrmNewPerson()
        {
            InitializeComponent();

            var aa = new Dictionary<string, string>() { { "K", "Kadın" }, { "E", "Erkek" } };
            cmbCinsiyet.DataSource = aa;
            cmbCinsiyet.DisplayMember = "Value";
            cmbCinsiyet.ValueMember = "Key";
        }

        string resimYolu;

        private void btnSec_Click(object sender, EventArgs e)
        {
                openFileDialog1.Title = "Resim Seç..";
                openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var ss = Guid.NewGuid();
                    pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                    resimYolu = openFileDialog1.FileName.ToString();
                }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text == "" || maskedTxtNumara.Text == "(____)-___-____")
            {
                RadMessageBox.SetThemeName("TelerikMetro");
                RadMessageBox.Show("Yıldızlı alanları boş bırakmayınız !", "Boş Alanları Doldurunuz");
                
            }
            else
            {
                if (new RehberBL().NumaraVar(maskedTxtNumara.Text, KullaniciBilgi.KullaniciID,0))
                {
                    RadMessageBox.SetThemeName("TelerikMetro");
                    DialogResult result = RadMessageBox.Show("Aynı numaraya sahip kullanıcı mevcut!! \n " +
                                       "Yine de kaydetmek istiyor musunuz?", "Aynı Numara Mevcut",MessageBoxButtons.YesNo,RadMessageIcon.Info);
                    
                    // kayıtlarda aynı numara varsa kullanıcıya uyarı göndermek için tekrar if-else açtık!  
                    if (result == DialogResult.Yes)
                    {
                        //Sql Veritabanı Bağlantısı ve Kayıt işlemleri
                        SqlConnection baglanti = new SqlHelper().Connection();
                        SqlCommand komut = new SqlCommand("resimKayit", baglanti);   //resimKayit (stored procedure)
                        komut.CommandType = CommandType.StoredProcedure;

                        if (pictureBox.Image == null)
                            komut.Parameters.Add("@Resim", SqlDbType.Image).Value = DBNull.Value;
                        else
                        {
                            FileStream fs = new FileStream(resimYolu, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] resim = br.ReadBytes(Convert.ToInt32(fs.Length));
                            br.Close();
                            fs.Close();

                            komut.Parameters.AddWithValue("@Resim", resim); //resim yolunu veritabanına "binary" olarak kaydediyor.
                        }

                        if (txtIsim.Text.Length + txtSoyisim.Text.Length < 34)
                        {
                            komut.Parameters.AddWithValue("@isim", txtIsim.Text);
                            komut.Parameters.AddWithValue("@soyisim", txtSoyisim.Text);
                        }

                        if (IsMailAddress(txtMail.Text) == false)
                        {
                            RadMessageBox.SetThemeName("TelerikMetro");
                            RadMessageBox.Show("E Mail adresinizi kontrol ediniz. (örnek: biri@biryer.com)");

                        }
                        else if (IsMailAddress(txtMail.Text) && txtMail.Text != null)
                        {
                            komut.Parameters.AddWithValue("@eMail", txtMail.Text);
                        }
                        else
                        {
                            komut.Parameters.AddWithValue("@eMail", "NULL");
                        }

                        komut.Parameters.AddWithValue("@telNo", maskedTxtNumara.Text);
                        komut.Parameters.AddWithValue("@dTarih", dtDogumTarihi.Value);
                        komut.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.SelectedValue);
                        komut.Parameters.AddWithValue("@isTanimi", txtRchIsTanimi.Text);
                        komut.Parameters.AddWithValue("@kullaniciID", KullaniciBilgi.KullaniciID);

                        try
                        {
                            baglanti.Open();
                            komut.ExecuteNonQuery();

                            _frmRehber.listele();
                            _frmRehber.controlsEnableOrNot();

                            RadMessageBox.SetThemeName("TelerikMetro");
                            RadMessageBox.Show(" Kayıt İşlemi Tamamlandı. ", "Kayıt Ekle", MessageBoxButtons.OK, RadMessageIcon.Info);
                            Temizle();
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
                    else
                    {
                        maskedTxtNumara.Clear();
                        maskedTxtNumara.Focus();
                        
                    }

                    return;
                }
                else
                {
                    
                    //Sql Veritabanı Bağlantısı ve Kayıt işlemleri
                    SqlConnection baglanti = new SqlHelper().Connection();
                    SqlCommand komut = new SqlCommand("resimKayit", baglanti);
                    komut.CommandType = CommandType.StoredProcedure; // resimKayit (stored procedure)

                    if (pictureBox.Image == null)
                        komut.Parameters.Add("@Resim", SqlDbType.Image).Value = DBNull.Value;
                    else
                    {
                        FileStream fs = new FileStream(resimYolu, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        byte[] resim = br.ReadBytes(Convert.ToInt32(fs.Length));
                        br.Close();
                        fs.Close();

                        komut.Parameters.AddWithValue("@Resim", resim); //resim yolunu veritabanına 
                                                                        //"binary" olarak kaydediyor.
                    }

                    if (txtIsim.Text.Length + txtSoyisim.Text.Length < 34)
                    {
                        komut.Parameters.AddWithValue("@isim", txtIsim.Text);
                        komut.Parameters.AddWithValue("@soyisim", txtSoyisim.Text);
                    }

                    if (IsMailAddress(txtMail.Text) == false)
                    {
                        RadMessageBox.SetThemeName("TelerikMetro");
                        RadMessageBox.Show("E Mail adresinizi kontrol ediniz. " +
                                           "(örnek: biri@biryer.com)");
                        
                    }
                    else if (IsMailAddress(txtMail.Text) && txtMail.Text != null)
                    {
                        komut.Parameters.AddWithValue("@eMail", txtMail.Text); 
                    }

                    komut.Parameters.AddWithValue("@telNo", maskedTxtNumara.Text);
                    komut.Parameters.AddWithValue("@dTarih", dtDogumTarihi.Value);
                    komut.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.SelectedValue);
                    komut.Parameters.AddWithValue("@isTanimi", txtRchIsTanimi.Text);
                    komut.Parameters.AddWithValue("@kullaniciID", KullaniciBilgi.KullaniciID);

                    try
                    {
                        baglanti.Open();
                        komut.ExecuteNonQuery();

                        _frmRehber.listele();
                        _frmRehber.controlsEnableOrNot();

                        RadMessageBox.SetThemeName("TelerikMetro");
                        RadMessageBox.Show(" Kayıt İşlemi Tamamlandı. ", "Kayıt Ekle", 
                            MessageBoxButtons.OK, RadMessageIcon.Info);
                        Temizle();
                    }

                    catch (Exception ex)
                    {
                        RadMessageBox.SetThemeName("TelerikMetro");
                        RadMessageBox.Show(ex.Message.ToString());
                    }

                    finally
                    {
                        baglanti.Close();
                    }
                }
                
            }
        }

        private void Temizle()
        {
            txtIsim.Clear();
            txtSoyisim.Clear();
            maskedTxtNumara.Clear();
            txtMail.Clear();
            pictureBox.Image = null;
            txtRchIsTanimi.Clear();
            cmbCinsiyet.SelectedItem = null;
            dtDogumTarihi.Text = "01-01-1990";
            ActiveControl = txtIsim;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoyisim_Leave(object sender, EventArgs e)
        {
            if (txtIsim.Text.Length + txtSoyisim.Text.Length >=34)
            {
                RadMessageBox.SetThemeName("TelerikMetro");
                RadMessageBox.Show("Belirlenen ad çok uzun.");

                txtIsim.Clear();
                txtSoyisim.Clear();
            }
        }

        private void txtIsim_Leave(object sender, EventArgs e)
        {
            if (txtIsim.Text.Length + txtSoyisim.Text.Length >= 34)
            {
                RadMessageBox.SetThemeName("TelerikMetro");
                RadMessageBox.Show("Belirlenen ad çok uzun.");

                txtIsim.Clear();
                txtSoyisim.Clear();
                txtIsim.Focus();
            }
        }

        public bool IsMailAddress(string mail)
        {
           
            if (mail.Contains("@") && mail.Contains(".com") || txtMail.Text == null )// sadece .com olmasın. .gov .co vs de olsun   
            {
                return true;
            }
            return false;
           
            
        }


        
    }


    
}
