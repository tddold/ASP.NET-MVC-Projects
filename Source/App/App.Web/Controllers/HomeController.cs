namespace App.Web.Controllers
{
    using Data;
    using System.Web.Mvc;

    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public ActionResult Index()
        {
            var db = new AppDbContext();
            var usersCount = db.Users;
            return this.View();
        }

        public ActionResult About()
        {
            this.ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}