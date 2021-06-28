using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DatVeController : Controller
    {
        // GET: DatVe
        public ActionResult Index()
        {
            Connection con = new Connection();
            List<DatVe> list = con.GetALLDV();
            return View(list);
        }
        public ActionResult Edit(int ID)
        {
            Connection d = new Connection();
            DatVe h = d.GetDatVe(ID);
            return View(h);
        }

        [HttpPost]
        public ActionResult Edit(DatVe h)
        {
            Connection d = new Connection();
            if (d.updateDV(h))
            {
                return RedirectToAction("Index");
            }
            ViewBag.mess = "Update không thành công";
            return View();
        }
        public ActionResult Delete(int ID)
        {
            Connection d = new Connection();
            if (!d.deleteDV(ID))
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
        public ActionResult Create(DatVe h)
        {
            Connection d = new Connection();
            if (d.insertDV(h))
            {
                return RedirectToAction("Index");
            }
            ViewBag.mess = "Insert không thành công";
            return View();
        }
    }
}