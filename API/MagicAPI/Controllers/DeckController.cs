using MagicAPI.Application.Interface;
using MagicAPI.Dto;
using MagicAPI.Helper;
using MagicAPI.HubsConfig.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
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
        private IHubContext<MessageHub, IMessageHubClient> _messageHub;
        private readonly IBaseMessage _baseMessageHub;


        #endregion Properties

        #region Constructors
        public DeckController(IDeckApplication deckApplication, IHubContext<MessageHub, IMessageHubClient> messageHub, IBaseMessage baseMessageHub)
        {
            _deckApplication = deckApplication;
            _messageHub = messageHub;
            _baseMessageHub = baseMessageHub;
        }
        #endregion Constructors  

        #region Methods
        [HttpGet, Route("{id}")]
        public string Get([FromRoute] int id)
        {
            List<string> offers = new List<string>();
            offers.Add("20% Off on IPhone 12");
            offers.Add("15% Off on HP Pavillion");
            offers.Add("25% Off on Samsung Smart TV");
            _messageHub.Clients.All.SendOffersToUser(offers);
            return "Offers sent successfully to all users!";
            //var db = await _deckApplication.GetAsync(id);
            //return Ok(db);
        }

        [HttpGet, Route("create")]
        public async Task<IActionResult> CreateRoom()
        {
            await _baseMessageHub.CreateRoom("SalaDoBonito");
            //await _messageHub.Clients.All.CreateRoom("SalaDoBonito");
            //await _baseMessageHub.JoinRoom("SalaDoBonito");
            return Ok();
        }

        [HttpGet, Route("rooms")]
        public async Task<IActionResult> GetAllRooms()
        {
            var rooms = await _baseMessageHub.GetAllRooms();
            //await _messageHub.Clients.All.CreateRoom("SalaDoBonito");
            //await _baseMessageHub.JoinRoom("SalaDoBonito");
            return Ok(rooms);
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
