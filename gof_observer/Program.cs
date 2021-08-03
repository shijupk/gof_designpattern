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


            espn.Subscribe(alice);
            espn.Subscribe(bob);

            espn.Notify(new News("Olympic Update"));

            espn.Unsubscribe(alice);

            espn.Notify(new News("Cricket Update"));

            Console.ReadKey();

        }
    }
}
