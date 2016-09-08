using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;

namespace rehber
{
    public static class KullaniciBilgi
    {
        public static int KullaniciID { get; set; }
        public static string KullaniciAdi { get; set; }

        public static login KullaniciBilgileri
        {
            get { return new tokDBEntities1().logins.First(q => q.kullaniciID == KullaniciID); }
        }
    }
}
