using System;
using Model;
using Ninject;

namespace Presentation
{
    public class SetUpPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISetUpView _view;
        private readonly IBuildingService _service;
        public SetUpPresenter(IKernel kernel, ISetUpView view, IBuildingService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.SetUp += () => SetUp(_view.NumberOfFloors);
        }

        private void SetUp(string numberOfFloors)
        {
            if (!int.TryParse(numberOfFloors, out var n))
            {
                _view.ShowError("Invalid number of floors!");
                return;
            }

            try
            {
                _service.NumberOfFloors = n;
            }
            catch (Exception e)
            {
                _view.ShowError(e.Message);
                return;
            }

            _kernel.Get<BuildingPresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
