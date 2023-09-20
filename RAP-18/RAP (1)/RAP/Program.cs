using RAP.Controllers;
using RAP.Entity;
using System;

namespace program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            ResearcherController researcherController1 = new ResearcherController();

            researcherController1.Display();

            // Call DisplayPublicationsForResearcher for Researcher with ID 1
            // researcherController1.DisplayPublicationsForResearcher(2);
            Console.Write("Enter a researcher ID: ");
            if (int.TryParse(Console.ReadLine(), out int researcherId))
            {
                researcherController1.DisplayPublicationsForResearcher(researcherId);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer researcher ID.");
            }
        }
    }
}
