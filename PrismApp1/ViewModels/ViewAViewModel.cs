namespace PrismApp1.ViewModels;

public class ViewAViewModel : BindableBase, INavigatedAware
{
    private string _viewModelName;
    private string _navParameter;

    public ViewAViewModel()
    {
        ViewModelName = nameof(ViewAViewModel);
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
