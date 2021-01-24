using System.Data.Entity;

namespace CarService
{
    class CarContext : DbContext
    {
        public CarContext() : base("name=CarContext")
        {
            Database
                .SetInitializer(new CreateDatabaseIfNotExists<CarContext>());
        }

        public DbSet<Car> Cars { get; set; }        
    }
}
