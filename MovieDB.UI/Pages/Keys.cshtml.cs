using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDB.Model.Model;
using MovieDB.UI.DataAccess;
using System.Collections.Generic;

namespace MovieDB.UI.Pages
{
    public class KeysModel : PageModel
    {
        private readonly DataAccessRepo<Key> dataAccess;
        public List<Key> Keys { get; set; }
        public KeysModel(DataAccessRepo<Key> dataAccess)
        {
            this.dataAccess = dataAccess;
            Keys = this.dataAccess.GetAll();
        }
        public void OnGet()
        {
        }
    }
}
