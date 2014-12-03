namespace Messages
{
    //TODO: 1. Add a using reference for NServiceBus
    public class PlaceOrder //TODO: Implement the ICommand marker interface
    {
        public string Product { get; set; }
    }
}
