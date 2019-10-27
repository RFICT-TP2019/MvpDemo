using System;
namespace Model
{
    public class BuildingService : IBuildingService
    {
        private int _numberOfFloors;
        private int _currentFloor;

        public int NumberOfFloors
        {
            get => _numberOfFloors;
            set
            {
                if (0 < value && value < 10)
                    _numberOfFloors = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        public int CurrentFloor
        {
            get => _currentFloor;
            set
            {
                if (0 < value && value <= _numberOfFloors)
                    _currentFloor = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
    }
}
