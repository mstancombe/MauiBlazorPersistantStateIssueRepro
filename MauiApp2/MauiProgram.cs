using Microsoft.AspNetCore.Components.Infrastructure;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace MauiApp2;

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

        // Uncommenting these lines allows RCL components that use persistant state to be rendered
        // *******
        //builder.Services.AddSingleton<ComponentStatePersistenceManager>();
        //builder.Services.AddSingleton<PersistentComponentState>(sp => sp.GetRequiredService<ComponentStatePersistenceManager>().State);
		// ********


#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		return builder.Build();
	}
}
