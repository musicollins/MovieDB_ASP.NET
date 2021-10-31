using MovieDB.UI.DataSource;
using MovieDB.UI.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB.ConApp.DataAccess
{
    public class MoviesDataAccessJson : IDataAccess
    {
        public List<Movie> Movies;
        DataSource_Json _dataSource;
        public MoviesDataAccessJson(DataSource_Json dataSource)
        {
            _dataSource = dataSource;
        }
        public List<Movie> GetAll()
        {
            string jsonResponse = _dataSource.DataProviderMovie();
            Movies = JsonConvert.DeserializeObject<List<Movie>>(jsonResponse);
            return Movies;
        }
    }
}
