using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webfront.Helpers;

namespace Webfront.Controllers
{
    public class JsonController : Controller
    {
        public JsonResult GetCategories(int laId)
        {
            var categoryData = CategoryHelpers.GetCategories(laId);
            return Json(categoryData, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCategory(int laId, int categoryId)
        {
            var categoryData = CategoryHelpers.GetCategory(laId, categoryId);
            return Json(categoryData, JsonRequestBehavior.AllowGet);
        }
    }
}