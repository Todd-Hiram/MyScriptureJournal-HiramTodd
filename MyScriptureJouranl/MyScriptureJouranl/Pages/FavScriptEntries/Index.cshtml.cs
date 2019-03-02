using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyScriptureJouranl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MyScriptureJouranl.Pages.FavScriptEntries
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJouranl.Models.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJouranl.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<JournalEntry> Scripture { get; set; }

        [BindProperty(SupportsGet = true)]
        public IList<JournalEntry> JournalEntries { get; set; }
        public List<JournalEntry> FavScriptEntries { get; set; }
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            FavScriptEntries = await _context.Scripture.ToListAsync();
            var scriptures = from m in _context.Scripture
                             select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchString));
            }

            FavScriptEntries = await scriptures.ToListAsync();
        }
    }
}
