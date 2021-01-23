using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace CarService
{
    [DataContract]
    public class Car
    {
        [Key]
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [DataMember(Order = 2)]
        public string Mark { get; set; }

        [DataMember(Order = 3)]
        public string Model { get; set; }

        [DataMember(Order = 4)]
        public DateTime YearOfProduction { get; set; }
    }
}
