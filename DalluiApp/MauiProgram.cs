using CommunityToolkit.Maui;
using DalluiApp.ViewModels;
using DalluiApp.Views;
using Microsoft.Extensions.Logging;
using PanCardView;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace DalluiApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseCardsView()
                .UseSkiaSharp()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Nexa-ExtraLight.ttf", "NexaLight");
                    fonts.AddFont("Nexa-Heavy.ttf", "NexaHeavy");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            ConfigureServices(builder.Services);

            return builder.Build();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<AppShell>();
            services.AddTransient<DashboardPageView>();
            services.AddTransient<GenerateOptionsPageView>();
            services.AddTransient<ImageGeneratorPageView>();

            services.AddTransient<DashboardPageViewModel>();
            services.AddTransient<GenerateOptionsPageViewModel>();
            services.AddTransient<ImageGeneratorPageViewModel>();
        }
    }
}
