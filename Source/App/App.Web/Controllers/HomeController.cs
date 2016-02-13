namespace App.Web.Controllers
{
    using Data;
    using Data.Common;
    using Data.Models;
    using System;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private IDbRepository<Joke> jokes;
        private IDbRepository<JokeCategory> jokesCategory;

        public HomeController(
            IDbRepository<Joke> jokes,
            IDbRepository<JokeCategory> jokesCategory)
        {
            this.jokes = jokes;
            this.jokesCategory = jokesCategory;
        }

        // Poor man's DI
        //public HomeController()
        //{
        //    var dbContext = new AppDbContext();
        //    this.jokes = new DbRepository<Joke>(dbContext);
        //    this.jokesCategory = new DbRepository<JokeCategory>(dbContext);
        //    var category = new JokeCategory { Name = "Delete me" };
        //    this.jokesCategory.Add(category);
        //    for (int i = 0; i < 6; i++)
        //    {
        //        var joke = new Joke { Content = i.ToString(), Category = category };
        //        this.jokes.Add(joke);
        //    }

        //    dbContext.SaveChanges();
        //}

        public ActionResult Index()
        {
            var jokies = this.jokes.All()
                 .OrderBy(x => Guid.NewGuid())
                 .Take(3);
            return this.View(jokies);
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