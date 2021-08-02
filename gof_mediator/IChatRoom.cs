namespace gof_mediator
{
    public interface IChatRoom
    {
        public void SendMessage(string message, string userId);
        public void AddUser(User user);
    }
}
