using MediatR;
using System;

namespace NerdStore.Core.Messages
{
    //INotification é uma interface de marcação
    public abstract class Event : Message, INotification
    {
        public DateTime Timestamp { get; private set; }
        protected Event()
        {
            Timestamp = DateTime.Now;   
        }
    }
   

}
