using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDB.UI.DataAccess;
using MovieDB.UI.DataSource;
using MovieDB.UI.Model;
using System;

namespace MovieDB.UI.Pages
{
    public class MovieModel : PageModel
    {
        private readonly IDataAccess<Movie> _dataAccess;

        public Movie Movie{ get; set; }
        public MovieModel(IDataAccess<Movie> dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public void OnGet(Guid MovieId)
        {
            Movie = _dataAccess.GetById(MovieId);
        }
    }
}
