using MovieDB.ConApp.DataAccess;
using MovieDB.UI.Model;
using System.Collections.Generic;

namespace MovieDB.ConApp
{
    public class MoviesModel
    {
        public List<Movie> Movies;
        IDataAccess _dataAccess; 
        public MoviesModel(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
            
            //Movies = new List<Movie>();
            
            Movies = _dataAccess.GetAll();
        }

        


    }
}
