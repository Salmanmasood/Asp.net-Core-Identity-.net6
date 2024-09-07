
using User.Management.Service.Models.ViolationDTOs;
using Microsoft.AspNetCore.SignalR;


namespace User.Management.Service.Hubs
{
    public class ViolationHub:Hub
    {
        public async Task SendViolation(ViolationDtoResponse violation)
        {
            await Clients.All.SendAsync("ReceiveViolation", violation);
        }

    }
}
