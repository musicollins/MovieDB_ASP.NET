using System.IO;

namespace MovieDB.UI.DataSource
{
    public class DataSource_Json
    {
        public string DataProviderMovie()
        {
            var json = File.ReadAllText(@"C:\Users\Demiurgos\source\repos\MovieDB\MovieDB.DataSource\movies.json");
            return json;
        }

        public string DataProviderKeys()
        {
            var json = File.ReadAllText(@"C:\Users\Demiurgos\source\repos\MovieDB\MovieDB.DataSource\keys.json");
            return json;
        }

        public string DataProviderProducts()
        {
            var json = File.ReadAllText(@"C:\Users\Demiurgos\source\repos\MovieDB\MovieDB.DataSource\products.json");
            return json;
        }

    }
}
