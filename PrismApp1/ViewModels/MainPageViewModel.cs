using PrismApp1.Views;
using System.Windows.Input;

namespace PrismApp1.ViewModels;

public class MainPageViewModel : BindableBase
{
    private readonly IRegionManager regionManager;

    public MainPageViewModel(IRegionManager regionManager)
    {
        this.regionManager = regionManager;
        this.NavigateToViewACommand = new DelegateCommand(() => this.NavigateViewToContentRegion(nameof(ViewA)));
        this.NavigateToViewBCommand = new DelegateCommand(() => this.NavigateViewToContentRegion(nameof(ViewB)));
    }

    public ICommand NavigateToViewACommand { get; }

    public ICommand NavigateToViewBCommand { get; }

    public void NavigateViewToContentRegion(string target)
    {
        var navParams = new NavigationParameters
        {
            { "NavParameter", $"NavigationParameter for {target}." }
        };

        this.regionManager.RequestNavigate("ContentRegion", target, navParams);
    }
}
