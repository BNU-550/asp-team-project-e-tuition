using E_Tuition.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Tuition.Pages
{
    public class TutorSignUpModel : PageModel
    {
        public string Message { get; set; }

        [BindProperty]
        public Tutor Tutor { get; set; }
        public void OnGet()
        {
        }
    }
}
