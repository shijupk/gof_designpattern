using System;

namespace gof_iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationCollection notificationCollection = new NotificationCollection();

            NotificationBar notificationBar = new NotificationBar(notificationCollection);

            notificationBar.Print();

            Console.ReadKey();
        }
    }
}
