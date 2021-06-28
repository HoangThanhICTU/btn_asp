using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HangMayBayController : Controller
    {
        // GET: HangMayBay
        public ActionResult Index()
        {
            Connection con = new Connection();
            List<HangMayBay> list = con.GetALLHMB();
            return View(list);
        }
        public ActionResult Edit(int ID)
        {
            Connection d = new Connection();
            HangMayBay h = d.GetHangMayBay(ID);
            return View(h);
        }

        [HttpPost]
        public ActionResult Edit(HangMayBay h)
        {
            Connection d = new Connection();
            if (d.updateHMB(h))
            {
                return RedirectToAction("Index");
            }
            ViewBag.mess = "Update không thành công";
            return View();
        }
        public ActionResult Delete(int ID)
        {
            Connection d = new Connection();
            if (!d.deleteHMB(ID))
            {
                ViewBag.mess = "Xóa không thành công";
            }
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HangMayBay h)
        {
            Connection d = new Connection();
            if (d.insertHMB(h))
            {
                return RedirectToAction("Index");
            }
            ViewBag.mess = "Insert không thành công";
            return View();
        }

        private object GetALLHMB()
        {
            throw new NotImplementedException();
        }
    }
}