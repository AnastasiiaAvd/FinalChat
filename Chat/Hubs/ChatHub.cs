using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using ServiceReference1;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        private readonly Service1Client _service;
        public ChatHub()
        {
            _service = new Service1Client();
        }

        public async Task JoinToChat(string chatRoomId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, chatRoomId);
        }

        public async Task Send(string message, string chatRoomId)
        {
            //var user = Context.User.Identity.Name;
            var userId = Guid.Parse(Context.User.Claims.First().Value);
            var user = _service.GetUserByIdAsync(userId);

            var messageDate =await _service.AddMessageAsync(Guid.Parse(chatRoomId), message, userId);

            await Clients.Group(chatRoomId).SendAsync("Receive", message, user.Result.Email, messageDate);
        }
    }
}