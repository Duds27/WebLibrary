namespace DDD.Infra.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}