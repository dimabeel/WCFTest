using System.Collections.Generic;
using System.Linq;

namespace EmployeeService
{
    public class CarService : ICarService
    {
        public Car GetCar(int id)
        {
            using(CarContext cars = new CarContext())
            {
                var idParam =
                    new System.Data.SqlClient.SqlParameter("@Id", id);
                var foundCar =
                    cars.Database.SqlQuery<Car>("GetCar @Id", idParam);
                return foundCar.FirstOrDefault();
            }
        }

        public void SaveCar(Car car)
        {
            using(CarContext cars = new CarContext())
            {
                var parameters =
                    new List<System.Data.SqlClient.SqlParameter>();

                var idParam = new System.Data.SqlClient
                    .SqlParameter("@Id", car.Id);
                parameters.Add(idParam);

                var markParam = new System.Data.SqlClient
                    .SqlParameter("@Mark", car.Mark);
                parameters.Add(markParam);

                var modelParam = new System.Data.SqlClient
                    .SqlParameter("@Model", car.Model);
                parameters.Add(modelParam);

                var YearOfProductionParam = new System.Data.SqlClient
                    .SqlParameter("@YearOfProduction", car.YearOfProduction);
                parameters.Add(YearOfProductionParam);

                var foundCar = cars.Database
                    .SqlQuery<Car>(
                    "SaveCar @Id @Mark @Model @YearOfProduction", parameters);
            }
        }
    }
}
