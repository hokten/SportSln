using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models.ViewModels
{
    public class SayfalamaBilgi
    {
        public int ToplamKayit { get; set; }
        public int SayfaBasinaKayit { get; set; }
        public int AktifSayfa { get; set; }
        public int ToplamSayfaSayisi => (int)Math.Ceiling((decimal)ToplamKayit / SayfaBasinaKayit);
    }
}
