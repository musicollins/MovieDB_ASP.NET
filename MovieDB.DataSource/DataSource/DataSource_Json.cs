using System.IO;

namespace MovieDB.UI.DataSource
{
    public class DataSource_Json
    {
        public string DataProvider()
        {
            var json = File.ReadAllText(@"C:\Users\Demiurgos\source\repos\MovieDB\MovieDB.DataSource\movies.json");
            return json;
        }

    }
}
