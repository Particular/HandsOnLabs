namespace FastCars.Events
{
    using System;
    //TODO: 1. For Exercise 1, add a using reference to NServiceBus

    public class ClientBecamePreferred //TODO: 2. For Exercise1, implement the marker interface IEvent
    {
        public Guid ClientId { get; set; }
        public DateTime PreferredUntil { get; set; }
    }
}

