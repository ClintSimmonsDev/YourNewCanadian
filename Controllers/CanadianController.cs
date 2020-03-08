using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using YourNewCanadian.Models;

namespace YourNewCanadian.Controllers
{
    public class CanadianController : Controller
    {
        // GET: Canadian
        public ActionResult Index()
        {
            using (CanadiansEntities3 db = new CanadiansEntities3())
            {
                var canadians = db.Canadians;
                var allCanadians = new List<Canadian>();
                foreach (var canadian in canadians)
                {
                    var Canadian = new Canadian
                    {
                        NewID = canadian.NewID,
                        first_name = canadian.first_name,
                        last_name = canadian.last_name,
                        company_name = canadian.company_name,
                        address = canadian.address,
                        city = canadian.city,
                        province = canadian.province,
                        postal = canadian.postal,
                        phone1 = canadian.phone1,
                        email = canadian.email,
                        web = canadian.web,
                    };
                    allCanadians.Add(Canadian);

                    //Random rand = new Random();
                    //int toSkip = rand.Next(0, db.Canadians.Count());
                    //toSkip = db.Canadians.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
                    //db.Canadians.Skip(toSkip).Take(1).First();
                    //ViewBag.var = toSkip;

                }
                Random rand = new Random();
                int toSkip = rand.Next(0, db.Canadians.Count());
                //string rando = toSkip.ToString();
                return View(allCanadians.Where(x => x.NewID == toSkip));
            }
        }
        //public ActionResult GetImage()
        //{
        //    var dir = Server.MapPath("../Content/Pix/People");
        //    Random randoPic = new Random();
        //    int toSkip = randoPic.Next(0, 50);
        //    var path = Path.Combine(dir, toSkip + ".jpg");
        //    return base.File(path, "image/jpeg");
        //}
    }
}