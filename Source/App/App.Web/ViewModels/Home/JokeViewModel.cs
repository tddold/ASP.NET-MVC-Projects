namespace App.Web.ViewModels.Home
{
    using System;
    using App.Data.Models;
    using App.Web.Infrastructure.Mapping;
    using AutoMapper;

    public class JokeViewModel : IMapFrom<Joke>, IHaveCustomMappings
    {
        public string Content { get; set; }

        public string Category { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Joke, JokeViewModel>()
            .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name));
        }
    }
}