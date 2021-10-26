using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MovieDB.UI.Pages
{

    //Code-Behind
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public string Actor { get; set; }
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            Actor = "Ralph";
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
