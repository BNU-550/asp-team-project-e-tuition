using E_Tuition.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Tuition.Pages
{
    public class TutorSignInModel : PageModel
    {
        [BindProperty]
        public string Message { get; set; }

        [BindProperty]
        public Tutor Tutor { get; set; }
        public void OnGet()
        {
        }
    }
}
