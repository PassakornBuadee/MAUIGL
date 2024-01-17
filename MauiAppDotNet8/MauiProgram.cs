using MauiAppDotNet8.Controls;
using MauiAppDotNet8.Handlers;
using Microsoft.Extensions.Logging;

namespace MauiAppDotNet8
{
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
                })
                .ConfigureMauiHandlers((handlers) =>
                {
                    handlers.AddHandler(typeof(GradientLabel), typeof(GradientLabelHandler));
                });
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
