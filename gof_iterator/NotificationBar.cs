using System;

namespace gof_iterator
{
    public class NotificationBar
    {
        private NotificationCollection _notificationCollection;

        public NotificationBar(NotificationCollection notificationCollection)
        {
            _notificationCollection = notificationCollection;
        }

        public void Print()
        {
            Iterator iterator = _notificationCollection.CreateIterator();

            Console.WriteLine("-----------------Iteration Begins-------------");
            while (iterator.HasNext())
            {
                var notification = iterator.Next();
                Console.WriteLine(notification.GetNotification());

            }
            Console.WriteLine("-----------------Iteration Ends-------------");
        }
    }
}
