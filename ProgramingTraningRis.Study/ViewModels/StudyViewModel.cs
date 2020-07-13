using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramingTraningRis.Study.ViewModels
{
    public class StudyViewModel : BindableBase, INavigationAware
    {
        public ReactiveCommand BackCommand { get; }

        private IRegionManager RegionManager { get; set; }
        private IRegionNavigationService RegionNavigationService { get; set; }

        public StudyViewModel(IRegionManager regionManager)
        {
            this.RegionManager = regionManager;

            this.BackCommand = new ReactiveCommand();
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            this.RegionNavigationService = navigationContext.NavigationService;
            this.BackCommand.Subscribe(_ => RegionNavigationService.Journal.GoBack());
        }

        public bool IsNavigationTarget(NavigationContext navigationContext) => true;

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}