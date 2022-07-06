using System;
using System.Runtime.Serialization;

namespace UnitOfWork.DataModels
{
    /// <summary>
    /// Модель предствления сообщения
    /// </summary>
    [DataContract]
    public class MessageDto
    {
        /// <summary>
        /// Дата создания
        /// </summary>
        [DataMember]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Имя автора сообщения
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }

        /// <summary>
        /// Текст сообщения
        /// </summary>
        [DataMember]
        public string Text { get; set; }
    }
}
