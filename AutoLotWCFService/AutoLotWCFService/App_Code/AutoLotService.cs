using System.Collections.Generic;
using AutoLotDAL.Models;
using AutoLotDAL.Repos;
using AutoMapper;

public class AutoLotService : IAutoLotService
{
    public AutoLotService()
    {
    }

    public void InsertCar(string make, string color, string petname)
    {
        var repo = new InventoryRepo();
        repo.Add(new Inventory() 
        { 
            Color = color, 
            Make = make, 
            PetName = petname 
        });
        repo.Dispose();
    }

    public void InsertCar(InventoryRecord car)
    {
        var repo = new InventoryRepo();
        repo.Add(new Inventory
        { 
            Color = car.Color,
            Make = car.Make,
            PetName = car.PetName
        });
        repo.Dispose();
    }

    public List<InventoryRecord> GetInventory()
    {
        var config = new MapperConfiguration(cfg => 
        {
            cfg.CreateMap<Inventory, InventoryRecord>();
        });
        IMapper mapper = config.CreateMapper();

        var repo = new InventoryRepo();
        List<Inventory> records = repo.GetAll();
        var results = mapper.Map<List<InventoryRecord>>(records);
        repo.Dispose();
        return results;
    }
}
