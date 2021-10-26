using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDB.UI.DataSource;
using MovieDB.UI.Model;
using System.Linq;

namespace MovieDB.UI.Pages
{
    public class MovieModel : PageModel
    {
        private readonly IDataSource dataSource;

        public Movie Movie{ get; set; }
        public MovieModel(IDataSource dataSource)
        {
            this.dataSource = dataSource;
            Movie = dataSource.GetAll().FirstOrDefault(m => m.Title.Equals("The Shining"));


        }
        public void OnGet()
        {

        }
    }
}
