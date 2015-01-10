using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver;
using System.Configuration;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public JsonResult  GetLogs()
        {
            
            MongoServer server = MongoServer.Create(ConfigurationManager.AppSettings["connectionString"]);
            MongoDatabase mydb = server.GetDatabase("elmah");
            var errorcollection = mydb.GetCollection("Elmah");

            var docs = errorcollection.FindAllAs<MongoResult>().SetFields(Fields.Exclude(new String[]{"serverVariables","queryString","form","cookies"})).ToList();

            //List<Object list = new List<Object>();

            /*foreach(var  doc in docs)
            {
                BsonElement[] elements= doc.Elements.ToArray();
                list.Add(new { ApplicationName= elements[0].Value.RawValue.ToString()  });
            }*/

            return Json(docs,JsonRequestBehavior.AllowGet);
            //return Json(jsonres.ToList(), JsonRequestBehavior.AllowGet);
            //return Json(c.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}