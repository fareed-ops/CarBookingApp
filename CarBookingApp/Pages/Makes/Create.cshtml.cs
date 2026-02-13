using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarBookingAppData;

namespace CarBookingApp.Pages.Makes
{
    public class CreateModel : PageModel
    {
        private readonly CarBookingAppDbContext _context;

        public CreateModel(CarBookingAppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Make Make { get; set; } = default!;

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Makes.Add(Make);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
