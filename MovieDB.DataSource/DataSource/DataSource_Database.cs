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

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
