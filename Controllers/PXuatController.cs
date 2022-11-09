using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    /// <summary>
    /// controller quan ly phieu nhap
    /// </summary>

    public class PXuatController : Controller
    {
        public ttcn_btlEntities ttcn_BtlEnt { get; set; }
        // GET: PNhap
        public ActionResult Index()
        {
            ttcn_BtlEnt = new ttcn_btlEntities();
            ViewBag.Title = "Quan ly phieu nhap";
            return View(ttcn_BtlEnt);
        }
    }
}