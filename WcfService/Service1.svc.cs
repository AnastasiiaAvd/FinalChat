using DomainModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWork;
using UnitOfWork.DataModels;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private readonly ChatUnitOfWork unitOfWork;

        public Service1()
        {
            unitOfWork = new ChatUnitOfWork();
        }

        public UserDataModel GetUser(string login, string password)
        {
            var applicationUser = unitOfWork.ApplicationUsers.FirstOrDefault(w => w.Email == login && w.Password == password);
            var ww = new UserDataModel
            {
                Id = applicationUser.Id,
                Email = applicationUser.Email,
                Password = applicationUser.Password, Color = applicationUser.Color
            };

            return ww;
        }

        public UserDataModel GetUserByLogin(string login)
        {
            var applicationUser = unitOfWork.ApplicationUsers.FirstOrDefault(w => w.Email == login);
            if(applicationUser!=null)
            { var ww = new UserDataModel
            {
                Id = applicationUser.Id,
                Email = applicationUser.Email,
                Password = applicationUser.Password
            }; return ww;
            }
            else return new UserDataModel();
           
        }

        public void AddUser(string login, string password)
        {
            Random _random = new Random();
            var c = Color.FromArgb(_random.Next(0, 255), _random.Next(0, 255), _random.Next(0, 255));
            var newCol = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            var user = new ApplicationUser
            {
                Password = password,
                Email = login, 
                Color = newCol
            };
            unitOfWork.ApplicationUsers.Add(user);
            unitOfWork.SaveChanges();
        }

        public List<Chat> GetAllChats(Guid userId)
        {
            return unitOfWork.Chats.GetAll().ToList();
        }

        public Chat GetChat(Guid chatId)
        {
            return unitOfWork.Chats.FirstOrDefault(w => w.Id == chatId);
        }

        public DateTime AddMessage(Guid chatRoom, string message, Guid id)
        {
            var msg = new Message()
            {
                MessageAuthorId = unitOfWork.ApplicationUsers.FirstOrDefault(w => w.Id == id).Id,
                Text = message,
                ChatId = chatRoom
            };
            var date = DateTime.Now;
            msg.CreationDate = date;
            unitOfWork.Messages.Add(msg);
            unitOfWork.SaveChanges();
            return date;
        }

        public ChatDto GetChatDto(Guid chatId)
        {
            var messages = (from message in unitOfWork.Messages.GetAll()
                                 join user in unitOfWork.ApplicationUsers.GetAll() on message.MessageAuthorId equals user.Id
                                 where message.ChatId == chatId
                                 select new MessageDto
                                 { DisplayName = user.Email, Text = message.Text, CreationDate = message.CreationDate.ToString("dddd, dd MMMM HH:mm"), Color = user.Color})
                    .OrderBy(message => message.CreationDate).ToList();


            return new ChatDto
            {
                ChatId = chatId,
                Messages = messages
            };
        }

        public ChatInfoDto TryCreateChat(string companion, Guid currentUserId, string userName)
        {
            var user = unitOfWork.ApplicationUsers.FirstOrDefault(us => us.Email == companion);

            var currentChat = unitOfWork.Chats.FirstOrDefault(chat =>
                chat.ChatGuestId == user.Id && chat.ChatOwnerId == currentUserId ||
                chat.ChatOwnerId == user.Id && chat.ChatGuestId == currentUserId);
            
            currentChat = new Chat
            {
                ChatGuestId = user.Id,
                ChatOwnerId = currentUserId
            };

            unitOfWork.Chats.Add(currentChat);
            unitOfWork.SaveChanges();

            return new ChatInfoDto
            {
                ChatId = currentChat.Id,
                Companion = userName
            };
        }

        public UserDataModel GetUserById(Guid userId)
        {
            var applicationUser = unitOfWork.ApplicationUsers.FirstOrDefault(r => r.Id == userId);

            var ww = new UserDataModel
            {
                Id = applicationUser.Id,
                Email = applicationUser.Email,
                Password = applicationUser.Password, 
                Color = applicationUser.Color
            };
            return ww;
        }
        public ChatsInfoDto GetChats(Guid id)
        {
            //var gId = Guid.Parse(id);
            var user = unitOfWork.ApplicationUsers.FirstOrDefault(u => u.Id ==id );
            var chats = (from chat in unitOfWork.Chats.GetAll()
                join chatOwner in unitOfWork.ApplicationUsers.GetAll() on chat.ChatOwnerId equals chatOwner.Id
                join chatGuest in unitOfWork.ApplicationUsers.GetAll() on chat.ChatGuestId equals chatGuest.Id
                where chat.ChatGuestId == user.Id || chat.ChatOwnerId == user.Id
                select new ChatInfoDto
                {
                    ChatId = chat.Id,
                    Companion = chat.ChatGuestId == user.Id ? chatOwner.Email : chatGuest.Email
                }).ToList();
            return new ChatsInfoDto()
            {
                Chats = chats
            };
        }
        public bool IsChatCreated(Guid userId, Guid currentUserId)
        {
            var currentChat =  unitOfWork.Chats.FirstOrDefault(chat =>
                chat.ChatGuestId == userId && chat.ChatOwnerId == currentUserId ||
                chat.ChatOwnerId == userId && chat.ChatGuestId == currentUserId);
            if (currentChat != null)
                return false;
            return true;
        }
    }
}
