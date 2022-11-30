using Microsoft.AspNetCore.Components.WebView.Maui;
using eventsApp.Data;

namespace eventsApp;

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
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddSingleton<HttpRestService>();
        builder.Services.AddSingleton<Account>();
        builder.Services.AddSingleton<Event>();
		builder.Services.AddSingleton<Session>();
        return builder.Build();
	}
}

