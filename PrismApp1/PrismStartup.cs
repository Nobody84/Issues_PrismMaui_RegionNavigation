using PrismApp1.ViewModels;
using PrismApp1.Views;

namespace PrismApp1;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
                .OnAppStart("NavigationPage/MainPage");
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry
            .RegisterForNavigation<MainPage>()
            .RegisterForRegionNavigation<ViewA, ViewAViewModel>()
            .RegisterForRegionNavigation<ViewB, ViewBViewModel>()
            .RegisterInstance(SemanticScreenReader.Default);
    }
}
