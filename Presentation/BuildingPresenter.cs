using Model;
using Ninject;

namespace Presentation
{
    public class BuildingPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IBuildingView _view;
        private readonly IBuildingService _service;

        public BuildingPresenter(IKernel kernel, IBuildingView view, IBuildingService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.SetUp += SetUp;
            _view.CallElevator += CallElevator;
        }

        private void SetUp()
        {
            _kernel.Get<SetUpPresenter>().Run();
            _view.Close();
        }

        private void CallElevator(int n)
        {
            _service.CurrentFloor = n;
            _view.SetActiveFloor(_service.CurrentFloor);
        }

        public void Run()
        {
            _view.SetNumberOfFloors(_service.NumberOfFloors);
            _view.Show();
        }
    }
}