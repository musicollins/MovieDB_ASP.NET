using MovieDB.Model.Model;
using MovieDB.UI.DataSource;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDB.UI.DataAccess
{
    public class DataAccessKey : DataAccessRepo<Key>
    {
        public List<Key> Keys{ get; set; }
        public DataAccessKey(DataSource_Json dataSource) : base(dataSource)
        {
        }

        public override List<Key> GetAll()
        {
            var jsonResponse = _dataSource.DataProviderKeys();
            Keys = JsonConvert.DeserializeObject<List<Key>>(jsonResponse);
            return Keys;
        }

        public override Key GetById(int id)
        {
            var jsonResponse = _dataSource.DataProviderMovie();
            Keys = JsonConvert.DeserializeObject<List<Key>>(jsonResponse);
            return Keys.SingleOrDefault(m => m.key == id);
        }
    }
}
