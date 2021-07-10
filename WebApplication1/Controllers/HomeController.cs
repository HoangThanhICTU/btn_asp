using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Connection con = new Connection();
            List<ThongTinVe> list = con.GetALLTTV();
            return View(list);
        }
        public ActionResult CreateKH(int ID)
        {
            Connection con = new Connection();
            ThongTinVe ttv = con.GetThongTinVe(ID);
            DatVe dv = new DatVe(ttv.CODE);
            return View(dv);
        }

        [HttpPost]
        public ActionResult CreateKH(DatVe dv)
        {
            Connection d = new Connection();
            if (d.insertDV(dv))
            {
                return RedirectToAction("Index");
            }
            ViewBag.mess = "Update không thành công";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}