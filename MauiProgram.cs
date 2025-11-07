using ApiConnectedDbApp.Services;
using Microsoft.Extensions.Logging;

namespace ApiConnectedDbApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        // Register Services with DI (Singleton for HttpClient reuse; Scoped for DB if multi-page, but Singleton fine here).
        builder.Services.AddSingleton<IApiService, ApiService>();
        builder.Services.AddSingleton<IDatabaseRepository, DatabaseRepository>();

        return builder.Build();
    }
}