using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Navigation;
using System.Linq;

namespace Playground1.Core.ViewModels
{
public class SecondViewModel : MvxViewModel<string>
{
    private IMvxNavigationService _navigation;

    public SecondViewModel(IMvxNavigationService navigation)
    {
        _navigation = navigation;
    }

    public override void Prepare(string parameter)
    {
        Text = parameter;
    }

    public IMvxAsyncCommand CloseCommand => new MvxAsyncCommand(async () =>
    {
        await _navigation.Close(this);
    });

    private string _text;
    public string Text
    {
        get => _text;
        private set => SetProperty(ref _text, value);
    }
}
}