namespace BridgeDemo.Models_2demo_
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    public abstract class Message
    {
        public IMessageSender MessageSender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public abstract void Send();
    }
}
