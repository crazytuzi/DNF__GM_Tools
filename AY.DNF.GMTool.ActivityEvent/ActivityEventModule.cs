using Prism.Ioc;
using Prism.Modularity;

namespace AY.DNF.GMTool.ActivityEvent
{
    class ActivityEventModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ActivityEventModule>(nameof(ActivityEventModule));
        }
    }
}
