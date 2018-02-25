namespace Startup.Models_2demo_
{
    public abstract class Approver
    {
        protected Approver Successor { get; set; }

        public void SetSuccessor(Approver successor)
        {
            this.Successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
