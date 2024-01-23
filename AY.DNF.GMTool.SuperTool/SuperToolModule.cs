using AY.DNF.GMTool.SuperTool.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace AY.DNF.GMTool.SuperTool
{
    class SuperToolModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<SuperToolPage>(nameof(SuperToolModule));
        }
    }
}
