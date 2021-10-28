using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDB.UI.DataSource;
using MovieDB.UI.Model;
using System;
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
        }
        public void OnGet(Guid MovieId)
        {
            Movie = dataSource.GetById(MovieId);
        }
    }
}
