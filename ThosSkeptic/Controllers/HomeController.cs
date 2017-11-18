using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace ThosSkeptic.Controllers
{
	public class HomeController : Controller
	{

		public ActionResult Index()
		{
			var mvcName = typeof(Controller).Assembly.GetName();
			var isMono = Type.GetType("Mono.Runtime") != null;

			ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData["Runtime"] = isMono ? "Mono" : ".NET";

			return View();
		}


		public ActionResult BlogLatest()
		{
			return View();
		}

		public ActionResult Blog()
		{
			return View();
		}

		public ActionResult SignIn()
		{
			return View();
		}

		public ActionResult Carousel()
		{
			return View();
		}

		public ActionResult Carousel2()
		{
			return View();
		}

		public ActionResult Examples()
		{
			return View();
		}

		public ActionResult GridsExample()
		{
			return View();
		}

		public ActionResult MarketingLandingExample()
		{
			return View();
		}

		public ActionResult Dashboard()
		{
			return View();
		}
	}
}
