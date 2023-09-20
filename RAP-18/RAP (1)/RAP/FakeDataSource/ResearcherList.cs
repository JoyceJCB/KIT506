using RAP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAP.FakeDataSource
{
    class ResearcherList
    {
        public static List<Researcher> Generate()
        {
            return new List<Researcher>() {

                new Researcher {id = 1, GivenName = "Jane", FamilyName = "Jonas", Title= "Prof", School="ABC", Campus="XYZ", Email="Abc@test.com", Photo="", EmploymentLevel = EmployeeLevel.Student},
                new Researcher { id = 2, GivenName = "Sonam", FamilyName = "Yuden", Title= "Student", School="ABC", Campus="XYZ", Email="Abc@test.com", Photo="", EmploymentLevel = EmployeeLevel.Student },
                 new Researcher { id = 3, GivenName = "Bijita", FamilyName = "Lama", Title= "Staff", School="ABC", Campus="XYZ", Email="Abc@test.com", Photo="", EmploymentLevel = EmployeeLevel.C }

            };
        }
    }
}