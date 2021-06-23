using AutoMapper;
using MagicAPI.Context;
using MagicAPI.Models;
using MagicAPI.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Model;
using MtgApiManager.Lib.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {

        private readonly DbContextOptions<ApplicationDbContext> _optionsDB;

        public CardController(DbContextOptions<ApplicationDbContext> optionsDB)
        {
            _optionsDB = optionsDB;
        }

        [HttpGet]
        public async Task<IActionResult> GetCards()
        {
            IMtgServiceProvider serviceProvider = new MtgServiceProvider();

            ICardService service = serviceProvider.GetCardService();
            IOperationResult<List<ICard>> result = await service.AllAsync();
            if (result.IsSuccess)
            {
                var value = result.Value;
            }
            else
            {
                var exception = result.Exception;
            }

            return Ok(result);
        }


        [HttpGet]
        public async Task<ActionResult<List<ICard>>> FindCardById()
        {
            IMtgServiceProvider serviceProvider = new MtgServiceProvider();


            ICardService service = serviceProvider.GetCardService();
            var result = await service.FindAsync("f2eb06047a3a8e515bff62b55f29468fcde6332a");

            return Ok(result);
        }


        //[HttpGet, Route("FilterCardsQueryParameters")]
        private async Task<CardModel> FilterCardsQueryParameters(string nomeDaCarta, string set)
        {
            IMtgServiceProvider serviceProvider = new MtgServiceProvider();

            //ICardService service = serviceProvider.GetCardService();
            //IOperationResult<List<ICard>> result = await service.AllAsync();

            ICardService service = serviceProvider.GetCardService();
            var result = await service.Where(x => x.Name, nomeDaCarta)
                                       .Where(x => x.Set, set)
                                      .AllAsync();

            var cards = new List<CardModel>();

            cards.AddRange(Mapper.Map<List<CardModel>>(result.Value));

            return cards[0];
        }

        [HttpGet, Route("GetAllCardsWithPagination")]
        public async Task<ActionResult<List<ICard>>> GetAllCardsWithPagination()
        {
            IMtgServiceProvider serviceProvider = new MtgServiceProvider();

            ICardService service = serviceProvider.GetCardService();
            var result = await service.Where(x => x.Page, 5)
                                      .Where(x => x.PageSize, 250)
                                      .AllAsync();

            return Ok(result);
        }

        [HttpGet, Route("GetAllSets")]
        public async Task<ActionResult<List<ICard>>> GetAllSets()
        {
            IMtgServiceProvider serviceProvider = new MtgServiceProvider();

            ISetService service = serviceProvider.GetSetService();
            var result = await service.AllAsync();

            return Ok(result);
        }

        [HttpPost, Route("cadastrar")]
        public async Task<ActionResult<CardModel>> Cadastrar([FromBody] CadastroCartaRequest request)
        {

            var cartaEncontrada = await FilterCardsQueryParameters(request.NomeCarta, request.Set);


            using (var db = new ApplicationDbContext(_optionsDB))
            {
                db.CardModel.Add(cartaEncontrada);
                db.SaveChanges();
            }

            //await context.AddAsync(cartaEncontrada);
            //await context.SaveChangesAsync();


            return Ok(cartaEncontrada);
        }
    }
}
