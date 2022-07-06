using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chat.Models;
using ServiceReference1;
using ChatInfoDto = Chat.Models.ChatInfoDto;
using MessageDto = Chat.Models.MessageDto;

namespace Chat.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        private readonly Service1Client _service;
        public ChatController()
        {
            _service = new Service1Client();
        }

        [HttpGet]
        public async Task<IActionResult> GetChat(Guid chatId)
         {
            var chat= await _service.GetChatDtoAsync(chatId);
            var messagesDtos = new List<MessageDto>();
            foreach (var messageDto in chat.Messages)
            {
                messagesDtos.Add(new MessageDto()
                {
                    CreationDate = messageDto.CreationDate,
                    DisplayName = messageDto.DisplayName,
                    Text = messageDto.Text
                });
            }

            return View(new Models.ChatDto
            {
                ChatId = chat.ChatId,
                Messages = messagesDtos
            });
        }

        [HttpGet]
        public async Task<IActionResult> GetChats()
        {
            var user = Guid.Parse(User.Claims.First().Value);

            var chats = await _service.GetChatsAsync(user);
            var chatInfoDto= new List<Models.ChatInfoDto>();
            var list = chats.Chats;
            foreach (var chat in list)
            {
                chatInfoDto.Add(new ChatInfoDto()
                {
                    ChatId = chat.ChatId,
                    Companion = chat.Companion
                });
            }

            return View(new Models.ChatsInfoDto
            {
                Chats = chatInfoDto
            });
        }

        [HttpGet]
        public async Task<IActionResult> TryCreateChat(string companion)
        {
            var userId = Guid.Parse(User.Claims.First().Value);

            var comp = await _service.GetUserByLoginAsync(companion);

            if (comp.Email==null)
                return Json(new { success = false, message = "Не удалось найти такого пользователя" });

            var user = await _service.GetUserByIdAsync(userId);

            if (!await _service.IsChatCreatedAsync(comp.Id,userId))
                return Json(new { success = false, message = "Такой чат уже существует" });

            var ss = await _service.TryCreateChatAsync(companion, userId, user.Email);

            return Json(new { success = true, data = ss });
        }
    }
}