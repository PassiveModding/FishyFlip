﻿// <copyright file="FirehoseViewModel.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using Drastic.Tools;
using Drastic.ViewModels;
using FishyFlip;
using FishyFlip.Models;
using FishyFlip.Tools;
using System;
using System.Collections.ObjectModel;

namespace FishyFlipMaui.ViewModels;

public class FirehoseViewModel : BaseViewModel
{
    ATProtocol atProtocol;
    AsyncCommand connectCommand;
    AsyncCommand disconnectCommand;

    public FirehoseViewModel(IServiceProvider services)
        : base(services)
    {
        this.atProtocol = services.GetRequiredService<ATProtocol>();
        this.atProtocol.OnConnectionUpdated += OnConnectionUpdated;
        this.atProtocol.OnSubscribedRepoMessage += OnSubscribedRepoMessage;
        this.Items.CollectionChanged += (s, e) => this.OnPropertyChanged(nameof(this.Count));
    }

    public ObservableCollection<FirehoseItem> Items { get; } = new ObservableCollection<FirehoseItem>();

    public AsyncCommand ConnectCommand => connectCommand ??= new AsyncCommand(this.ConnectAsync, () => !this.atProtocol.IsSubscriptionActive, this.Dispatcher, this.ErrorHandler);

    public AsyncCommand DisconnectCommand => disconnectCommand ??= new AsyncCommand(this.DisconnectAsync, () => this.atProtocol.IsSubscriptionActive, this.Dispatcher, this.ErrorHandler);

    public int Count => this.Items.Count;

    public async Task ConnectAsync()
    {
        await this.atProtocol.StartSubscribeReposAsync();
    }

    public async Task DisconnectAsync()
    {
        await this.atProtocol.StopSubscriptionAsync();
    }

    public override void RaiseCanExecuteChanged()
    {
        base.RaiseCanExecuteChanged();
        this.ConnectCommand.RaiseCanExecuteChanged();
        this.DisconnectCommand.RaiseCanExecuteChanged();
    }

    private void OnSubscribedRepoMessage(object sender, FishyFlip.Events.SubscribedRepoEventArgs e)
    {
        if (e.Message.Commit is not FrameCommit commit)
        {
            return;
        }

        if (e.Message.Record is Post post)
        {
            this.HandlePost(commit.Repo, post).FireAndForgetSafeAsync(this.ErrorHandler);
        }
    }

    private void OnConnectionUpdated(object sender, FishyFlip.Events.SubscriptionConnectionStatusEventArgs e)
    {
        this.RaiseCanExecuteChanged();
    }

    private async Task HandlePost(ATIdentifier ident, Post post)
    {
        var actor = (await this.atProtocol.Repo.GetActorAsync(ident)).HandleResult();
        this.AddItem(new FirehoseItem(ident, post, actor.Value));
    }

    private void AddItem(FirehoseItem item)
    {
        lock (this.Items)
        {
            this.Items.Insert(0, item);
            if (this.Items.Count > 100)
            {
                this.Items.Remove(this.Items.LastOrDefault());
            }
        }
    }
}

public class FirehoseItem
{
    public FirehoseItem(ATIdentifier ident, Post post, Profile profile)
    {
        this.Post = post;
        this.Profile = profile;
        if (profile.Avatar?.Ref is not null)
        {
           this.Image = $"https://bsky.social{Constants.Urls.ATProtoSync.GetBlob}?did={ident!}&cid={profile.Avatar.Ref.Link}";
        }
    }

    public Post? Post { get; }
    public Profile? Profile { get; }

    public ATIdentifier Ident { get; }

    public string Image { get; }
}