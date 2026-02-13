using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarBookingAppData;

namespace CarBookingApp.Pages.Cars
{
    public class CreateModel : PageModel
    {
        private readonly CarBookingAppData.CarBookingAppDbContext _context;

        public CreateModel(CarBookingAppData.CarBookingAppDbContext context)
        {
            _context = context;
        }


        [BindProperty]
        public Car Car { get; set; } = default!;
        public SelectList Makes { get; set; }



        public IActionResult OnGet()
        {
            Makes = new SelectList(_context.Makes.ToList(), "Id", "Name");
            return Page();
        }



        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Makes = new SelectList(_context.Makes.ToList(), "Id", "Name");
                return Page();
            }


            _context.Cars.Add(Car);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
