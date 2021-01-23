using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        Car GetCar(int id);

        void SaveCar(Car car);
    }
}
