using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDB.UI.DataAccess;
using MovieDB.UI.Model;
using System.Collections.Generic;

namespace MovieDB.UI.Pages
{
    public class MoviesModel : PageModel
    {
        private readonly IDataAccess<Movie> _dataAccess;

        public List<Movie> Movies { get; set; }


        public MoviesModel(IDataAccess<Movie> dataAccess)
        {
            _dataAccess = dataAccess;
            Movies = _dataAccess.GetAll();
        }

        public void OnGet()
        {

        }
    }



}
