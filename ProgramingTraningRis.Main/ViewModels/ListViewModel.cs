using Prism.Commands;
using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramingTraningRis.Main.ViewModels
{
    public class ListViewModel : BindableBase
    {
        public string MyProperty { get; set; }
        public ReactiveProperty<string> PropertyName { get; }

        public ReactiveCommand TextChangeCommand { get; }

        public ListViewModel()
        {
            this.MyProperty = "aaaaaaaa";

            this.PropertyName = new ReactiveProperty<string>();
            this.PropertyName.Value = "sabosabo";

            this.TextChangeCommand = new ReactiveCommand();
            this.TextChangeCommand.Subscribe(_ => this.TextChange());
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
    }
}