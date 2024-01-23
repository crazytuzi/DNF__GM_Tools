using AY.DNF.GMTool.BubbleTimer.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace AY.DNF.GMTool.BubbleTimer
{
    [Module(OnDemand = true)]
    public class BubbleTimerModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //var rm = containerProvider.Resolve<IRegionManager>();
            //rm.RegisterViewWithRegion("ContentRegion", typeof(BubbleTimerPage));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<BubbleTimerPage>(nameof(BubbleTimerModule));
        }
    }
}
