using System.Linq;

namespace CarService
{
    public class CarService : ICarService
    {
        public Car GetCar(int id)
        {
            using(CarContext cars = new CarContext())
            {
                var foundCar = cars.Cars
                    .Where(x => x.Id == id).FirstOrDefault();
                if (foundCar != null)
                {
                    if (foundCar.EngineType == EngineType.Electric)
                    {
                        return (ElectricCar)foundCar;
                    }
                    else
                    {
                        return (OilFuelCar)foundCar;
                    }
                }

                return null;
            }
        }

        public void SaveCar(Car car)
        {
            using(CarContext cars = new CarContext())
            {
                if (car is ElectricCar s)
                {
                    string query = "INSERT into Car (Id, Mark, Model, " +
                        "YearOfProduction, EngineType, RangeInKilometers," +
                        "EngineСС, EnginePower, Discriminator)" +
                        " values" +
                        $"({s.Id}, \'{s.Mark}\', \'{s.Model}\', " +
                        $"\'{s.YearOfProduction}\', {(int)s.EngineType}, " +
                        $"{s.RangeInKilometers}, 0, 0, \'ElectricCar\')";
                    cars.Database.ExecuteSqlCommand(query);
                }
                else if (car is OilFuelCar o)
                {
                    string query = "INSERT into Car (Id, Mark, Model, " +
                        "YearOfProduction, EngineType, RangeInKilometers," +
                        "EngineСС, EnginePower, Discriminator)" +
                        " values" +
                        $"({o.Id}, \'{o.Mark}\', \'{o.Model}\', " +
                        $"\'{o.YearOfProduction}\', {(int)o.EngineType}, " +
                        $"0, {o.EngineСС}, {o.EnginePower}, \'OilFuelCar\')";
                    cars.Database.ExecuteSqlCommand(query);
                }
            }
        }
    }
}
