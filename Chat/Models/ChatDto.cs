using System;
using System.Collections.Generic;

namespace Chat.Models
{
    /// <summary>
    /// Модель предствления чата
    /// </summary>
    public class ChatDto
    {
        public ChatDto()
        {
            Messages = new List<MessageDto>();
        }

        /// <summary>
        /// Id чата
        /// </summary>
        public Guid ChatId { get; set; }

        /// <summary>
        /// Сообщения
        /// </summary>
        public List<MessageDto> Messages { get; set; }
    }
}
