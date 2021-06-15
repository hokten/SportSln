using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;

namespace SportStore.Components
{
    public class GezinmeMenusuViewComponent : ViewComponent
    {
        private IStoreRepository repo;
        public GezinmeMenusuViewComponent(IStoreRepository rp)
        {
            repo = rp;
        }
        public IViewComponentResult Invoke()
        {
            return View(repo.Urunler
            .Select(x => x.UrunKategorisi)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}
