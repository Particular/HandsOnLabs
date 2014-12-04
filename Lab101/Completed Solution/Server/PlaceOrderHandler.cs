namespace Server
{
    using System;
    using NServiceBus;
    using Messages;
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        public void Handle(PlaceOrder message)
        {
            Console.WriteLine("Order for Product: {0} placed.", message.Product);
        }
    }
}
