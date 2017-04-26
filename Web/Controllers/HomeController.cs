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
		Product myProduct = new Product
		{
			ProductID = 1,
			Name="Kayak",
			Description="A boat for a person",
			Category="Watersports",
			Price=275M
		};

		public ActionResult Index()
		{
			ViewBag.Title = "首页";
			return View(myProduct);
		}

		public ActionResult NameAndPrice(){
			ViewBag.Title = "名称&价格";
			return View(myProduct);
		}

		public ActionResult DemoExpression(){
			ViewBag.ProductCount = 1;
			ViewBag.ExpressShip = true;
			ViewBag.ApplyDiscount = false;
			ViewBag.Supplier = null;
			return View();
		}
	}
}