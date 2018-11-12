using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShopProject.Models;

namespace WebShopProject.Controllers
{
    public class SidebarController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        // GET: Different
        public ActionResult CustomerOrder()
        {
            return View();
        }

        public JsonResult GetOrders()
        {
            IEnumerable<CustomerOrder> model = dbContext.CustomerOrders.ToList();

            return Json(model, JsonRequestBehavior.AllowGet);

        }
    }
}