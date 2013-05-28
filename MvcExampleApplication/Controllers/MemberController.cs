using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcExampleApplication.Models;

namespace MvcExampleApplication.Controllers
{
    public class MemberController : Controller
    {
        //
        // GET: /Member/

        MemberServices memberModel = new MemberServices();
        #region Get Methods
        public ActionResult EditMember(int id)
        {
            var Model = memberModel.GetMember(id);
            return View(Model);
        }
        public ActionResult CreateMemeber()
        {
            return View();
        }
        public ActionResult Index()
        {
            var Model = memberModel.GetAllMember();
            return View(Model);
        }
        #endregion

        #region Post Methods
        [HttpPost]
        public ActionResult AddMember(Member member)
        {
            if (ModelState.IsValid)
            {
                memberModel.CreateMember(member);
                return RedirectToAction("Index");
            }
            return View(member);
        }
        [HttpPost]
        public ActionResult SubmitMember(Member member)
        {
            if (ModelState.IsValid)
            {
                memberModel.UpdateMember(member);
                return RedirectToAction("Index");
            }
            return View(member);
        }
        #endregion


    }
}
