using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJouranl.Models;

namespace MyScriptureJouranl.Pages.ScripturesScaff
{
    public class EditModel : PageModel
    {
        private readonly MyScriptureJouranl.Models.MyScriptureJournalContext _context;

        public EditModel(MyScriptureJouranl.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JournalEntry Scriptures { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Scriptures = await _context.Scripture.FirstOrDefaultAsync(m => m.ID == id);

            if (Scriptures == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Scriptures).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScripturesExists(Scriptures.ID))
                {
                    return NotFound();
                }
                throw;
            }

            return RedirectToPage("./Edit");
        }

        private bool ScripturesExists(int id) => 
            _context.Scripture.Any(e => e.ID == id);
    }
}