namespace App.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(AppDbContext context)
        {
<<<<<<< HEAD
            
=======
           
>>>>>>> 6ca5c2744ff07e9ad93c0f5627d37f5deea149bf
        }
    }
}
