using RAP.Entity;
using System.Collections.Generic;
using RAP.FakeDataSource;

public class DatabaseAdapter
{
    
    public List<Researcher> GetResearchersFromDatabase()
    {
        // Generate fake data or return data from a fake source
        return ResearcherList.Generate(); 
    }

   
}
