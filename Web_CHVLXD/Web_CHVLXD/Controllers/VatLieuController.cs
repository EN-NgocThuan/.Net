using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_CHVLXD.Models;
namespace Web_CHVLXD.Controllers
{
    public class VatLieuController : Controller
    {
        // GET: VatLieu
        QL_VLXDDataContext db = new QL_VLXDDataContext();
        public ActionResult Items()
        {
            var lstItem = db.VATLIEUs.Select(r=>r); 
            return View(lstItem);
        }
    }
}