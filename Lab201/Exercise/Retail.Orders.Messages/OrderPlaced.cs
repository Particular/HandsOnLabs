namespace Retail.Orders.Messages.Events
{
    using NServiceBus;

    public class OrderPlaced : IEvent
    {
        public string OrderId { get; set; }
    }
}

