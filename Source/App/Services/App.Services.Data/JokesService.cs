namespace App.Services.Data
{
    using System;
    using System.Linq;

    using App.Data.Common;
    using App.Data.Models;
    // using App.Services.Web;

    public class JokesService : IJokesService
    {
        private readonly IDbRepository<Joke> jokes;
        // private readonly IIdentifierProvider identifierProvider;


        // IIdentifierProvider identifierProvider
        public JokesService(IDbRepository<Joke> jokes)
        {
            this.jokes = jokes;
           //  this.identifierProvider = identifierProvider;
        }

        public Joke GetById(string id)
        {
            throw new NotImplementedException();
        }

        //public Joke GetById(string id)
        //{
        //    var intId = this.identifierProvider.DecodeId(id);
        //    var joke = this.jokes.GetById(intId);
        //    return joke;
        //}

        public IQueryable<Joke> GetRandomJokes(int count)
        {
            return this.jokes.All().OrderBy(x => Guid.NewGuid()).Take(count);
        }
    }
}
