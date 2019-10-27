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
    public class SetUpPresenterTests
    {
        private IKernel _kernel;
        private ISetUpView _view;
        private IBuildingService _service;

        [TestInitialize]
        public void SetUp()
        {
            _kernel = new NSubstituteMockingKernel();
            _kernel.Bind<BuildingPresenter>().ToMock();

            _view = Substitute.For<ISetUpView>();
            _service = Substitute.For<IBuildingService>();

            var presenter = new SetUpPresenter(_kernel, _view, _service);
            presenter.Run();
        }

        [TestMethod]
        public void InvalidFloorsInput()
        {
            _view.NumberOfFloors.Returns("five");
            _view.SetUp += Raise.Event<Action>();
            _view.Received().ShowError(Arg.Any<string>());
        }

        [TestMethod]
        public void TooMuchFloors()
        {
            _view.NumberOfFloors.Returns("99");
            _service.NumberOfFloors = 
                Arg.Do<int>(x => throw new OutOfMemoryException());
            _view.SetUp += Raise.Event<Action>();
            _view.Received().ShowError(Arg.Any<string>());
        }

        [TestMethod]
        public void ValidFloors()
        {
            _view.NumberOfFloors.Returns("99");
            int floors = 0;
            _service.NumberOfFloors = Arg.Do<int>(x => floors = x);
            _view.SetUp += Raise.Event<Action>();
            _view.DidNotReceive().ShowError(Arg.Any<string>());
            Assert.AreEqual(99, floors);
        }
    }
}