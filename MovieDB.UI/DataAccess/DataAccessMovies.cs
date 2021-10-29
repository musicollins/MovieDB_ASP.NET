using MovieDB.UI.DataSource;
using MovieDB.UI.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace MovieDB.UI.DataAccess
{
    public class DataAccessMovies : DataAccessRepo<Movie>
    {
        public DataAccessMovies(DataSource_Json dataSource) : base(dataSource)
        {
        }
        public List<Movie> Movies { get; set; }

        public override List<Movie> GetAll()
        {
            var jsonResponse = _dataSource.DataProviderMovie();
            Movies = JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
            return Movies;
        }

        

        public override Movie GetById(int id)
        {
            var jsonResponse = _dataSource.DataProviderMovie();
            Movies = JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
            return Movies.SingleOrDefault(m => m.MovieId == id);
        }


    }
}
