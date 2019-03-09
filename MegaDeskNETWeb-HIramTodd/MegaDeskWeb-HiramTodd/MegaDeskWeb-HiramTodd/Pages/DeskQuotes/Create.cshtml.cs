using System.Threading.Tasks;
using MegaDeskWeb_HiramTodd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MegaDeskWeb_HiramTodd.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
            private readonly MegaDeskWeb_HiramToddContext _context;

            public CreateModel(MegaDeskWeb_HiramToddContext context)
            {
                _context = context;
            }

            public IActionResult OnGet()
        {
            return Page();
        }

        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}