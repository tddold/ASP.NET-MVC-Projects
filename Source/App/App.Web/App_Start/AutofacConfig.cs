namespace App.Web
{
<<<<<<< HEAD
    using System;
=======
>>>>>>> 6ca5c2744ff07e9ad93c0f5627d37f5deea149bf
    using System.Data.Entity;
    using System.Reflection;
    using System.Web.Mvc;

    using Autofac;
    using Autofac.Integration.Mvc;
<<<<<<< HEAD
    using Controllers;
    using Data;
    using Data.Common;
    using Services.Data;
    using Services.Web;
=======
    using Data;
    using Data.Common;
>>>>>>> 6ca5c2744ff07e9ad93c0f5627d37f5deea149bf

    public static class AutofacConfig
    {
        public static void RegisterAutofac()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            // Register services
            RegisterServices(builder);

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private static void RegisterServices(ContainerBuilder builder)
        {
            builder.Register(x => new AppDbContext())
               .As<DbContext>()
               .InstancePerRequest();

<<<<<<< HEAD
            builder.Register(x => new HttpCacheService())
               .As<ICacheService>()
               .InstancePerRequest();

            builder.Register(x => new IdentifierProvider())
               .As<IIdentifierProvider>()
               .InstancePerRequest();

            var servicesAssembly = Assembly.GetAssembly(typeof(IJokesService));
            builder.RegisterAssemblyTypes(servicesAssembly).AsImplementedInterfaces();

            builder.RegisterGeneric(typeof(DbRepository<>))
               .As(typeof(IDbRepository<>))
               .InstancePerRequest();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AssignableTo<BaseController>()
                .PropertiesAutowired();
=======
            builder.RegisterGeneric(typeof(DbRepository<>))
                .As(typeof(IDbRepository<>))
                .InstancePerRequest();

            // builder.Register(x => new HttpCacheService())
            //    .As<ICacheService>()
            //    .InstancePerRequest();
            // builder.Register(x => new IdentifierProvider())
            //    .As<IIdentifierProvider>()
            //    .InstancePerRequest();

            // var servicesAssembly = Assembly.GetAssembly(typeof(IJokesService));
            // builder.RegisterAssemblyTypes(servicesAssembly).AsImplementedInterfaces();



            // builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .AssignableTo<BaseController>().PropertiesAutowired();
>>>>>>> 6ca5c2744ff07e9ad93c0f5627d37f5deea149bf
        }
    }
}