﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Chat", Namespace="http://schemas.datacontract.org/2004/07/DomainModels")]
    public partial class Chat : object
    {
        
        private ServiceReference1.ApplicationUser ChatGuestField;
        
        private System.Guid ChatGuestIdField;
        
        private ServiceReference1.ApplicationUser ChatOwnerField;
        
        private System.Guid ChatOwnerIdField;
        
        private System.Guid IdField;
        
        private ServiceReference1.Message[] MessagesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.ApplicationUser ChatGuest
        {
            get
            {
                return this.ChatGuestField;
            }
            set
            {
                this.ChatGuestField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ChatGuestId
        {
            get
            {
                return this.ChatGuestIdField;
            }
            set
            {
                this.ChatGuestIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.ApplicationUser ChatOwner
        {
            get
            {
                return this.ChatOwnerField;
            }
            set
            {
                this.ChatOwnerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ChatOwnerId
        {
            get
            {
                return this.ChatOwnerIdField;
            }
            set
            {
                this.ChatOwnerIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Message[] Messages
        {
            get
            {
                return this.MessagesField;
            }
            set
            {
                this.MessagesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ApplicationUser", Namespace="http://schemas.datacontract.org/2004/07/DomainModels")]
    public partial class ApplicationUser : object
    {
        
        private string EmailField;
        
        private ServiceReference1.Chat[] GuestChatsField;
        
        private System.Guid IdField;
        
        private ServiceReference1.Message[] MessagesField;
        
        private ServiceReference1.Chat[] OwnerChatsField;
        
        private string PasswordField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Chat[] GuestChats
        {
            get
            {
                return this.GuestChatsField;
            }
            set
            {
                this.GuestChatsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Message[] Messages
        {
            get
            {
                return this.MessagesField;
            }
            set
            {
                this.MessagesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Chat[] OwnerChats
        {
            get
            {
                return this.OwnerChatsField;
            }
            set
            {
                this.OwnerChatsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/DomainModels")]
    public partial class Message : object
    {
        
        private ServiceReference1.Chat ChatField;
        
        private System.Guid ChatIdField;
        
        private System.DateTime CreationDateField;
        
        private System.Guid IdField;
        
        private ServiceReference1.ApplicationUser MessageAuthorField;
        
        private System.Guid MessageAuthorIdField;
        
        private string TextField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Chat Chat
        {
            get
            {
                return this.ChatField;
            }
            set
            {
                this.ChatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ChatId
        {
            get
            {
                return this.ChatIdField;
            }
            set
            {
                this.ChatIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationDate
        {
            get
            {
                return this.CreationDateField;
            }
            set
            {
                this.CreationDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.ApplicationUser MessageAuthor
        {
            get
            {
                return this.MessageAuthorField;
            }
            set
            {
                this.MessageAuthorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid MessageAuthorId
        {
            get
            {
                return this.MessageAuthorIdField;
            }
            set
            {
                this.MessageAuthorIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text
        {
            get
            {
                return this.TextField;
            }
            set
            {
                this.TextField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ChatInfoDto", Namespace="http://schemas.datacontract.org/2004/07/UnitOfWork.DataModels")]
    public partial class ChatInfoDto : object
    {
        
        private System.Guid ChatIdField;
        
        private string CompanionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ChatId
        {
            get
            {
                return this.ChatIdField;
            }
            set
            {
                this.ChatIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Companion
        {
            get
            {
                return this.CompanionField;
            }
            set
            {
                this.CompanionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDataModel", Namespace="http://schemas.datacontract.org/2004/07/UnitOfWork.DataModels")]
    public partial class UserDataModel : object
    {
        
        private string EmailField;
        
        private System.Guid IdField;
        
        private string PasswordField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ChatDto", Namespace="http://schemas.datacontract.org/2004/07/UnitOfWork.DataModels")]
    public partial class ChatDto : object
    {
        
        private System.Guid ChatIdField;
        
        private ServiceReference1.MessageDto[] MessagesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ChatId
        {
            get
            {
                return this.ChatIdField;
            }
            set
            {
                this.ChatIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.MessageDto[] Messages
        {
            get
            {
                return this.MessagesField;
            }
            set
            {
                this.MessagesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageDto", Namespace="http://schemas.datacontract.org/2004/07/UnitOfWork.DataModels")]
    public partial class MessageDto : object
    {
        
        private System.DateTime CreationDateField;
        
        private string DisplayNameField;
        
        private string TextField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationDate
        {
            get
            {
                return this.CreationDateField;
            }
            set
            {
                this.CreationDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DisplayName
        {
            get
            {
                return this.DisplayNameField;
            }
            set
            {
                this.DisplayNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text
        {
            get
            {
                return this.TextField;
            }
            set
            {
                this.TextField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ChatsInfoDto", Namespace="http://schemas.datacontract.org/2004/07/UnitOfWork.DataModels")]
    public partial class ChatsInfoDto : object
    {
        
        private ServiceReference1.ChatInfoDto[] ChatsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.ChatInfoDto[] Chats
        {
            get
            {
                return this.ChatsField;
            }
            set
            {
                this.ChatsField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetChat", ReplyAction="http://tempuri.org/IService1/GetChatResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Chat> GetChatAsync(System.Guid chatId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllChats", ReplyAction="http://tempuri.org/IService1/GetAllChatsResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Chat[]> GetAllChatsAsync(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TryCreateChat", ReplyAction="http://tempuri.org/IService1/TryCreateChatResponse")]
        System.Threading.Tasks.Task<ServiceReference1.ChatInfoDto> TryCreateChatAsync(string companion, System.Guid currentUserId, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUser", ReplyAction="http://tempuri.org/IService1/GetUserResponse")]
        System.Threading.Tasks.Task<ServiceReference1.UserDataModel> GetUserAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserById", ReplyAction="http://tempuri.org/IService1/GetUserByIdResponse")]
        System.Threading.Tasks.Task<ServiceReference1.UserDataModel> GetUserByIdAsync(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserByLogin", ReplyAction="http://tempuri.org/IService1/GetUserByLoginResponse")]
        System.Threading.Tasks.Task<ServiceReference1.UserDataModel> GetUserByLoginAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUser", ReplyAction="http://tempuri.org/IService1/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddMessage", ReplyAction="http://tempuri.org/IService1/AddMessageResponse")]
        System.Threading.Tasks.Task<System.DateTime> AddMessageAsync(System.Guid chatRoom, string message, System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetChatDto", ReplyAction="http://tempuri.org/IService1/GetChatDtoResponse")]
        System.Threading.Tasks.Task<ServiceReference1.ChatDto> GetChatDtoAsync(System.Guid chatId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetChats", ReplyAction="http://tempuri.org/IService1/GetChatsResponse")]
        System.Threading.Tasks.Task<ServiceReference1.ChatsInfoDto> GetChatsAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsChatCreated", ReplyAction="http://tempuri.org/IService1/IsChatCreatedResponse")]
        System.Threading.Tasks.Task<bool> IsChatCreatedAsync(System.Guid userId, System.Guid currentUserId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IService1Channel : ServiceReference1.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceReference1.IService1>, ServiceReference1.IService1
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Chat> GetChatAsync(System.Guid chatId)
        {
            return base.Channel.GetChatAsync(chatId);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Chat[]> GetAllChatsAsync(System.Guid userId)
        {
            return base.Channel.GetAllChatsAsync(userId);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ChatInfoDto> TryCreateChatAsync(string companion, System.Guid currentUserId, string userName)
        {
            return base.Channel.TryCreateChatAsync(companion, currentUserId, userName);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.UserDataModel> GetUserAsync(string login, string password)
        {
            return base.Channel.GetUserAsync(login, password);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.UserDataModel> GetUserByIdAsync(System.Guid userId)
        {
            return base.Channel.GetUserByIdAsync(userId);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.UserDataModel> GetUserByLoginAsync(string login)
        {
            return base.Channel.GetUserByLoginAsync(login);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(string login, string password)
        {
            return base.Channel.AddUserAsync(login, password);
        }
        
        public System.Threading.Tasks.Task<System.DateTime> AddMessageAsync(System.Guid chatRoom, string message, System.Guid id)
        {
            return base.Channel.AddMessageAsync(chatRoom, message, id);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ChatDto> GetChatDtoAsync(System.Guid chatId)
        {
            return base.Channel.GetChatDtoAsync(chatId);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.ChatsInfoDto> GetChatsAsync(System.Guid id)
        {
            return base.Channel.GetChatsAsync(id);
        }
        
        public System.Threading.Tasks.Task<bool> IsChatCreatedAsync(System.Guid userId, System.Guid currentUserId)
        {
            return base.Channel.IsChatCreatedAsync(userId, currentUserId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:63095/Service1.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService1,
        }
    }
}
