using AY.DNF.GMTool.ActivityEvent.Views;
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
            containerRegistry.RegisterForNavigation<ActivityEventPage>(nameof(ActivityEventModule));
        }
    }
}
