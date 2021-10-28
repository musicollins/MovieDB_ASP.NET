using MovieDB.UI.Model;
using System.Collections.Generic;

namespace MovieDB.ConApp.DataAccess
{
    public interface IDataAccess
    {
        List<Movie> GetAll();
    }
}