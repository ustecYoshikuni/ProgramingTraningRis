using Prism.Ioc;
using Prism.Modularity;
using ProgramingTraningRis.Common;
using ProgramingTraningRis.Main;
using ProgramingTraningRis.Views;
using System.Windows;

namespace ProgramingTraningRis
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<MainModule>(InitializationMode.WhenAvailable);
            moduleCatalog.AddModule<CommonModule>(InitializationMode.WhenAvailable);
        }
    }
}