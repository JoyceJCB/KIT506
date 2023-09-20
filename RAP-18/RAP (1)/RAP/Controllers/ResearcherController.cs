using RAP.Entity;
using System.Collections.Generic;
using System;
using System.Linq;
using RAP.FakeDataSource;
public class ResearcherController
{
    List<Researcher> Researchers;
    List<Publication> Publications;

    public ResearcherController()
    {
        Researchers = ResearcherList.Generate();
        Publications = PublicationList.Generate();
    }

    public void Display()
    {
        Researchers.ForEach(Console.WriteLine);
    }

    public void DisplayPublicationsForResearcher(int researcherId)
    {
        Researcher researcher = Researchers.Find(r => r.id == researcherId); // LINQ 

        if (researcher != null)
        {
            Console.WriteLine($"Researcher Details (ID: {researcher.id}):");
            Console.WriteLine($"Given Name: {researcher.GivenName}");
            Console.WriteLine($"Family Name: {researcher.FamilyName}");
            Console.WriteLine($"Title: {researcher.Title}");
            Console.WriteLine($"School: {researcher.School}");
            Console.WriteLine($"Campus: {researcher.Campus}");
            Console.WriteLine($"Email: {researcher.Email}");
            Console.WriteLine($"Photo: {researcher.Photo}");
            Console.WriteLine($"Employment Level: {researcher.EmploymentLevel}");

            Console.WriteLine($"\nPublications for Researcher {researcher.GivenName} {researcher.FamilyName} (ID: {researcher.id}):");

            // Find publications associated with the researcher
            List<Publication> researcherPublications = Publications.Where(p => p.Authors.Contains(researcher.GivenName) && p.Authors.Contains(researcher.FamilyName)).ToList();

            if (researcherPublications.Count > 0)
            {
                foreach (Publication publication in researcherPublications) // LINQ
                {
                    Console.WriteLine($"DOI: {publication.DOI}, Title: {publication.Title}, Year: {publication.Year}, Ranking: {publication.Ranking}, Age: {publication.Age}");
                }
            }
            else
            {
                Console.WriteLine($"No publications found for Researcher {researcher.GivenName} {researcher.FamilyName} (ID: {researcher.id}).");
            }
        }
        else
        {
            Console.WriteLine($"Researcher with ID {researcherId} not found.");
        }
    }
}
