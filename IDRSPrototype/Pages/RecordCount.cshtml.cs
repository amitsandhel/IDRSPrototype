using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IDRSPrototype.Pages;

public class RecordCountModel : PageModel
{
    /// <summary>
    /// The user selected year.
    /// </summary>
    [BindProperty(SupportsGet = true)]
    public List<int> YearIdList { get; set; } = default!;
    public void OnGet()
    {
        Console.WriteLine("this ran");
    }
}
