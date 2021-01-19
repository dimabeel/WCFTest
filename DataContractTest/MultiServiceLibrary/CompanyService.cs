using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiServiceLibrary
{
    public class CompanyService : ICompanyGetDate, ICompanyGetPerson
    {
        public string GetDate() => DateTime.Now.ToString();

        public Person GetPerson(string firstName, string lastName)
        {
            return new Person() { FirstName = firstName, LastName = lastName };
        }
    }
}
