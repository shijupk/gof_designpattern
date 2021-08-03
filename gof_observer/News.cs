namespace gof_observer
{
    public class News : INews
    {
        public string Message { get; set; }

        public News(string message)
        {
            Message = message;
        }
    }
}
