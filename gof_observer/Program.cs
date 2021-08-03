using System;

namespace gof_observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var espn = new NewsChannel();

            var alice = new ChannelSubscriber("Alice");
            var bob = new ChannelSubscriber("Bob");

            Console.WriteLine($"------------------- SUBSCRIPTION ---------------------------");
            espn.Subscribe(alice);
            espn.Subscribe(bob);
            Console.WriteLine($"------------------- NOTIFICATION ---------------------------");
            espn.Notify(new News("Olympic Update"));
            Console.WriteLine($"------------------- SUBSCRIPTION ---------------------------");
            espn.Unsubscribe(alice);
            Console.WriteLine($"------------------- NOTIFICATION ---------------------------");
            espn.Notify(new News("Cricket Update"));
            Console.WriteLine($"-------------------------------------------------------------");
            Console.ReadKey();

        }
    }
}
