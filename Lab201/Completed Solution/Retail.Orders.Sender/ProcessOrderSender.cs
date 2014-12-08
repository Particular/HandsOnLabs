
namespace Retail.Orders.Sender
{
    using System;
    using NServiceBus;
    using Retail.Orders.Messages.Commands;
    using Retail.Orders.Messages.Events;

    class ProcessOrderSender : IWantToRunWhenBusStartsAndStops
    {
        public IBus Bus { get; set; }

        public void Start()
        {
            Console.WriteLine("Press 'Enter' to send 10 messages. To exit, Ctrl + C");
            var orderNumber = 1;
            while (Console.ReadLine() != null)
            {
                for (var index = 0; index < 10; index++)
                {
                    var orderId = string.Format("order{0}", orderNumber);
                    Bus.Send<PlaceOrder>(m => { m.OrderId = orderId; });
                    Console.WriteLine("Sent PlacedOrder command with orderId: {0}.", orderId);
                    orderNumber++;
                }

                Console.WriteLine("Press 'Enter' to send another 10 messages. To exit, Ctrl + C");
            }

        }

        public void Stop()
        {
            Bus.Unsubscribe<OrderPlaced>();
        }
    }
}

