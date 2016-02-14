namespace App.Web.ViewModels.Home
{
    using App.Data.Models;
    using App.Web.Infrastructure.Mapping;

    public class JokeCategoryViewModel: IMapFrom<JokeCategory>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}