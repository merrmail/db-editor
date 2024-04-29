﻿using CommunityToolkit.Maui;
using MerrMail.Maui.Models;
using MerrMail.Maui.Services;
using MerrMail.Maui.ViewModels;
using MerrMail.Maui.Views;
using Microsoft.Extensions.Logging;

namespace MerrMail.Maui;
public static class MauiProgram
{
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

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<Account>();

        builder.Services.AddSingleton<ISettings, Settings>();
        builder.Services.AddSingleton<IEmailContextService, EmailContextService>();
        builder.Services.AddSingleton<IAccountService, AccountService>();

        builder.Services.AddTransient<AddAccountViewModel>();
        builder.Services.AddTransient<AddAccountPage>();

        builder.Services.AddSingleton<EmailContextsViewModel>();
        builder.Services.AddSingleton<EmailContextsPage>();

        builder.Services.AddSingleton<HomeViewModel>();
        builder.Services.AddSingleton<HomePage>();

        builder.Services.AddTransient<CreateEmailContextViewModel>();
        builder.Services.AddTransient<CreateEmailContextPage>();

        builder.Services.AddTransient<EditEmailContextViewModel>();
        builder.Services.AddTransient<EditEmailContextPage>();

        builder.Services.AddSingleton<EmailContextDetailsViewModel>();
        builder.Services.AddSingleton<EmailContextDetailsPage>();

        builder.Services.AddSingleton<PasswordViewModel>();
        builder.Services.AddSingleton<PasswordPage>();

        return builder.Build();
    }
}
