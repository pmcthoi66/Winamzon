namespace Winamz.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}