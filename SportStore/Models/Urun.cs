using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStore.Models
{
    public class Urun
    {
        public long UrunID { get; set; }
        public string UrunAdi { get; set; }
        public string UrunAciklamasi { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal UrunFiyati { get; set; }
        public string UrunKategorisi { get; set; }
    }
}
