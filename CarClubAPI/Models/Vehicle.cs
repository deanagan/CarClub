using System.ComponentModel.DataAnnotations;

namespace CarClubAPI.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get;set; }
        public string Make { get; set; }
        public string Model { get;set; }


        // Navigational Properties one to one relationship
        public PlateNumber PlateNumber { get; set; }
    }
}
