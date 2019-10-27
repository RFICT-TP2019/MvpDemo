using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Presentation;
using Ninject;
using Ninject.MockingKernel;
using Ninject.MockingKernel.NSubstitute;
using NSubstitute;

namespace UnitTests
{
    [TestClass]
    public class BuildingPresenterTests
    {
        private IKernel _kernel;
        private IBuildingView _view;
        private IBuildingService _service;

        [TestInitialize]
        public void SetUp()
        {
            _kernel = new NSubstituteMockingKernel();

            _view = Substitute.For<IBuildingView>();
            _service = Substitute.For<IBuildingService>();
            _service.NumberOfFloors.Returns(5);

            var presenter = new BuildingPresenter(_kernel, _view, _service);
            presenter.Run();
        }

        [TestMethod]
        public void CallElevatorSetsActive()
        {
            _view.CallElevator += Raise.Event<Delegates.CallElevator>(3);
            _view.Received().SetActiveFloor(3);
        }
    }
}