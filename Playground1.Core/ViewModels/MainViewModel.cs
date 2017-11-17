using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Navigation;

namespace Playground1.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private IMvxNavigationService _navigation;

        public MainViewModel(IMvxNavigationService navigation)
        {
            _navigation = navigation;
        }

        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        // SecondView ‚Ö‘JˆÚ‚³‚¹‚éƒRƒ}ƒ“ƒh
        public IMvxAsyncCommand ShowSecondViewCommand => new MvxAsyncCommand(async () =>
        {
            await _navigation.Navigate(typeof(SecondViewModel), Text);
        });
    }
}