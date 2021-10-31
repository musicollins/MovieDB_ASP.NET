using System;
using System.Collections.Generic;

namespace MovieDB.UI.DataAccess
{
    public interface IDataAccess<T> 
    {
        List<T> GetAll();
        T GetById(Guid id);
    }
}