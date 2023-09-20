using System;
using System.Collections.Generic;

// Add the necessary using directive for Publication and PublicationList
using RAP.Entity;
using RAP.FakeDataSource;

namespace RAP.Controllers
{
    internal class PublicationController
    {
        List<Publication> Publications; // Corrected variable name

        public PublicationController()
        {
            Publications = PublicationList.Generate(); // Assuming PublicationList provides mock data
        }

        public void Display() // converted into LoadPublications
        {
            Publications.ForEach(Console.WriteLine);
        }
    }
}
