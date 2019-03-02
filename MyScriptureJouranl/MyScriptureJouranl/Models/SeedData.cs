using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MyScriptureJouranl.Models;
using System.Linq;

namespace FavScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize (IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(serviceProvider.GetRequiredService<
            DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Scan the scripture entries
                if (context.JournalEntry.Any())
                {
                    return; // DB has been seeded
                }

                context.JournalEntry.AddRange(
                    new JournalEntry
                    {
                        Book = "Luke",
                        Chapter = 6,
                        Verse = 23,
                        DateAdded = DateTime.Parse("02/24/2019"),
                        Read = "Rejoice ye in that day, and leap for joy: for, behold, your reward is great in heaven: for in the like manner did their fathers unto the prophets."
                    },
                                        new JournalEntry
                                        {
                                            Book = "Ether",
                                            Chapter = 3,
                                            Verse = 20,
                                            DateAdded = DateTime.Parse("02/12/2019"),
                                            Read = "Wherefore, having this perfect knowledge of God, he could not be kept from within the veil; therefore he saw Jesus; and he did minister unto him."
                                        },
                                                        new JournalEntry
                                                        {
                                                            Book = "Ether",
                                                            Chapter = 3,
                                                            Verse = 19,
                                                            DateAdded = DateTime.Parse("02/12/2019"),
                                                            Read = "And because of the knowledge of this man he could not be kept from beholding within the veil; and he saw the finger of Jesus, which, when he saw, he fell with fear; for he knew that it was the finger of the Lord; and he had faith no longer, for he knew, nothing doubting."
                                                        },
                                                                            new JournalEntry
                                                                            {
                                                                                Book = "Mormon",
                                                                                Chapter = 9,
                                                                                Verse = 19,
                                                                                DateAdded = DateTime.Parse("01/31/2019"),
                                                                                Read = "Wherefore, having this perfect knowledge of God, he could not be kept from within the veil; therefore he saw Jesus; and he did minister unto him."
                                                                            },
                                                                                                new JournalEntry
                                                                                                {
                                                                                                    Book = "Mormon",
                                                                                                    Chapter = 8,
                                                                                                    Verse = 39,
                                                                                                    DateAdded = DateTime.Parse("01/24/2019"),
                                                                                                    Read = "Why do ye adorn yourselves with that which hath no life, and yet suffer the hungry, and the needy, and the naked, and the sick and the afflicted to pass by you, and notice them not?"
                                                                                                },
                                                                                                                    new JournalEntry
                                                                                                                    {
                                                                                                                        Book = "3 Nephi 17:4",
                                                                                                                        Chapter = 17,
                                                                                                                        Verse = 4,
                                                                                                                        DateAdded = DateTime.Parse("10/03/2018"),
                                                                                                                        Read = "Rejoice ye in that day, and leap for joy: for, behold, your reward is great in heaven: for in the like manner did their fathers unto the prophets."
                                                                                                                    }

                    );

                context.SaveChanges();
            }
        }

        //private static IDisposable MyScriptureJournalContext(DbContextOptions<MyScriptureJournalContext> dbContextOptions)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
