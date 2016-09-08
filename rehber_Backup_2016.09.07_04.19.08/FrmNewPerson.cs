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

namespace rehber
{
    public partial class FrmNewPerson : Form //yeni kayıt ekleme formu..
    {
        FrmRehber _frmRehber;

        public FrmNewPerson(FrmRehber frmRehber)
        {
            InitializeComponent();
            _frmRehber = frmRehber;
        }

        public FrmNewPerson()
        {
            InitializeComponent();
        }

        string resimYolu;

        private void btnSec_Click_1(object sender, EventArgs e)
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
            if (textIsim.Text == "" || maskedTxtNumara.Text == "")
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz !");
            else
            {
                if (new RehberBL().NumaraVar(maskedTxtNumara.Text, KullaniciBilgi.KullaniciID,0))
                {
                    MessageBox.Show("Aynı numaraya sahip kullanıcı mevcut!!");
                    maskedTxtNumara.Clear();
                    maskedTxtNumara.Focus();
                    return;
                }
                else
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

                    if (textIsim.Text.Length + textSoyisim.Text.Length >= 34)
                    {
                        
                    }
                    else
                    {
                        komut.Parameters.AddWithValue("@isim", textIsim.Text);
                        komut.Parameters.AddWithValue("@soyisim", textSoyisim.Text);
                    }

                    if (IsMailAddress(textMail.Text) == false)
                    {
                        MessageBox.Show("e mail adresinizi kontrol ediniz");
                    }
                    else
                    {
                        komut.Parameters.AddWithValue("@eMail", textMail.Text); 
                    }

                    komut.Parameters.AddWithValue("@telNo", maskedTxtNumara.Text);
                    komut.Parameters.AddWithValue("@dTarih", dtDogumTarihi.Value);
                    komut.Parameters.AddWithValue("@cinsiyet", comboBox1.SelectedItem);
                    komut.Parameters.AddWithValue("@isTanimi", richTextBox1.Text);
                    komut.Parameters.AddWithValue("@kullaniciID", KullaniciBilgi.KullaniciID);

                    try
                    {
                        baglanti.Open();
                        komut.ExecuteNonQuery();

                        _frmRehber.listele();
                        _frmRehber.controlsEnableOrNot();

                        MessageBox.Show(" Kayıt İşlemi Tamamlandı. ", "Kayıt Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                
            }
        }

        private void Temizle()
        {
            textIsim.Clear();
            textSoyisim.Clear();
            maskedTxtNumara.Clear();
            textMail.Clear();
            pictureBox.Image = null;
            richTextBox1.Clear();
            comboBox1.SelectedItem = null;
            dtDogumTarihi.Text = "01-01-1990";
            ActiveControl = textIsim;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNewPerson_Load(object sender, EventArgs e)
        {
           
        }

        private void textSoyisim_Leave(object sender, EventArgs e)
        {
            if (textIsim.Text.Length + textSoyisim.Text.Length >=34)
            {
                MessageBox.Show("Belirlenen ad çok uzun.");
                textIsim.Clear();
                textSoyisim.Clear();
            }
        }

        private void textIsim_Leave(object sender, EventArgs e)
        {
            if (textIsim.Text.Length + textSoyisim.Text.Length >= 34)
            {
                MessageBox.Show("Belirlenen ad çok uzun.");
                textIsim.Clear();
                textSoyisim.Clear();
                textIsim.Focus();
            }
        }

        public bool IsMailAddress(string mail)
        {
            List<string> lst = new List<string>();
            if (mail.Contains("@") && mail.Contains(".com") )// sadece .com olmasın. .gov .co vs de olsun   
            {
                return true;
            }
            return false;
        }

        private void textMail_TextChanged(object sender, EventArgs e)
        {

        }
        
    }


    
}
