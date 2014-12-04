namespace FastCars.SharedConventions
{
    using NServiceBus;
    public static class ConventionExtensions
    {
        public static void ApplyCustomConventions(this BusConfiguration busConfiguration)
        {
            var conventions = busConfiguration.Conventions();
            conventions.DefiningCommandsAs(t => t.Namespace != null && t.Namespace.StartsWith("FastCars") && t.Namespace.EndsWith("Commands"));
            conventions.DefiningEventsAs(t => t.Namespace != null && t.Namespace.StartsWith("FastCars") && t.Namespace.EndsWith("Events"));
            conventions.DefiningMessagesAs(t => t.Namespace != null && t.Namespace.StartsWith("FastCars") && t.Namespace.EndsWith("Messages"));
            // In a similar fashion you can define conventions for EncrypedProperties, DataBusProperties, ExpressMessages and TimeToBeRecevied            
        }
    }
}
