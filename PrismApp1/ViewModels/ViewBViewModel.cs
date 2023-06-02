namespace PrismApp1.ViewModels;

public class ViewBViewModel : BindableBase, INavigatedAware
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

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
        this.NavParameter = (string)parameters["NavParameter"];
    }
}
