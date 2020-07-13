using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using ProgramingTraningRis.Main.Views;

namespace ProgramingTraningRis.Main
{
    public class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // DIコンテナからPrismのフレームワークの画面管理のものをとりだしてる
            var regionMan = containerProvider.Resolve<IRegionManager>();

            //
            regionMan.RegisterViewWithRegion("ContentRegion", typeof(Views.Login));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //　画面を追加したらここに書いて、画面管理のものに教える感じです！
            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.RegisterForNavigation<List>();
            containerRegistry.RegisterForNavigation<Login>();
            containerRegistry.RegisterForNavigation<Study.Views.Study>();
        }
    }
}