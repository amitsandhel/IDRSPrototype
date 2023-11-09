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

        // List of all TTS survey years.
        public List<SelectListItem> YearsList { get; set; }

        public async Task OnGet()
        {
            if(_context.Years is not null )
            {
                YearsList = _context.Years.Select(x => 
                                                new SelectListItem
                                                {
                                                    Text = x.Year1.ToString(),
                                                    Value = x.Id.ToString()
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