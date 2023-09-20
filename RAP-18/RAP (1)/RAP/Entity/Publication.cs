using System;

namespace RAP.Entity
{
    public class Publication
    {
        public string DOI { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public DateTime Year { get; set; }
        public int Ranking { get; set; }
        public PublicationType Type { get; set; }
        public string Cite { get; set; }
        public DateTime AvailableDate { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return DOI + '\t' + Title + '\t' + Authors + '\t' + Year + '\t' + Ranking + '\t' + Type + '\t' + Cite + '\t' + Age;
        }

        public enum PublicationType
        {
            Conference, Journal, Other
        }
    }
}
