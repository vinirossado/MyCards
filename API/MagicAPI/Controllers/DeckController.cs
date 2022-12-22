using AutoMapper;
using MagicAPI.Application.Interface;
using MagicAPI.Dto;
using MagicAPI.Helper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeckController : ControllerBase
    {
        #region Properties
        private readonly IDeckApplication _deckApplication;

        #endregion Properties

        #region Constructors
        public DeckController(IDeckApplication deckApplication)
        {
            _deckApplication = deckApplication;
        }
        #endregion Constructors  

        #region Methods
        [HttpGet, Route("{id}")]
        public async Task<ActionResult<DeckDto>> Get([FromRoute] int id)
        {
            var db = await _deckApplication.GetAsync(id);
            return Ok(db);
        }

        [HttpPost]
        public async Task<ActionResult<JsonReturnModel>> Create([FromBody] DeckDto dto)
        {
            //var deckMapper = _mapper.Map<DeckModel>(dto);

            var deckId = await _deckApplication.CreateDeckAsync(dto);

            return Ok(deckId);
        }

        //[HttpPost, Route("create-with-cards")]
        //public async Task<ActionResult<JsonReturnModel>> CreateWithCards([FromBody] DeckDto dto)
        //{
        //    var deckMapper = _mapper.Map<DeckModel>(dto);

        //    var deckId = await _deckApplication.CreateDeckAsync(deckMapper);

        //    return Ok(deckId);
        //}

        #endregion Methods
    }
}
