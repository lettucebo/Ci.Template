﻿namespace $safeprojectname$.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// <see cref="http://materializecss.com/"/>
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class MaterializeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Landing()
        {
            return View();
        }
    }
}