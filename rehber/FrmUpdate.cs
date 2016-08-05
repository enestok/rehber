using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;

namespace rehber
{
    public partial class FrmUpdate : Form // kayıt güncelleme formu ..
    {
        public RehberModel _rehberModel;
        private FrmRehber _rehber;

        public FrmUpdate(RehberModel model, FrmRehber frm) //constructor -> yapıcı metod. list box ın double click olayında kullandık.
        {
            InitializeComponent();
            _rehberModel = model;//
            _rehber = frm;
            Ortak();
        }

        public FrmUpdate(RehberModel model)  //constructor -> yapıcı metod. guncelle butonunun click olayında kullandık.
        {
            InitializeComponent();
            _rehberModel = model;
            Ortak();
        }
        private void Ortak()
        {
            pictureBoxYeni.Image = image.icon_user_default;
            this.Text = "Kişi Güncelle(" + _rehberModel.GenelBilgi + ")";
        }

        private void guncelle_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlHelper().Connection();
            SqlCommand guncelle = new SqlCommand("kayitGuncelle", baglanti);  //kayitGuncelle (stored procedure)
            guncelle.CommandType = CommandType.StoredProcedure;

            textIsimYeni.Text = _rehberModel.Isim;
            textSoyisimYeni.Text = _rehberModel.Soyisim;
            maskedTxtNumaraYeni.Text = _rehberModel.TelNo;
            textMailYeni.Text = _rehberModel.EMail;
            comboBox1Yeni.SelectedItem = _rehberModel.Cinsiyet;
            dtDogumTarihiYeni.Value = _rehberModel.DogumTarihi;
            richTextBox1Yeni.Text = _rehberModel.IsTanimi;

            if (_rehberModel.Resim == null)
            {
                ImageConverter converter = new ImageConverter();
                pictureBoxYeni.Image = image.icon_user_default;
                //_rehberModel.Resim = (byte[])converter.ConvertFrom(pictureBoxYeni.Image);
            }
            else
            {
                byte[] imageArray = _rehberModel.Resim;
                ImageConverter converter = new ImageConverter();
                pictureBoxYeni.Image = (Image)converter.ConvertFrom(imageArray);
            }

        }

        string resimYolu;
        private void btnKaydetYeni_Click(object sender, EventArgs e)
        {
            EntityCompare(_rehberModel);

            if (textIsimYeni.Text == "" || maskedTxtNumaraYeni.Text == "")
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz !");
            else
            {
                if (new RehberBL().NumaraVar(maskedTxtNumaraYeni.Text, _rehberModel.KullaniciID,_rehberModel.Id))
                {
                    MessageBox.Show("Aynı numaraya sahip kullanıcı mevcut!!"); // yine de kaydetmek istiyor musunuz? ??? 
                    maskedTxtNumaraYeni.Clear();
                    maskedTxtNumaraYeni.Focus();
                    return;
                }
                else
                {
                    //Sql Veritabanı ve Kayıt işlemleri
                    SqlConnection baglanti = new SqlHelper().Connection();
                    SqlCommand guncelle = new SqlCommand("kayitGuncelle", baglanti);//kayitGuncelle (stored procedure)
                    guncelle.CommandType = CommandType.StoredProcedure;

                    var sonuc = ImageCompare.Compare((Bitmap)pictureBoxYeni.Image, image.icon_user_default);

                    if (sonuc == ImageCompare.CompareResult.ciNull || (sonuc == ImageCompare.CompareResult.ciCompareOk))//resource ekleyerek default görüntü atadık. resource eklemeyi adım adım deftere yaz.
                        guncelle.Parameters.Add("@ResimYeni", SqlDbType.Image).Value = DBNull.Value;  //veri tabanından resim bilgisi gelmediyse DB ye NULL yazsın..
                    else
                    { 
                        if (!string.IsNullOrEmpty(resimYolu)) // fotoğraf seç butonuna tıklandıysa (resim yolu na bir değer geldiyse) seçilen fotoğrafı db ye ekle..
                        {
                            FileStream fs = new FileStream(resimYolu, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fs);
                            byte[] resim = br.ReadBytes(Convert.ToInt32(fs.Length));
                            br.Close();
                            fs.Close();

                            guncelle.Parameters.Add("@ResimYeni", SqlDbType.Image).Value = (byte[])resim;
                        }



                    }

                    guncelle.Parameters.AddWithValue("@telNoYeni", maskedTxtNumaraYeni.Text);
                    guncelle.Parameters.AddWithValue("@eMailYeni", textMailYeni.Text);
                    guncelle.Parameters.AddWithValue("@isimYeni", textIsimYeni.Text);
                    guncelle.Parameters.AddWithValue("@soyisimYeni", textSoyisimYeni.Text);
                    guncelle.Parameters.AddWithValue("@dTarihYeni", dtDogumTarihiYeni.Value);
                    guncelle.Parameters.AddWithValue("@cinsiyetYeni", comboBox1Yeni.SelectedItem);
                    guncelle.Parameters.AddWithValue("@isTanimiYeni", richTextBox1Yeni.Text);
                    guncelle.Parameters.AddWithValue("@id", _rehberModel.Id);/////

                    try
                    {
                        baglanti.Open();
                        guncelle.ExecuteNonQuery();
                        MessageBox.Show(" Güncelleme İşlemi Tamamlandı. ");

                        if (_rehber != null)
                            _rehber.listele();
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
                
                this.Close();
            }
        }

        // güncelleme sırasında değiştirilmeyen verilerin aynen bırakılmak yerine gereksiz yere tekrar eklenmesini engellemek için yapılacak sınıfın başlangıcı
        private void EntityCompare(RehberModel model)
        {
            var cList = this.Controls;

            var ss = model.GetType().GetProperties();
        
            foreach (Control item in cList)
            {
                if (item.Tag == null)
                {
                    continue;
                }

                if (item.Tag.ToString() == "Model.Isim")//isim textbox ının tag i.
                {
                   var propp = ss.First(q => q.Name == "Isim");

                   var value = propp.GetValue(model);

                   //if (value.ToString() != item.Text)
                   //{
                   //    MessageBox.Show("Girilen değerler farklı");  //girilen değerler farklı, o zaman veritabanında değiştir. 
                   //}                                                //girilen değerler farklı değilse veritabanındaki kayıt aynı kalsın. .. anlamına gelen işlemi yapacak sınıfı yaz!!!
                }
            }
        }

        private void btnSecYeni_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç..";
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var ss = Guid.NewGuid();
                pictureBoxYeni.Image = Image.FromFile(openFileDialog1.FileName);
                resimYolu = openFileDialog1.FileName.ToString();
            }
        }

        private void btnTemizleYeni_Click_1(object sender, EventArgs e)
        {
 
            textIsimYeni.Clear();
            textSoyisimYeni.Clear();
            maskedTxtNumaraYeni.Clear();
            textMailYeni.Clear();
            pictureBoxYeni.Image = image.icon_user_default;
            richTextBox1Yeni.Clear();
            comboBox1Yeni.SelectedItem = null;
            dtDogumTarihiYeni.Text = "01-01-1990";
        }


    }

    public class ImageCompare //image compare -> İMAJ KARŞILAŞTIRMA.  
    {
        public enum CompareResult //enum -> kod tarafında sabit olacak, elle müdahale edilmeyecek sayı değerlerini tutar. 
        {
            ciCompareOk,
            ciPixelMismatch,
            ciSizeMismatch,
            ciNull
        };

        public static CompareResult Compare(Bitmap bmp1, Bitmap bmp2)// bitmap-> resmin pixel verilerine ulaşan sınıftır. image ile farkını araştır deftere yaz  
        {
            CompareResult cr = CompareResult.ciCompareOk;

            if (bmp1 == null || bmp2 == null)
            {
                return CompareResult.ciNull;
            }
            //Test to see if we have the same size of image
            if (bmp1.Size != bmp2.Size)
            {
                cr = CompareResult.ciSizeMismatch;
            }
            else
            {
                //Convert each image to a byte array
                System.Drawing.ImageConverter ic = new System.Drawing.ImageConverter();
                byte[] btImage1 = new byte[1];
                btImage1 = (byte[])ic.ConvertTo(bmp1, btImage1.GetType());
                byte[] btImage2 = new byte[1];
                btImage2 = (byte[])ic.ConvertTo(bmp2, btImage2.GetType());

                //Compute a hash for each image
                SHA256Managed shaM = new SHA256Managed();
                byte[] hash1 = shaM.ComputeHash(btImage1);
                byte[] hash2 = shaM.ComputeHash(btImage2);

                //Compare the hash values
                for (int i = 0; i < hash1.Length && i < hash2.Length && cr == CompareResult.ciCompareOk; i++)
                {
                    if (hash1[i] != hash2[i])
                        cr = CompareResult.ciPixelMismatch;
                }
            }
            return cr;
        }
    }
}

