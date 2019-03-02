using Microsoft.EntityFrameworkCore;

namespace MyScriptureJouranl.Models
{
    public class MyScriptureJournalContext : DbContext
        {
            public MyScriptureJournalContext (DbContextOptions<MyScriptureJournalContext> options) : base(options)
            {
            }

        public DbSet<MyScriptureJouranl.Models.JournalEntry> JournalEntry { get; set; }
        public object Movie { get; internal set; }
    }
}