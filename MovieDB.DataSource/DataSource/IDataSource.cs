using MovieDB.UI.Model;
using System;
using System.Collections.Generic;

namespace MovieDB.UI.DataSource
{
    public interface IDataSource
    {   
        List<Movie> GetAll();
        Movie GetById(Guid id);
        void RemoveById(Guid id);
        void Update(Guid id);
    }
}