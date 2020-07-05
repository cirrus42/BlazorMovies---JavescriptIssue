using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
           return new List<Movie>
            {
                new Movie{Title = "Test", ReleaseDate = new DateTime(2007, 03, 02)},
                new Movie{Title = "A Film", ReleaseDate = new DateTime(2019, 09,22)},
                new Movie { Title = "SpiderCat", ReleaseDate = new DateTime(2020, 07, 01) }
            };
        }
    }
}
