namespace Retail.Orders.Sender
{
    using System;
    using NServiceBus;
    using Retail.Orders.Messages.Events;

    public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        public void Handle(OrderPlaced message)
        {
            Console.WriteLine("Received Event OrderPlaced for orderId: {0}", message.OrderId);
        }
    }
}


