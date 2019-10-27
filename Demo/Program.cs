using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Ninject;
using Presentation;

namespace Demo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            kernel.Bind<ISetUpView>().To<SetUpView>();
            kernel.Bind<IBuildingView>().To<BuildingView>();
            kernel.Bind<SetUpPresenter>().ToSelf();
            kernel.Bind<BuildingPresenter>().ToSelf();
            kernel.Bind<IBuildingService>().To<BuildingService>().InSingletonScope();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<SetUpPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}
