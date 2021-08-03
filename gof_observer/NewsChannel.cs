using System;
using System.Collections.Generic;

namespace gof_observer
{
    public class NewsChannel : IObservable
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            Console.WriteLine($" {observer.Name} Subcribed the channel");
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            Console.WriteLine($" {observer.Name} Unsubscribed the channel");
            _observers.Remove(observer);
        }

        public void Notify(INews news)
        {
            Console.WriteLine($" New Notification!!! New Message: '{news.Message}'");

            foreach (IObserver observer in _observers)
            {
                observer.Update(news);
            }
        }
    }
}
