using MovieDB.UI.Model;
using System;
using System.Collections.Generic;

namespace MovieDB.UI.DataSource
{
    public interface IDataSource
    {   
        List<Movie> GetAll();
        Movie GetById(int id);
        void RemoveById(int id);
        void Update(int id);
    }
}