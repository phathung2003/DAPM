using QLMB.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;


namespace QLMB.Controllers
{
    public class HomeController : Controller
    {
        database db = new database();

        public ActionResult Index()
        {
            var suKienList = db.SuKienUuDais.OrderByDescending(s => s.NgayBatDau);
            
            return View(suKienList);
        }


    }
}