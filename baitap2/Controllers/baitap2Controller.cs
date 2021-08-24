using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baitap2.Models;

namespace baitap2.Controllers
{
    public class baitap2Controller : Controller

    {
        Giaiphuongtrinh gpt = new Giaiphuongtrinh();
        // GET: baitap2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GiaiPTBT1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPTBT1(double heSoa, double heSob)
        {
            double x = gpt.GiaiPhuongTrinhBacNhat(heSoa, heSob);
            ViewBag.nghiemPT = x;
            return View();
        }

    }
}