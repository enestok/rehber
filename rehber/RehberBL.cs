using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rehber
{
  public  class RehberBL  //BL -> business logic layer anlamında..
    {
      public List<RehberModel> RehberList() //List -> collection. List<Type> -> generic collection. içerisine her türden veri alabilir.
      {
          SqlConnection baglanti = new SqlConnection("Data Source=ENESTOK\\ENESTOK;Initial Catalog=tokDB;Integrated Security=True");
          baglanti.Open();

          var cmd = new SqlCommand("Select * From Rehber Where kullaniciId = @kulId", baglanti);

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
              model.Soyisim = rd["soyisim"].ToString();
              model.Isim = rd["isim"].ToString();
              model.Id =Int32.Parse( rd["ID"].ToString() );
              model.KullaniciID = Int32.Parse(rd["kullaniciID"].ToString());

              lst.Add(model);
          }
          baglanti.Close();
          
          return lst;
      }
  }
}
