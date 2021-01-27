using IntroNetCoreCont.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroNetCoreCont.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Esra";
            ViewBag.Time = DateTime.Now.Hour;

            // sayfada göstermek için ürünler ekliyoruz
            List<Product> products = new List<Product>();
            products.Add(new Product { Name = "Pizza", Price = 20 });
            products.Add(new Product { Name = "Dondurma", Price = 12 });
            products.Add(new Product { Name = "Su", Price = 5 });


            ViewBag.Products = products;

            //controllerden gönderiyoruz
            return View(products);
        }

        public IActionResult Davet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Davet(UserResponse userResponse)
        {
            //model durumu valid ise(required durumlara uyulmuşsa)
            if (ModelState.IsValid)
            {
                if (userResponse.IsAccepted)
                {
                    AcceptedUsers.Add(userResponse); //static class olduğu icin nesnesini olusturmadan metodu kullandık.

                }
                // TODO 1: Her şey doğru girilmisse bu kısım çalısacak..
                // Başka bir view'e göndermek isteniyor.
                return View("Tesekkur", userResponse); //user response'u gönder ki sayfada bilgilerini kullanabil.

            }
            return View();
        }

        public IActionResult Gelenler()
        {
            return View(AcceptedUsers.incomingUsers);
        }
    }
}
