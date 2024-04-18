using CommunityToolkit.Maui;
using FootyApp.Services;
using FootyApp.View;
using FootyApp.ViewModel;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace FootyApp;

public static class MauiProgram
{
	private static IConfigurationRoot GetAppConfig(string file)
	{
		var assembly = Assembly.GetExecutingAssembly();
		using var stream = assembly.GetManifestResourceStream($"FootyApp.Config.{file}");

		var config = new ConfigurationBuilder().AddJsonStream(stream).Build();
		return config;
	}

	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


		builder.Configuration.AddConfiguration(GetAppConfig("appsettings.json"));
        builder.Configuration.AddConfiguration(GetAppConfig("LeaguesConfig.json"));

        builder.Services.AddHttpClient<ApiService>();

        builder.Services.AddSingleton<LeaguesService>();
        builder.Services.AddSingleton<LeagueViewModel>();
        builder.Services.AddSingleton<MainPage>();

        builder.Services.AddSingleton<PlayersService>();
		builder.Services.AddTransient<TeamDetailsViewModel>();
		builder.Services.AddTransient<TeamDetailsPage>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
