using AY.DNF.GMTool.Postal.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace AY.DNF.GMTool.Postal
{
    class PostalModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<PostalPage>(nameof(PostalModule));
        }
    }
}
