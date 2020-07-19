using Prism.Ioc;
using SimplePrismDemo.Views;
using System.Windows;
using Prism.Modularity;
using PrismModuleDemo;

namespace SimplePrismDemo
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
            containerRegistry.RegisterForNavigation<PrismModuleDemo.Views.ViewA>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<PrismModuleDemoModule>(InitializationMode.WhenAvailable);
        }
    }

}