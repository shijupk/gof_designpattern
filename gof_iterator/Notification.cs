namespace gof_iterator
{
    public class Notification
    {
        private string _notification;
        public Notification(string notification)
        {
            _notification = notification;
        }
        public string GetNotification()
        {
            return _notification;
        }
    }
}
