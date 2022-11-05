using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using MagicAPI.Service;
using MagicAPI.Models;
using MagicAPI.Repository.Interface;
using Moq;

namespace MagicAPI.Tests.Service
{
    public class CardServiceTest
    {

        private Mock<ICardRepository> cardRepositoryMock = new Mock<ICardRepository>();
        private ICardRepository cardRepository;
        private CardService service;

        public CardServiceTest()
        {
            cardRepository = cardRepositoryMock.Object;
            this.service = new CardService(cardRepository);
        }

        [Fact]
        public async Task ShouldCall_CreateAsync_RepositoryMethod()
        {
            var model = new Mock<CardModel>().Object;
            await service.CreateAsync(model);

            cardRepositoryMock.Verify(cardRepository => cardRepository.CreateAsync(model), Times.Once);
        }
    }
}