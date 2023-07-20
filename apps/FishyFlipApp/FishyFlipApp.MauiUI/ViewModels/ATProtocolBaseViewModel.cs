// <copyright file="ATProtocolBaseViewModel.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using Drastic.ViewModels;
using FishyFlip;

namespace FishyFlipApp.MauiUI.ViewModels;

/// <summary>
/// Protocol Handler base view model.
/// </summary>
public class ATProtocolBaseViewModel : BaseViewModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ATProtocolBaseViewModel"/> class.
    /// </summary>
    /// <param name="services">Base services.</param>
    protected ATProtocolBaseViewModel(IServiceProvider services)
        : base(services)
    {
        this.Protocol = services.GetRequiredService<ATProtocol>();
    }

    public ATProtocol Protocol { get; }
}