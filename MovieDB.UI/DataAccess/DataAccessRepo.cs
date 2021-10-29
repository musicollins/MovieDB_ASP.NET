using MovieDB.UI.DataSource;
using System.Collections.Generic;

namespace MovieDB.UI.DataAccess
{
    public abstract class DataAccessRepo<T> : IDataAccess<T> where T : class
    {
        protected readonly DataSource_Json _dataSource;

        public DataAccessRepo(DataSource_Json dataSource)
        {
            _dataSource = dataSource;
        }
        public abstract List<T> GetAll();

        public abstract T GetById(int id);
    }
}
