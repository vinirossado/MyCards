using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace MagicAPI.HubsConfig
{
    public class AppHub : Hub
    {
        #region Properties
        //private readonly IUser _user;
        //private readonly IPersonApp _personApp;

        //protected readonly string COMPANY_USER_GROUP = "EMPRESA_USUARIO";
        protected readonly string COMPANY_GROUP = "EMPRESA";
        #endregion

        #region Constructors
        public AppHub()
        {
            //_personApp = personApp;
            //_user = user;
        }
        #endregion

        public override Task OnConnectedAsync()
        {
            string connectionId = Context.ConnectionId;

            return base.OnConnectedAsync();
        }

        //public async Task SendDeviceAccessInformationAsync(DTOCapturedDeviceAccessInformation informations)
        //{
        //    await Clients.All.SendAsync("informations", informations);
        //}

        //public async Task SendPersonInformationAsync(DTOCapturedPersonInformations dto)
        //{
        //    await Clients.All.SendAsync("personInformations", dto);
        //}

        public async Task SendNotificationDeviceConnected(int idDevice, bool connected)
        {
            await Clients.All.SendAsync("deviceConnectionStatus", idDevice, connected);
        }
        public async Task SendNewDeviceConnected(bool connected)
        {
            await Clients.All.SendAsync("newDeviceConnected", connected);
        }

    }
}
