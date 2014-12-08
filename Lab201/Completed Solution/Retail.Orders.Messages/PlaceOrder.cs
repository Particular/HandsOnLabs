namespace Retail.Orders.Messages.Commands
{
    using NServiceBus;

    public class PlaceOrder : ICommand
    {
        public string OrderId { get; set; }
    }
} 

