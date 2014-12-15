﻿using System;

namespace AsterNET.ARI.Middleware
{
    public enum ConnectionState
    {
        Open,
        Closed
    }

    public class MessageEventArgs
    {
        public string Message;
    }

    public interface IEventProducer
    {
        event EventHandler<MessageEventArgs> OnMessageReceived;
        event EventHandler OnConnectionStateChanged;

        void Connect();
        void Disconnect();

        ConnectionState State { get; }
    }
}
