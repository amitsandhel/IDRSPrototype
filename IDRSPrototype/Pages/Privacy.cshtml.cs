using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClassLibraryDatabase1;

namespace IDRSPrototype.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        PrivacyViewModel instance = new();

        [BindProperty]
        public string Message { get; set; } = string.Empty;
        
        public void OnGet()
        {
            Message = instance.PrintString();
            //Message = "Hello world";
        }
    }
}