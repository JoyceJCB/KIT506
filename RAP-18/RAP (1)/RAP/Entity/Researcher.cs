using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace RAP.Entity
{
    public class Researcher
    {
        public int id { get; set; }
        public string GivenName { get; set; }

        public string FamilyName { get; set; }
        public string Title { get; set; }
        public string School { get; set; }
        public string Campus { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public EmployeeLevel EmploymentLevel { get; set; }

        public List<Publication> Publications { get; set; }
        public override string ToString()
        {
            return  id + GivenName + '\t' + FamilyName + '\t'  + Title + '\t' + School + '\t' + Campus + '\t' + Email + '\t' + Photo + '\t' + EmploymentLevel;
        }


    }

    public enum Title
    {
        Dr, Mr, Mrs
    }

    public enum EmployeeLevel
    {
       A, B, C, D, E, Student
    }
}
