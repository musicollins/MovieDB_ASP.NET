using MovieDB.UI.DataSource;
using MovieDB.UI.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDB.UI.DataAccess
{
    public class DataAccessAPI : IDataAccess
    {
        private readonly DataSource_Json _dataSource;
        public List<Movie> Movies { get; set; }
        public DataAccessAPI(DataSource_Json dataSource)
        {
            _dataSource = dataSource;
        }

        public List<Movie> GetAllMovies()
        {
            var jsonResponse = _dataSource.DataProvider();
            Movies = JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
            return Movies;
        }

        public Movie GetById(int id)
        {
            var jsonResponse = _dataSource.DataProvider();
            Movies = JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
            return Movies.SingleOrDefault(m => m.MovieId == id);
        }
    }
}
