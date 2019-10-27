using System;

namespace Model
{
    public interface IBuildingService
    {
        int NumberOfFloors { get; set; }
        int CurrentFloor { get; set; }
    }
}
