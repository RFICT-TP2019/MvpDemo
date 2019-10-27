using System;

namespace Presentation
{
    public interface IBuildingView : IView
    {
        void SetNumberOfFloors(int n);
        void SetActiveFloor(int floor);
        event Action SetUp;
        event Delegates.CallElevator CallElevator;
    }
}