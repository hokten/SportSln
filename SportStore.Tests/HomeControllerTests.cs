using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SportStore.Controllers;
using SportStore.Models;
using Microsoft.Extensions.Logging;
using Xunit;

namespace SportStore.Tests
{
    public class HomeControllerTests
    {
        private readonly ILogger<HomeController> _logger;
        [Fact]
        public void Depo_Kullanim_Testi()
        {
            Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
            mock.Setup(m => m.Urunler).Returns((
                new Urun[]
                {
                    new Urun {UrunID=1, UrunAdi="P1"},
                    new Urun {UrunID=2, UrunAdi="P2"}
                }).AsQueryable<Urun>());
            HomeController controller = new HomeController(_logger, mock.Object);

            IEnumerable<Urun> result = (controller.Index() as ViewResult).ViewData.Model as IEnumerable<Urun>;

            Urun[] urunDizi = result.ToArray();
            Assert.True(urunDizi.Length == 2);
            Assert.Equal("P1", urunDizi[0].UrunAdi);
            Assert.Equal("P2", urunDizi[1].UrunAdi);


        }
    }
}
