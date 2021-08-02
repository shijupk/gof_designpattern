using System.Collections.Generic;

namespace gof_mediator
{
    public class ChatRoom : IChatRoom
    {
        private Dictionary<string, User> _userDictionary = new Dictionary<string, User>();

        public void SendMessage(string message, string userId)
        {
            User user = _userDictionary[userId];
            if (user == null)
            {
                return;
            }
            else
            {
                user.Recieve(message);
            }
        }

        public void AddUser(User user)
        {
            if (user == null)
            {
                return;
            }
            else
            {
                _userDictionary[user.GetUserId()] = user;
            }
        }
    }
}
