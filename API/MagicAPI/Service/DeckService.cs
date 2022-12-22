using MagicAPI.Dto;
using MagicAPI.Models;
using MagicAPI.Repository.Interface;
using MagicAPI.Service.Base;
using MagicAPI.Service.Interface;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Service
{
    public class DeckService : ServiceBaseCRUD<DeckModel, int>, IDeckService
    {

        #region Properties

        private readonly IDeckRepository _deckRepository;
        private readonly IMemoryCache _memoryCache;

        #endregion Properties

        #region Constructors

        public DeckService(IDeckRepository deckRepository, IMemoryCache memoryCache) : base(deckRepository)
        {
            _deckRepository = deckRepository;
            _memoryCache = memoryCache;
        }

        public async Task<int> CreateDeckAsync(DeckModel model)
        {
            return await _deckRepository.CreateAsync(model);
        }

        #endregion Constructors

        #region Methods
        public async Task<DeckModel> GetAsync(int id)
        {
            var output = new DeckModel();

            var cacheKey = "my_deck";

            if (!_memoryCache.TryGetValue(cacheKey, out output))
            {
                var deck = await _deckRepository.GetAsync(id);

                output = deck;

                var cacheOptions = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromHours(2));
                _memoryCache.Set(cacheKey, output, cacheOptions);
            }

            return output;
            //return await _deckRepository.GetAsync(id);
        }

        #endregion Methods
    }
}
