// <copyright file="MauiErrorHandler.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace FishyFlipApp.MauiUI.Services;

/// <summary>
/// Maui Error Handler.
/// </summary>
public class MauiErrorHandler : IErrorHandlerService
{
    /// <inheritdoc/>
    public void HandleError(Exception ex)
    {
        System.Diagnostics.Debug.WriteLine(ex.Message);
    }
}