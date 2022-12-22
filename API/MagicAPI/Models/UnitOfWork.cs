using MagicAPI.Context;
using MagicAPI.Models.Interface;

namespace MagicAPI.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Properties
        private readonly ApplicationDbContext _dbContext;
        #endregion Properties

        #region Constructors
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion Constructors

        #region Methods

        public bool Save()
        {
            return _dbContext.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
        #endregion Methods

    }
}
