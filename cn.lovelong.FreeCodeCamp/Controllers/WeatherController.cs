using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cn.lovelong.Common.Utilities;

namespace cn.lovelong.FreeCodeCamp.Controllers
{
    public class WeatherController : Controller
    {
        /// <summary>
        /// 获取聚合天气
        /// </summary>
        /// <returns></returns>
        public ActionResult GetFromJuhe(string cityname, string dtype = "json", int format = 2)
        {
            try
            {
                var appkey = "acbfaca7beb1ec06c592aed8c0e5f225";
                var sb =
                    $"https://v.juhe.cn/weather/index?cityname={cityname}&dtype={dtype}&format={format}&key={appkey}";
                HttpHelper helper = new HttpHelper();
                HttpItem item = new HttpItem()
                {
                    URL = sb, //URL这里都是测试     必需项
                    Method = "get", //URL     可选项 默认为Get
                };
                //得到HTML代码
                HttpResult result = helper.GetHtml(item);
                var resultData = result.Html;
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exception)
            {
                return Json(exception, JsonRequestBehavior.AllowGet);
            }
        }
    }
}