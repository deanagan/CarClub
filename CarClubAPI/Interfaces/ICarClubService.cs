using System.Collections.Generic;

using CarClubAPI.Models;

namespace CarClubAPI.Interfaces
{
    public interface ICarClubService
    {
        IEnumerable<Vehicle> AllVehicles();

    }
}
