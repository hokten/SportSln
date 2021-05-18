using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportStore.Models
{
    public static class SeedData
    {
        public static void EminOl(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Urunler.Any())
            {
                context.Urunler.AddRange(
                    new Urun { 
                        UrunAdi="Tenis Topu", 
                        UrunAciklamasi="Sarı Renkte",
                        UrunFiyati=34.56m,
                        UrunKategorisi="top"
                    },
                   new Urun
                   {
                       UrunAdi = "Futbol Topu",
                       UrunAciklamasi = "Mavi Renkte",
                       UrunFiyati = 14.56m,
                       UrunKategorisi = "top"
                   },
                  new Urun
                  {
                      UrunAdi = "Tişört",
                      UrunAciklamasi = "Pembe Renkte",
                      UrunFiyati = 48,
                      UrunKategorisi = "giysi"
                  },
                  new Urun
                  {
                      UrunAdi = "Spor Şapka",
                      UrunAciklamasi = "Desenli",
                      UrunFiyati = 11.76m,
                      UrunKategorisi = "giysi"
                  });
                context.SaveChanges();
            }
        }

    }
}
