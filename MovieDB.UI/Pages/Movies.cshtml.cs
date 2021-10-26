using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDB.UI.DataSource;
using MovieDB.UI.Model;
using System.Collections.Generic;

namespace MovieDB.UI.Pages
{
    public class MoviesModel : PageModel
    {
        private readonly IDataSource _dataSource;

        public List<Movie> Movies { get; set; }
        public string Name { get; set; }

        public MoviesModel(IDataSource dataSource)
        {
            _dataSource = dataSource;
            Movies = _dataSource.GetAll();
        }

        public void OnGet()
        {
        }
    }



}
