namespace App.Web.ViewModels.Home
{
    using App.Data.Models;
    using App.Web.Infrastructure.Mapping;
    using AutoMapper;
    using Services.Web;
    public class JokeViewModel : IMapFrom<Joke>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string Category { get; set; }

        public string Url
        {
            get
            {
                IIdentifierProvider identifier = new IdentifierProvider();
                return $"/Joke/{identifier.EncodeId(this.Id)}";
            }
        }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Joke, JokeViewModel>()
            .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name));
        }
    }
}