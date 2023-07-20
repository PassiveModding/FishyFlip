// <copyright file="DebugPageViewModel.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using Drastic.ViewModels;

namespace FishyFlipApp.MauiUI.ViewModels;

/// <summary>
/// Debug Page View Model.
/// </summary>
public class DebugPageViewModel : ATProtocolBaseViewModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DebugPageViewModel"/> class.
    /// </summary>
    /// <param name="services">Base services.</param>
    public DebugPageViewModel(IServiceProvider services)
        : base(services)
    {
    }

    public override async Task OnLoad()
    {
        await base.OnLoad();
        await this.SetupDataAsync();
    }

    private async Task SetupDataAsync()
    {
    }
}