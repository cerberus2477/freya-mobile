using Microsoft.Extensions.Logging;
using FreyaMobile.View;
//using CommunityToolkit.Maui;

namespace FreyaMobile;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
            .UseMauiApp<App>()
            // Initialize the .NET MAUI Community Toolkit by adding the below line of code
            //.UseMauiCommunityToolkit()
            .UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		#if DEBUG
		builder.Logging.AddDebug();
		#endif

		

		return builder.Build();
	}
}
