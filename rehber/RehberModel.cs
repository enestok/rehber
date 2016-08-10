using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rehber
{
    public class RehberModel
    {
        public int Id { get; set; }
        public int KullaniciID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TelNo { get; set; }
        public string EMail { get; set; }
        public DateTime DogumTarihi { get; set; }
        public String IsTanimi { get; set; }
        public String Cinsiyet { get; set; }
        public byte[] Resim { get; set; }

        public string GenelBilgi
        {
            get
            {
                return Isim + " " + Soyisim;
            }
        }

        public string MailListe
        {
            get
            {
                return Isim + " " + Soyisim + " (" + EMail + ")";
            }
        }

    }
    
}
