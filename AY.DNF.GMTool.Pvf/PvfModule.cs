using AY.DNF.GMTool.Pvf.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Text;

namespace AY.DNF.GMTool.Pvf
{
    class PvfModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {            
            containerRegistry.RegisterForNavigation<PvfPage>(nameof(PvfModule));
        }
    }
}
