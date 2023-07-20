// <copyright file="App.xaml.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using FishyFlipApp.MauiUI.Pages;

namespace FishyFlipMauiApp;

public partial class App : Application
{
    public App(IServiceProvider provider)
    {
        this.InitializeComponent();
        this.MainPage = new DebugPage(provider);
    }
}
