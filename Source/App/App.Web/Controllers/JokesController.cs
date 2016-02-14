namespace App.Web.Controllers
{
    using System.Web.Mvc;

    using App.Services.Data;
    using App.Web.Infrastructure.Mapping;
    using App.Web.ViewModels.Home;

    public class JokesController : BaseController
    {

        private readonly IJokesService jokes;

        public JokesController(
            IJokesService jokes)
        {
            this.jokes = jokes;
        }

        public ActionResult ById(string id)
        {
            var joke = this.jokes.GetById(id);
            var viewModel = AutoMapperConfig.Configuration.CreateMapper().Map<JokeViewModel>(joke);
            return this.View(viewModel);
        }
    }
}