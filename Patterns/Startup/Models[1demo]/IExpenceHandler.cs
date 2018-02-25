namespace Startup.Models_1demo
{
    public interface IExpenceHandler
    {
        ApprovalResponse Approve(IExpenceReport expenceReport);
        void RegisterNext(IExpenceHandler handler);
    }

}
