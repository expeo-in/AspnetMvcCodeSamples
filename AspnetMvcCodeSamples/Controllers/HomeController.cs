using AspnetMvcCodeSamples.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AspnetMvcCodeSamples.Controllers
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

        public ActionResult CustomConfig()
        {
            var config = (WebAppInfoSection)System.Configuration.ConfigurationManager.GetSection("webappInfo");
            var output = new StringBuilder($"Title: {config.Title}, Contact: {config.Contact.Name} {config.Contact.Email}<br/>");
            foreach (var item in config.Offices)
            {
                var office = (OfficeElement)item;
                output.AppendLine($"Office: {office.Location} {office.Address} <br/>");
            }
            return Content(output.ToString());
        }
    }
}