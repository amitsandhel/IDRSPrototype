using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IDRSPrototype.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public string YearSelect { get; set; }
        public IActionResult OnPostSubmit(string tabType, string dataType, string yearSelect, string txtname)
        {

            // Get the selected value from the form
            //SelectedValue = Request.Form["myDropdown"];
            var ans = Request.Form["txtname"];
            YearSelect = Request.Form["yearSelect"];
            return Redirect("/Privacy");
        }
    }
}