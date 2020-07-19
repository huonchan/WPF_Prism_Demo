using PrismModuleDemo.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PrismModuleDemo
{
    public class PrismModuleDemoModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}