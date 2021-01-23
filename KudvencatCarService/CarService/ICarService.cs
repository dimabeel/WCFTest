using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarService
{
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        Car GetCar(int id);

        [OperationContract]
        void SaveCar(Car car);
    }
}
