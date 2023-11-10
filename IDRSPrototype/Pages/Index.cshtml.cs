using ClassLibraryDatabase1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net;
//using ClassLibraryDatabase1.Data;

namespace IDRSPrototype.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        // Context instance
        private readonly ClassLibraryDatabase1.Data.Newttsadmv1Context _context;

        // Constructor of class
        public IndexModel(ILogger<IndexModel> logger, ClassLibraryDatabase1.Data.Newttsadmv1Context context)
        {
            _logger = logger;
            _context = context;
        }

        public ClassLibraryDatabase1.IndexViewModel refClass = new ClassLibraryDatabase1.IndexViewModel();

        // List of all TTS survey years.
        public IEnumerable<SelectListItem> YearsList { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public List<SelectListItem> Tabulations { get; set; }

        public async Task OnGet()
        {
            if(_context.Years is not null )
            {
                // Get the years of all the tts survey.
                List<ClassLibraryDatabase1.Models.Year> years = refClass.GetTTSYears(_context);

                // convert the list of year into a selectlist to display to the dropdown
                YearsList = years.Select(year => new SelectListItem
                {
                    Value = year.Id.ToString(),
                    Text = year.Year1.ToString()
                }).ToList();
            }
        }

        public IActionResult OnPostSubmit(string tabType, string dataType, int[] Years, string txtname)
        {
            // Get the selected value from the form
            var ans = Request.Form["txtname"];
            var years = Years;
            return Redirect("/Privacy");
        }
    }
}