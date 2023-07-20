// <copyright file="MauiProgram.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using CommunityToolkit.Maui;
using Drastic.Services;
using FishyFlip;
using FishyFlipApp.MauiUI.Services;
using FishyFlipApp.MauiUI.ViewModels;
using MauiIcons.Cupertino;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace FishyFlipMauiApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var debugLog = new DebugLoggerProvider();
        var atProtocolBuilder = new ATProtocolBuilder()
            .WithLogger(debugLog.CreateLogger("FishyFlipDebug"))
            .EnableAutoRenewSession(true);
        var atProtocol = atProtocolBuilder.Build();
        var builder = MauiApp.CreateBuilder();
        builder
            .Services
            .AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddProvider(debugLog);
            })
            .AddSingleton<IAppDispatcher, MauiAppDispatcher>()
            .AddSingleton<IErrorHandlerService, MauiErrorHandler>()
            .AddSingleton<ATProtocol>(atProtocol)
            .AddSingleton<DebugPageViewModel>();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .UseCupertinoMauiIcons();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}