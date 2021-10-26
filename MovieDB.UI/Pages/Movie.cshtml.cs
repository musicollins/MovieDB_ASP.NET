using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDB.UI.DataSource;
using MovieDB.UI.Model;

namespace MovieDB.UI.Pages
{
    public class MovieModel : PageModel
    {
        public Movie Movie{ get; set; }
        public MovieModel()
        {
            IDataSource dataSource = new DataSource_Mockdata();
            dataSource.GetAll();
        }
        public void OnGet()
        {

        }
    }
}
