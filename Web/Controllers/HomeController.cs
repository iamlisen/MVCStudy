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

		[HttpGet]
		public ActionResult RsvpForm(){
			return View();
		}

		[HttpPost]
		public ViewResult RsvpForm(GuestResponse response){
			if (ModelState.IsValid)
			{
				ViewBag.Title = "谢谢";
				return View(response);
			}else{
				return View();
			}
		}

		[HttpPost]
		public ViewResult Thanks(GuestResponse response){
			return View(response);
		}
	}
}