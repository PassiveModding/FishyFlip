// <copyright file="MauiAppDispatcher.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace FishyFlipApp.MauiUI.Services;

/// <summary>
/// Maui App Dispatcher.
/// </summary>
public class MauiAppDispatcher : IAppDispatcher
{
    private IDispatcher dispatcher;

    public MauiAppDispatcher(IDispatcher dispatcher)
    {
        this.dispatcher = dispatcher;
    }

    /// <inheritdoc/>
    public bool Dispatch(Action action)
    {
        return this.dispatcher.Dispatch(action);
    }
}