namespace MagicAPI.Models.Interface
{
    public interface IUnitOfWork
    {
        bool Save();
        void Dispose();
    }
}
