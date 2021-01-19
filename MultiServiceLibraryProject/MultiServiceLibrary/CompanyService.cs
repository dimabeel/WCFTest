using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiServiceLibrary
{
    public class CompanyService : ICompanyGetDate, ICompanyGetHello
    {
        public string GetDate() => DateTime.Now.ToString();

        public string GetHello(string name) => $"Hello {name}";
    }
}
