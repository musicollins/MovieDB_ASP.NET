using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDB.UI.DataAccess;
using MovieDB.UI.Model;
using System.Collections.Generic;

namespace MovieDB.UI.Pages
{
    public class MoviesModel : PageModel
    {
        private readonly IDataAccess _dataSource;

        public List<Movie> Movies { get; set; }


        public MoviesModel(IDataAccess dataSource)
        {
            _dataSource = dataSource;
            Movies = _dataSource.GetAllMovies();
        }

        public void OnGet()
        {

        }
    }



}
