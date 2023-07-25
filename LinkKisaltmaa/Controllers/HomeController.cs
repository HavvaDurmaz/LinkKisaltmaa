using LinkKisaltmaa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace LinkKisaltmaa.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index( string UserLink)
        {
            string YeniKisaKod = "";
            DatabaseContext db= new DatabaseContext();

            do
            {
                YeniKisaKod = new Random().Next(0, 99999).ToString();

            } while (db.TBLLink.Any(x => x.KisaLink == YeniKisaKod));


            TBLLink t = new TBLLink();
            t.UzunLink = UserLink;
            t.KisaLink = YeniKisaKod;
            db.TBLLink.Add(t);
            db.SaveChanges();
            ViewBag.Mesaj = "Linkiniz: kisalt.havvadrmz.com/" + t.KisaLink;
            return View();
        }

    }
}
