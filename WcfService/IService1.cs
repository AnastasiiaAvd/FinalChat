using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using UnitOfWork.DataModels;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Chat GetChat(Guid chatId);

        [OperationContract]
        List<Chat> GetAllChats(Guid userId);

        [OperationContract]
        ChatInfoDto TryCreateChat(string companion, Guid currentUserId, string userName);

        [OperationContract]
        UserDataModel GetUser(string login, string password);

        [OperationContract]
        UserDataModel GetUserById(Guid userId);

        [OperationContract]
        UserDataModel GetUserByLogin(string login);

        [OperationContract]
        void AddUser(string login, string password);

        [OperationContract]
        DateTime AddMessage(Guid chatRoom, string message, Guid id);

        [OperationContract]
        ChatDto GetChatDto(Guid chatId);

        [OperationContract]
        ChatsInfoDto GetChats(Guid id);

        [OperationContract]
        bool IsChatCreated(Guid userId, Guid currentUserId);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        //// TODO: Add your service operations here
    }


}
