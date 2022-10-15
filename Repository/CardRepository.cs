using MagicAPI.Context;
using MagicAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace MagicAPI.Repository
{
    public class CardRepository : ICardRepository
    {
        private readonly DbContextOptions<ApplicationDbContext> _optionsDB;

        public CardRepository(DbContextOptions<ApplicationDbContext> optionsDB)
        {
            _optionsDB = optionsDB;
        }
    }
}
