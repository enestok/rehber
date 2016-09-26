using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rehber
{
  public  class RehberBL  // BL -> business logic layer anlamında..
    {
      public List<RehberModel> RehberList() //List -> collection. List<Type> -> generic collection. içerisine her türden veri alabilir.
      {
          SqlConnection baglanti = new SqlHelper().Connection();
          baglanti.Open();

          var cmd = new SqlCommand("SELECT * FROM rehber WHERE kullaniciId = @kulId", baglanti);

          cmd.Parameters.AddWithValue("@kulId", KullaniciBilgi.KullaniciID);

          var rd = cmd.ExecuteReader();

          var lst = new List<RehberModel>();

          while (rd.Read())
          {
              var model = new RehberModel();

              var resim = rd["resim"];
              if (resim != DBNull.Value)
              {
                  model.Resim = (byte[])rd["resim"];
              }

              model.Cinsiyet = rd["cinsiyet"].ToString();
              model.IsTanimi = rd["isTanimi"].ToString();
              model.DogumTarihi =DateTime.Parse( rd["dTarih"].ToString() );
              model.TelNo = rd["telNo"].ToString();
              model.EMail = rd["eMail"].ToString();
              model.Soyisim = rd["soyisim"].ToString();
              model.Isim = rd["isim"].ToString();
              model.Id =Int32.Parse( rd["ID"].ToString() );
              model.KullaniciID = Int32.Parse(rd["kullaniciID"].ToString());

              lst.Add(model);
          }
          baglanti.Close();
          
          return lst;
      }

      public bool NumaraVar(string numara, int kullaniciId,int kayitId)
      {
          var noKatSayi = new tokDBEntities1().rehbers.Count(q => q.telNo.Equals(numara) && q.kullaniciID == kullaniciId && q.ID != kayitId); // aynı numaradan, kullanıcı ID si aynı olan ama kayıt ID si farklı olan kac tane numara var?(aynı kullanıcının sadece 1 tane aynı numaraya sahip olmasını istiyoruz) 
                                                                                                                                              // bu yüzden buradan gelecek Count() en az 0 ve yalnız 0 gelmelidir. aynı numaranın başka kaydı yok anlamında...              
          return noKatSayi > 0;

      }
  }
}
