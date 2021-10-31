using MovieDB.UI.DataSource;
using MovieDB.UI.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieDB.UI.DataAccess
{
    public class MoviesDataAccess : IDataAccess<Movie>
    {
        private readonly DataSource_Json _dataSource;

        public MoviesDataAccess(DataSource_Json dataSource)
        {
            _dataSource = dataSource;
            var jsonResponse = _dataSource.DataProviderMovie();
            Movies = JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
        }
        public List<Movie> Movies { get; set; }

        public List<Movie> GetAll()
        {

            return Movies;
        }

        

        public Movie GetById(Guid id)
        {
            return Movies.SingleOrDefault(m => m.MovieId == id);
        }


    }
}
