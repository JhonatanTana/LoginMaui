﻿using LoginMaui.Services;
using Microsoft.Extensions.Logging;

namespace LoginMaui;
public static class MauiProgram {
    public static MauiApp CreateMauiApp() {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://viacep.com.br/ws/") });

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<IUsuarioService, UsuarioService>();
        builder.Services.AddSingleton<ICadastroService, CadastroService>();

        return builder.Build();
    }
}