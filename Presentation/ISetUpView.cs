using System;

namespace Presentation
{
    public interface ISetUpView : IView
    {
        string NumberOfFloors { get; }
        event Action SetUp;
        void ShowError(string message);
    }
}
