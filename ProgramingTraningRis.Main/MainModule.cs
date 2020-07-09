using ProgramingTraningRis.Main.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ProgramingTraningRis.Main
{
    public class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //DIコンテナからPrismのフレームワークの画面管理のものをとりだしてる
            var regionMan = containerProvider.Resolve<IRegionManager>();

            //
            regionMan.RegisterViewWithRegion("ContentRegion", typeof(Views.List));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}