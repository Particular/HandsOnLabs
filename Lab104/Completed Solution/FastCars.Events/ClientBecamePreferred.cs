namespace FastCars.Events
{
    using System;
    using NServiceBus;

    public class ClientBecamePreferred : IEvent
    {
        public Guid ClientId { get; set; }
        public DateTime PreferredUntil { get; set; }
    }
}

