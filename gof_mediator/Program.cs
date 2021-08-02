using System;

namespace gof_mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatRoom chatRoom = new ChatRoom();

            User Alice = new ChatUser(chatRoom, "1", "Alice");
            User Bob = new ChatUser(chatRoom, "2", "Bob");


            chatRoom.AddUser(Alice);
            chatRoom.AddUser(Bob);

            Console.WriteLine("-------- Alice to Bob ------------");
            Alice.Send("Hello Bob", Bob.GetUserId());

            Console.WriteLine("-------- Bob to Alice ------------");
            Bob.Send("Hi Alice", Alice.GetUserId());

            Console.ReadKey();




        }
    }
}
