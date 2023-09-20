using System;
using System.Collections.Generic;
using System.Linq;
using RAP.Entity;

namespace RAP.FakeDataSource
{
    class PublicationList
    {
        public static List<Publication> Generate()
        {
            // List of fake publications
            return new List<Publication>()
            {
                new Publication{
                    DOI = "abcd1",
                    Title = "Publication 1",
                    Authors = "Jane Jonas",
                    Year = new DateTime(2022, 1, 1),
                    Ranking = 1,
                    Type = Publication.PublicationType.Journal,
                    Cite = "Citation 1",
                    Age = 1
                },
                new Publication
                {
                    DOI = "abcd2",
                    Title = "Publication 2",
                    Authors = "Sonam Yuden",
                    Year = new DateTime(2021, 1, 1),
                    Ranking = 2,
                    Type = Publication.PublicationType.Conference,
                    Cite = "Citation 2",
                    Age = 2
                },
                                new Publication
                {
                    DOI = "abcd2",
                    Title = "Hello barbie lets go party",
                    Authors = "Sonam Yuden",
                    Year = new DateTime(2021, 1, 1),
                    Ranking = 2,
                    Type = Publication.PublicationType.Conference,
                    Cite = "Citation 2",
                    Age = 2
                }
            };

            
        }
    }
}
