﻿using MediatR;
using System;
using System.Text;

namespace NerdStore.Core.Messages.CommonMessages.Notifications
{
    public class DomainNotification : Message, INotification
    {
        public DateTime TimeStamp { get; private set; }
        public Guid DomainNotificationId { get; private set; }
        public string Key { get; private set; }
        public string Value { get; private set; }
        public int Version { get; private set; }

        public DomainNotification(string key, string value)
        {
            TimeStamp = DateTime.Now;
            DomainNotificationId = Guid.NewGuid();
            Version = 1;
            Key = key;
            Value = value;
        }
    }
}
