﻿namespace TelegramClient.Core.Settings
{
    using TelegramClient.Core.Sessions;

    internal interface IClientSettings
    {
        int AppId { get; set; }

        string AppHash { get; set; }

        ISession Session { get; set; }
    }
}