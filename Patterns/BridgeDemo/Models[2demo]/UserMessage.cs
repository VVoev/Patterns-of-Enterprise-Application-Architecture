namespace BridgeDemo.Models_2demo_
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class UserMessage : Message
    {
        public string UserComments { get; set; }

        public override void Send()
        {
            string fullBody = string.Format("{0}\nUser Comments: {1}", Body, UserComments);
            MessageSender.SendMessage(Subject, fullBody);
        }
    }
}
