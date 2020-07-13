using Prism.Mvvm;
using Prism.Regions;
using ProgramingTraningRis.Common;
using Reactive.Bindings;
using System;

namespace ProgramingTraningRis.Main.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        public ReactiveCommand LoginCommand { get; }
        private IRegionManager RegionManager;

        public LoginViewModel(IRegionManager regionManager)
        {
            this.RegionManager = regionManager;

            this.LoginCommand = new ReactiveCommand();
            this.LoginCommand.Subscribe(_ => this.Login());
        }

        private void Login()
        {
            this.RegionManager.RequestNavigate("ContentRegion", ViewControl.List);

            //this.RegionManager.RequestNavigate("ContentRegion", nameof(Views.List));
            //this.RegionManager.RequestNavigate("ContentRegion", "List");
        }
    }
}