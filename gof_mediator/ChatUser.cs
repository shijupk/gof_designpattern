using System;

namespace gof_mediator
{
    public class ChatUser : User
    {
        //default constructor
        public ChatUser(IChatRoom room, string userId, string name)
            : base(room, userId, name) { }

        public override void Send(string message, string toUserId)
        {
            Console.WriteLine($"{GetName()} :: Sending message: {message} To: {toUserId}");
            GetMediatorRoom().SendMessage(message, toUserId);
        }

        public override void Recieve(string message)
        {
            Console.WriteLine($"{GetName()} :: Recieved  message: {message}");
        }
    }
}
