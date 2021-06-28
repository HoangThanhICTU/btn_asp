using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ThongTinVeController : Controller
    {
        // GET: ThongTinVe
        public ActionResult Index()
        {
            Connection con = new Connection();
            List<ThongTinVe> list = con.GetALLTTV();
            return View(list);
        }
        public ActionResult Edit(int ID)
        {
            Connection d = new Connection();
            ThongTinVe h = d.GetThongTinVe(ID);
            return View(h);
        }

        [HttpPost]
        public ActionResult Edit(ThongTinVe h)
        {
            Connection d = new Connection();
            if (d.updateTTV(h))
            {
                return RedirectToAction("Index");
            }
            ViewBag.mess = "Update không thành công";
            return View();
        }
        public ActionResult Delete(int ID)
        {
            Connection d = new Connection();
            if (!d.deleteTTV(ID))
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
        public ActionResult Create(ThongTinVe h)
        {
            Connection d = new Connection();
            if (d.insertTTV(h))
            {
                return RedirectToAction("Index");
            }
            ViewBag.mess = "Insert không thành công";
            return View();
        }
    }
}