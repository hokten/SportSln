using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models.ViewModels
{
    public class UrunListesiViewModel
    {
        public IEnumerable<Urun> Urunler { get; set; }
        public SayfalamaBilgi sayfalamaBilgisi { get; set; }
    }
}
