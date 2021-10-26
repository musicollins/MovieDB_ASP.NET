using MovieDB.UI.Model;
using System.Collections.Generic;

namespace MovieDB.UI.DataSource
{
    public class DataSource_Database : IDataSource
    {
        public List<Movie> GetAll()
        {
            return new List<Movie>();
        }
    }
}
