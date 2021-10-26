using MovieDB.UI.Model;
using System.Collections.Generic;

namespace MovieDB.UI.DataSource
{
    public interface IDataSource
    {   
        List<Movie> GetAll();
    }
}