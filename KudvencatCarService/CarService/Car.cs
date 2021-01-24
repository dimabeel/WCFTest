using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CarService
{
    [KnownType(typeof(ElectricCar))]
    [KnownType(typeof(OilFuelCar))]
    [DataContract]
    [Table("Car")]
    public class Car
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [DataMember(Order = 2)]
        public string Mark { get; set; }

        [DataMember(Order = 3)]
        public string Model { get; set; }

        [DataMember(Order = 4)]
        public DateTime YearOfProduction { get; set; }

        [DataMember(Order = 5)]
        public EngineType EngineType { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }

    public enum EngineType
    {
        Electric = 1,
        OilFuel = 2
    }
}
