using MYTest.Models.MYTestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MYTest.Controllers.MYTestControllers
{
    public class ApplicationController : Controller
    {
        // GET: Application
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveApplication(ApplicationModel model)
        {
            try
            {
                return Json(new { model = (new ApplicationModel().SaveApplication(model)) }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json(new { model = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult GetApplicationList(ApplicationModel model)
        {
            try
            {

            }
        }
    }
}