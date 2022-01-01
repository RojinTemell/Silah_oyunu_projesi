using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyuncu_uygulaması
{
   public  class Atesli_silah:Silah,Durbunlu,Durbunsuz
    {
        public  const int  Max_mermi_sayisi = 10;
      public   string Yakinlastirma_davranisi()
        {
            return "HEDEF YAKINLAŞTIRILDI";
        }
      public   string Gez_goz_arpacik_davranisi()
        {
            return "GEZ-GÖZ-ARPACIK KONUMUNA GETİRİLDİ";
        }
    }
}
