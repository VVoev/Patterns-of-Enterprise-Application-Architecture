using System;
using System.Collections.Generic;

namespace MediatorDemo.Models_2Demo_
{
    public abstract class AbstractChatRoom
    {
        public abstract void Register(Participant participant);

        public abstract void Send(string from, string to, string message);
    }

    public class ChatRoom : AbstractChatRoom
    {
        private Dictionary<string, Participant> participants = new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!participants.ContainsValue(participant))
            {
                participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }

        public override void Send(string from, string to, string message)
        {
            Participant participant = participants[to];
            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }

    public class Participant
    {
        private ChatRoom chatroom;
        private string name;

        public Participant(string name)
        {
            this.name = name;
        }

        public string Name => name;

        public ChatRoom Chatroom
        {
            get
            {
                return this.chatroom;
            }
            set
            {
                this.chatroom = value;
            }
        }

        public void Send(string to, string message)
        {
            chatroom.Send(name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {Name} :{message}");
        }
    }

    public class Beatle : Participant
    {
        public Beatle(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine($"from:{this.GetType().Name}");
            base.Receive(from, message);
        }
    }

    public class NonBeattle : Participant
    {
        public NonBeattle(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine($"from:{this.GetType().Name}");
            base.Receive(from, message);
        }
    }
}
