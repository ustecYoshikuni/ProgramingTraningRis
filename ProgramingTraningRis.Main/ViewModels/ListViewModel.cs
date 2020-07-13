using Prism.Mvvm;
using Prism.Regions;
using ProgramingTraningRis.Common;
using Reactive.Bindings;
using System;

namespace ProgramingTraningRis.Main.ViewModels
{
    public class ListViewModel : BindableBase
    {
        public string MyProperty { get; set; }
        public ReactiveProperty<string> PropertyName { get; }

        public ReactiveCommand TextChangeCommand { get; }
        public ReactiveCommand ToStudyCommand { get; }

        private IRegionManager RegionManager { get; set; }

        public ListViewModel(IRegionManager regionManager)
        {
            this.MyProperty = "aaaaaaaa";

            this.RegionManager = regionManager;

            this.PropertyName = new ReactiveProperty<string>();
            this.TextChangeCommand = new ReactiveCommand();
            this.ToStudyCommand = new ReactiveCommand();

            this.PropertyName.Value = "sabosabo";

            this.TextChangeCommand.Subscribe(_ => this.TextChange());
            this.ToStudyCommand.Subscribe(_ => this.ToStudy());
        }

        private bool Flag = true;

        private void TextChange()
        {
            if (this.Flag)
            {
                this.MyProperty = "bbbbbbb";
                this.PropertyName.Value = "baribari";
                this.Flag = false;
            }
            else
            {
                this.MyProperty = "aaaaaa";
                this.PropertyName.Value = "sabasabo";
                this.Flag = true;
            }
        }

        private void ToStudy()
        {
            this.RegionManager.RequestNavigate("ContentRegion", ViewControl.Study);
        }
    }
}