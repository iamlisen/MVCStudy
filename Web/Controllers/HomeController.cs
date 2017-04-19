using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Greeting = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			ViewBag.Title = "首页";
			return View();
		}
	}
}