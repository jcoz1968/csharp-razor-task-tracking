using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class CreateTaskModel : PageModel
    {
        private ApplicationDbContext _context;

        [BindProperty]
        public Task NewTask { get; set; }

        public CreateTaskModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _context.Tasks.Add(new Task());
            _context.SaveChanges();
            return RedirectToPage("Index");

        }
    }
}
