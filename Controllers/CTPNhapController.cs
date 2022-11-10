using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    /// <summary>
    /// controller quan ly chi tiet phieu nhap
    /// </summary>

    public class CTPNhapController : Controller
    {
        public ttcn_btlEntities ttcn_BtlEnt { get; set; }
        // GET: CTPNhap
        public ActionResult Index()
        {
            ttcn_BtlEnt = new ttcn_btlEntities();
            ViewBag.Title = "Quan ly chi tiet phieu nhap";
            return View(ttcn_BtlEnt);
        }
    }
}