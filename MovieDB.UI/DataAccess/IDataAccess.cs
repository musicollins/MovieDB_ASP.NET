using MovieDB.UI.Model;
using System.Collections.Generic;

namespace MovieDB.UI.DataAccess
{
    public interface IDataAccess
    {
        List<Movie> GetAllMovies();
        Movie GetById(int id);
    }
}