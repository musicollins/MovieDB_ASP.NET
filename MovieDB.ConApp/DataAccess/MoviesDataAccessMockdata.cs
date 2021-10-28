using MovieDB.UI.DataSource;
using MovieDB.UI.Model;
using System.Collections.Generic;

namespace MovieDB.ConApp.DataAccess
{
    public class MoviesDataAccessMockdata : IDataAccess
    {
        List<Movie> Movies;
        DataSource_Mockdata _dataSource;
        public MoviesDataAccessMockdata(DataSource_Mockdata dataSource)
        {
            _dataSource = dataSource;
        }

        public List<Movie> GetAll()
        {
            Movies = _dataSource.DataProvider();

            return Movies;
        }
    }
}
