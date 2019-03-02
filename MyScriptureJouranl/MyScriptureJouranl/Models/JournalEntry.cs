using System;
using System.ComponentModel.DataAnnotations;

namespace MyScriptureJouranl.Models
{
    public class JournalEntry
    {
        public int ID { get; set; }

        public string Book { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        [StringLength(15, MinimumLength = 3)]
        [Required]
        public string Note { get; set; }

        public int Chapter { get; set; }

        public int Verse { get; set; }
    }
}