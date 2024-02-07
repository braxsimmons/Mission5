using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mission5.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

namespace Mission5.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            // Initialization code if needed
        }
    }
}