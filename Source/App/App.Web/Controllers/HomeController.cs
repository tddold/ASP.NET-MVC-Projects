namespace App.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;

    using Data.Common;
    using Data.Models;
    using Web.Infrastructure.Mapping;
    using ViewModels.Home;
    using Services.Data;
    public class HomeController : Controller
    {
        private IJokesService jokes;
        private ICategoriesService jokesCategory;

        public HomeController(
            IJokesService jokes,
           ICategoriesService jokesCategory)
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
            var jokes = this.jokes
                .GetRandomJokes(3)
                .To<JokeViewModel>()
                .ToList();
            var categories = this.jokesCategory
                .GetAll()
                .To<JokeCategoryViewModel>()
                .ToList();
            var viewModel = new IndexViewModel
            {
                Jokes = jokes,
                Categories = categories
            };

            return this.View(viewModel);
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