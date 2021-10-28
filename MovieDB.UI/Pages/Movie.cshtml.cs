using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDB.UI.DataAccess;
using MovieDB.UI.DataSource;
using MovieDB.UI.Model;

namespace MovieDB.UI.Pages
{
    public class MovieModel : PageModel
    {
        private readonly IDataAccess _dataAccess;

        public Movie Movie{ get; set; }
        public MovieModel(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public void OnGet(int MovieId)
        {
            Movie = _dataAccess.GetById(MovieId);
        }
    }
}
