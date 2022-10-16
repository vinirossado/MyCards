using MagicAPI.Helper;
using MagicAPI.Models;
using MagicAPI.Request;
using MagicAPI.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {
        #region Properties
        private readonly ICardService _cardService;
        #endregion Properties

        #region Constructors

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        #endregion Constructors


        //[HttpGet]
        //public async Task<IActionResult> GetCards()
        //{
        //    IMtgServiceProvider serviceProvider = new MtgServiceProvider();

        //    ICardService service = serviceProvider.GetCardService();
        //    IOperationResult<List<ICard>> result = await service.AllAsync();
        //    if (result.IsSuccess)
        //    {
        //        var value = result.Value;
        //    }
        //    else
        //    {
        //        var exception = result.Exception;
        //    }

        //    return Ok(result);
        //}


        //[HttpGet, Route("find")]
        //public async Task<ActionResult<List<ICard>>> FindCardById([FromRoute]string cardName)
        //{
        //    IMtgServiceProvider serviceProvider = new MtgServiceProvider();

        //    ICardService service = serviceProvider.GetCardService();
        //    var result = await service.FindAsync("Yuriko, the Tiger's Shadow");

        //    return Ok(result);
        //}


        //[HttpGet, Route("GetAllCardsWithPagination")]
        //public async Task<ActionResult<List<ICard>>> GetAllCardsWithPagination()
        //{
        //    IMtgServiceProvider serviceProvider = new MtgServiceProvider();

        //    ICardService service = serviceProvider.GetCardService();
        //    var result = await service.Where(x => x.Page, 5)
        //                              .Where(x => x.PageSize, 250)
        //                              .AllAsync();

        //    //.Where(x => x.Name == "Predador da Escama Dilacerante")
        //    var x = result.Value.Select(x => x.ForeignNames);

        //    return Ok(result);
        //}

        //public IForeignName MapForeignName(ForeignName foreignNameDto)
        //{
        //    if (foreignNameDto == null)
        //    {
        //        throw new ArgumentNullException(nameof(foreignNameDto));
        //    }

        //    return new ForeignName
        //    {
        //        Language = foreignNameDto.Language,
        //        MultiverseId = foreignNameDto.MultiverseId,
        //        Name = foreignNameDto.Name,
        //    };
        //}

        //[HttpGet, Route("GetAllSets")]
        //public async Task<ActionResult<List<ICard>>> GetAllSets()
        //{
        //    IMtgServiceProvider serviceProvider = new MtgServiceProvider();

        //    var result = await service.AllAsync();

        //    return Ok(result);
        //}

        [HttpPost, Route("register")]
        public async Task<ActionResult<JsonReturnModel>> Register([FromBody] RegisterCardRequest card)
        {
            var cardFounded = await _cardService.Register(card.CardName, card.SetCollection);

            if (cardFounded is null)
                return BadRequest("This card was not found");

            return Ok(cardFounded);
        }

        [HttpPost, Route("register-by-list")]
        public async Task<ActionResult<JsonReturnModel>> RegisterByList([FromBody] IList<RegisterCardRequest> cards)
        {
            foreach (var card in cards)
                await _cardService.Register(card.CardName, card.SetCollection);

            return Ok("Cartas Cadastradas com sucesso");
        }

        //[HttpGet, Route("get-my-decks")]
        //public async Task<ActionResult<IList<CardModel>>> GetMyDecks()
        //{

        //}
    }
}
