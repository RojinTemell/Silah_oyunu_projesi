using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyuncu_uygulaması
{
   public  class Kesici_silah:Silah,Durbunsuz
    {
        public int Dayaniklik { get; set; }

        public   string Bicak_cekme()
        {
            return "BICAK ÇEKİLDİ";
        }

        
      public   string Gez_goz_arpacik_davranisi()
        {
            return "GEZ-GÖZ-ARPACIK KONUMUNA GETİRİLDİ";
        }

       
    }
}
