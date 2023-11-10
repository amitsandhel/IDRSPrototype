using ClassLibraryDatabase1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net;

namespace IDRSPrototype.Pages;

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
    public IEnumerable<SelectListItem> YearsList { get; set; } = default!;
    // List all Categories
    public IEnumerable<SelectListItem> Categories { get; set; } = default!;
    // List all Tabulations
    public IEnumerable<SelectListItem> Tabulations { get; set; } = default!;

    public async Task OnGet()
    {
        if(_context.Years is not null )
        {

            YearsList = refClass.GetTTSYears(_context).Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Year1.ToString()
            });

            // Get the tts tabulations.
            Tabulations = refClass.GetTTSTabulations(_context).Select(x=> new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name.ToString()
            }).ToList();

            // Get the categories.
            Categories = refClass.GetTTSCategories(_context).Select(x=> new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name.ToString()
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