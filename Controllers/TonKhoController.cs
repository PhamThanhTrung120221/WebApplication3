using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    /// <summary>
    /// controller quan ly ton kho
    /// </summary>

    public class TonKhoController : Controller
    {
        public ttcn_btlEntities ttcn_BtlEnt { get; set; }
        // GET: TonKho
        public ActionResult Index()
        {
            ttcn_BtlEnt = new ttcn_btlEntities();
            ViewBag.Title = "Quan ly ton kho";
            return View(ttcn_BtlEnt);
        }
    }
}