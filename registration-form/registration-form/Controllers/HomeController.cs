using registration_form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace registration_form.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public ActionResult submitedData(Details Det)
		{
			if (ModelState.IsValid)
			{
				return View();
			}
			return View("Index");
		}
	}

}