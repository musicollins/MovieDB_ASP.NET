using MovieDB.ConApp.DataAccess;
using MovieDB.UI.DataSource;
using MovieDB.UI.Model;

namespace MovieDB.ConApp.Views
{
    public class MovieModel
    {
        public Movie Movie;
        IDataAccess _dataAccess;
        public MovieModel(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
            //Movie = _dataAccess.GetAll().Find(m => m.MovieId == id);
        }


    }
}
