using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using MyScriptureJouranl.Models;
using System.Threading.Tasks;

namespace MyScriptureJouranl.Pages.FavScriptEntries
{
    public class CreateModel : PageModel
    {
        public const string PageName = "./index";
        private readonly MyScriptureJouranl.Models.MyScriptureJournalContext _context;

        public CreateModel(MyScriptureJouranl.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public JournalEntry JournalEntry { get; set; }

        public async Task<IAsyncResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return (System.IAsyncResult)Page();
            }

            _context.JournalEntry.Add(JournalEntry);
            await _context.SaveChangesAsync();

            return RedirectToPage(pageName: PageName);
        }
    }
}
