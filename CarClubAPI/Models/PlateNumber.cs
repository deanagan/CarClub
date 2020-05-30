using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CarClubAPI.Models
{
    public class PlateNumber
    {
        [Key]
        public int Id { get;set; }
        public string Number { get; set; }
        public int VehicleId { get;set; }

        // Navigational Properties one to one relationship
        public Vehicle Vehicle { get; set; }

    }
}
