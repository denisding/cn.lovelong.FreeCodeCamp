using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace cn.lovelong.FreeCodeCamp.Controllers
{
    public class FamousQuotesController : Controller
    {
        public JsonResult GetRandom()
        {
            BLL.IFamousQuotesView bll = new BLL.FamousQuotesView();
            var model = bll.GetRandom();
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}
