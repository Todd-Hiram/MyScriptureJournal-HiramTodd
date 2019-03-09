using Microsoft.EntityFrameworkCore;

namespace MegaDeskWeb_HiramTodd.Models
{
    public class MegaDeskWeb_HiramToddContext : DbContext
    {
        public MegaDeskWeb_HiramToddContext (DbContextOptions<MegaDeskWeb_HiramToddContext> options) 
            : base(options)
        {

        }

        public object DeskQuote { get; internal set; }
    }

}
