using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using webFinalProje.Models.siniflar;


namespace webFinalProje.Controllers
{
    public class CariPanelController : Controller
    {
		// GET: CariPanel
		
		Context c = new Context();
		[Authorize]
		public ActionResult Index()
        {
			var mail = (string)Session["CariMail"];
			var degerler = c.Carilers.FirstOrDefault(x => x.CariMail == mail);
			ViewBag.m = mail;
			return View(degerler);
		}

		[Authorize]
		public ActionResult Siparislerim()
		{
			var mail = (string)Session["CariMail"];
			var id = c.Carilers.Where(x => x.CariMail == mail.ToString()).Select(y => y.Cariid).FirstOrDefault();
			var degerler = c.SatisHarekets.Where(x => x.Cariid == id).ToList();
			return View(degerler);
		}

		[Authorize]
		public ActionResult GelenMesajlar()
		{
			var mail = (string)Session["CariMail"];
			var mesajlar = c.Mesajlars.Where(x => x.Alici == mail).OrderByDescending(x =>
			x.MesajID).ToList();
			var gelensayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
			ViewBag.d1 = gelensayisi;
			var gidensayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
			ViewBag.d2 = gidensayisi;
			return View(mesajlar);
		}

		[Authorize]
		public ActionResult GidenMesajlar()
		{
			var mail = (string)Session["CariMail"];
			var mesajlar = c.Mesajlars.Where(x => x.Gonderici == mail).OrderByDescending(z =>
			z.MesajID).ToList();
			var gelensayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
			ViewBag.d1 = gelensayisi;
			var gidensayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
			ViewBag.d2 = gidensayisi;
			return View(mesajlar);
		}

		[Authorize]
		public ActionResult MesajDetay(int id)
		{
			var degerler = c.Mesajlars.Where(x => x.MesajID == id).ToList();
			var mail = (string)Session["CariMail"];
			var gelensayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
			ViewBag.d1 = gelensayisi;
			var gidensayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
			ViewBag.d2 = gidensayisi;
			return View(degerler);
		}

		[Authorize]
		[HttpGet]
		public ActionResult YeniMesaj()
		{
			var mail = (string)Session["CariMail"];
			var gelensayisi = c.Mesajlars.Count(x => x.Alici == mail).ToString();
			ViewBag.d1 = gelensayisi;
			var gidensayisi = c.Mesajlars.Count(x => x.Gonderici == mail).ToString();
			ViewBag.d2 = gidensayisi;
			return View();
		}
		[HttpPost]
		public ActionResult YeniMesaj(Mesajlar m)
		{
			var mail = (string)Session["CariMail"];
			m.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
			m.Gonderici = mail;
			c.Mesajlars.Add(m);
			c.SaveChanges();
			return View();
		}

		public ActionResult CariKargoTakip(string id)
		{
			var degerler = c.KargoTakips.Where(x => x.TakipKodu == id).ToList();
			return View(degerler);
		}

		public ActionResult LogOut()
		{
			FormsAuthentication.SignOut();
			Session.Abandon();
			return RedirectToAction("Index", "Login");
		}


	}
}