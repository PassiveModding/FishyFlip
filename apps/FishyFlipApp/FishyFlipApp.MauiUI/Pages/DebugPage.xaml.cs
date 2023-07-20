// <copyright file="DebugPage.xaml.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using FishyFlipApp.MauiUI.ViewModels;

namespace FishyFlipApp.MauiUI.Pages;

/// <summary>
/// Debug Page.
/// </summary>
public partial class DebugPage : ContentPage
{
    private DebugPageViewModel vm;
    
    /// <summary>
    /// Initializes a new instance of the <see cref="DebugPage"/> class.
    /// </summary>
    public DebugPage(IServiceProvider provider)
    {
        this.InitializeComponent();
        this.BindingContext = this.vm = provider.GetRequiredService<DebugPageViewModel>();
    }
}