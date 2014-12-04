namespace FastCars.Promotions
{
    using System;
    using NServiceBus;
    using FastCars.Events;

    public class ClientBecamePreferredHandler : IHandleMessages<ClientBecamePreferred>
    {
        public void Handle(ClientBecamePreferred message)
        {
            Console.WriteLine("Client became preferred, send them a new free rental offer");
        }
    }
}

