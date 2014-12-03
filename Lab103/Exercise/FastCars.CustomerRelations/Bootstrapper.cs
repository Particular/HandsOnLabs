namespace FastCars.CustomerRelations
{
    using System;
    //TODO: 1. Add a using reference for NServiceBus
    //TODO: 2. Add a using reference for FastCars.Events

    public class Bootstrapper //TODO: 3. Implement the interface IWantToRunWhenBusStartsAndStops
    {
        //TODO: 4. Add a public IBus Bus {get;set;} to get the Bus injected to this bootstrapper
        
        public void Start()
        {
            Console.WriteLine("Press Enter to publish an event");
            while (Console.ReadLine() != null)
            {
                //TODO: 5. Publish the ClientBecamePreferred event
                Console.WriteLine("Published ClientBecamePreferred event");
            }
        }

        public void Stop()
        {
        }
    }
}
