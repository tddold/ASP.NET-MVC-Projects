namespace App.Web.Controllers
{
<<<<<<< HEAD
    using System.Linq;
    using System.Web.Mvc;
    using Web.Infrastructure.Mapping;
    using ViewModels.Home;
    using Services.Data;
    using Services.Web;
=======
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using Data;
    using Data.Common;
    using Data.Models;
>>>>>>> 6ca5c2744ff07e9ad93c0f5627d37f5deea149bf

    public class HomeController : BaseController
    {
<<<<<<< HEAD
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
            var categories =
                this.Cache.Get(
                    "categories", () => this.jokesCategory.GetAll().To<JokeCategoryViewModel>().ToList(),
                    30 * 60);
            var viewModel = new IndexViewModel
            {
                Jokes = jokes,
                Categories = categories
            };

            return this.View(viewModel);
=======
        private IDbRepository<Product> products;
        private IDbRepository<Category> categories;

        public HomeController(
            IDbRepository<Product> products,
            IDbRepository<Category> categories)
        {
            this.products = products;
            this.categories = categories;
        }

        public ActionResult Index()
        {
            var products = this.products.All()
                 .OrderBy(x => Guid.NewGuid())
                 .Take(3);

            return this.View();
>>>>>>> 6ca5c2744ff07e9ad93c0f5627d37f5deea149bf
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