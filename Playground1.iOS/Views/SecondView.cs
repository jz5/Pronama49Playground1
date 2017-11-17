using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Playground1.Core.ViewModels;

namespace Playground1.iOS.Views
{
    public partial class SecondView : MvxViewController<SecondViewModel>
    {
        public SecondView() : base("SecondView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<SecondView, SecondViewModel>();
            set.Bind(Label).To(vm => vm.Text);
            set.Bind(Button).To(vm => vm.CloseCommand);
            set.Apply();
        }
    }
}