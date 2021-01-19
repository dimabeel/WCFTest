using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MultiServiceLibrary
{
    [ServiceContract(Name = "ICompanyGetName")]
    interface ICompanyGetHello
    {
        [OperationContract(Name ="GetName")]
        string GetHello(string name);
    }
}
