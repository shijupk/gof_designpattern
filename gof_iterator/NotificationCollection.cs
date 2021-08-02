using System;

namespace gof_iterator
{
    public class NotificationCollection : ICollection
    {
        const int MAX_ITEMS = 10;
        private int _noOfItems = 0;
        Notification[] _notifications;

        public NotificationCollection()
        {
            _notifications = new Notification[MAX_ITEMS];

            AddItem("Notification 1");
            AddItem("Notification 2");
            AddItem("Notification 3");
        }

        public void AddItem(String item)
        {
            Notification notification = new Notification(item);
            if (_noOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Capacity full");
            }
            else
            {
                _notifications[_noOfItems] = notification;
                _noOfItems++;
            }
        }

        public Iterator CreateIterator()
        {
            return new NotificationIterator(_notifications);
        }
    }
}
