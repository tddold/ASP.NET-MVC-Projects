namespace App.Web
{
    using System.Data.Entity;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using Data;
    using Data.Migrations;

    using Data;
    using Data.Migrations;
    using Infrastructure.Mapping;
    using System.Reflection;
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Configuration>());

<<<<<<< HEAD
            //using (var db = new AppDbContext())
            //{
            //    db.Database.Initialize(true);
            //}

=======
>>>>>>> 6ca5c2744ff07e9ad93c0f5627d37f5deea149bf
            AutofacConfig.RegisterAutofac();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var autoMapperConfig = new AutoMapperConfig();
            autoMapperConfig.Execute(Assembly.GetExecutingAssembly());
        }
    }
}
