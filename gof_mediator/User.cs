namespace gof_mediator
{
    public abstract class User
    {
        private IChatRoom _mediatorRoom;
        private string _userId;
        private string _userName;

        public User(IChatRoom chatRoom, string userId, string name)
        {
            _mediatorRoom = chatRoom;
            _userId = userId;
            _userName = name;

        }

        public abstract void Send(string message, string toUserId);
        public abstract void Recieve(string message);

        public IChatRoom GetMediatorRoom()
        {
            return _mediatorRoom;
        }

        public string GetUserId()
        {
            return _userId;
        }

        public string GetName()
        {
            return _userName;
        }

    }
}
