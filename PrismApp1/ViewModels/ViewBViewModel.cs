namespace PrismApp1.ViewModels;

public class ViewBViewModel : BindableBase, IRegionAware
{
    private string _viewModelName;
    private string _navParameter;

    public ViewBViewModel()
    {
        ViewModelName = nameof(ViewBViewModel);
    }

    public string ViewModelName
    {
        get => _viewModelName;
        set => SetProperty(ref _viewModelName, value);
    }

    public string NavParameter
    {
        get => _navParameter;
        set => SetProperty(ref _navParameter, value);
    }

    public bool IsNavigationTarget(INavigationContext navigationContext)
    {
        return true;
    }

    public void OnNavigatedFrom(INavigationContext navigationContext)
    {
    }

    public void OnNavigatedTo(INavigationContext navigationContext)
    {
        this.NavParameter = (string)navigationContext.Parameters["NavParameter"];
    }
}
