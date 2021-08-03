using System;

namespace gof_observer
{
    public class ChannelSubscriber : IObserver
    {
        public string Name { get; set; }

        public ChannelSubscriber(string subscriberName)
        {
            Name = subscriberName;
        }
        public void Update(INews news)
        {
            Console.WriteLine($"=>    {Name} got Message: {news.Message}");
        }
    }
}
