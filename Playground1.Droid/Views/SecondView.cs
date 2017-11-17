using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using Playground1.Core.ViewModels;

namespace Playground1.Droid.Views
{
    [Activity]
    public class SecondView : MvxActivity<SecondViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SecondView);
        }
    }
}
