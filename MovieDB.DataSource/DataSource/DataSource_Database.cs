using MovieDB.UI.Model;
using System;
using System.Collections.Generic;

namespace MovieDB.UI.DataSource
{
    public class DataSource_Database : IDataSource
    {
        public List<Movie> GetAll()
        {
            return new List<Movie>();
        }

        public Movie GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
