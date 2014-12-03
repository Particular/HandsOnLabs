namespace FastCars.Events
{
    using System;
    public class ClientBecamePreferred 
    {
        public Guid ClientId { get; set; }
        public DateTime PreferredUntil { get; set; }
    }
}

