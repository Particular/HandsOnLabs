
namespace Retail.Orders.Handler
{
    using System;
    using NServiceBus;
    using Retail.Orders.Messages.Commands;
    using Retail.Orders.Messages.Events;
    public class ProcessOrderCommandHandler : IHandleMessages<PlaceOrder> 
    {
        public IBus Bus { get; set; }

        public void Handle(PlaceOrder message)
        {
            Console.WriteLine("Received PlaceOrder command, OrderId: {0}", message.OrderId);
            Bus.Publish<OrderPlaced>(m => m.OrderId = message.OrderId);
            Console.WriteLine("Published OrderPlaced event for OrderId: {0}", message.OrderId);
        }
    }
}

