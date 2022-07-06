using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace UnitOfWork.DataModels
{
    /// <summary>
    /// Модель предствления чата
    /// </summary>
    [DataContract]
    public class ChatDto
    {
        public ChatDto()
        {
            Messages = new List<MessageDto>();
        }

        /// <summary>
        /// Id чата
        /// </summary>
        [DataMember]
        public Guid ChatId { get; set; }

        /// <summary>
        /// Сообщения
        /// </summary>
        [DataMember]
        public List<MessageDto> Messages { get; set; }
    }
}
