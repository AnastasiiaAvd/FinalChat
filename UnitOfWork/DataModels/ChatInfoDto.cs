using System;
using System.Runtime.Serialization;

namespace UnitOfWork.DataModels
{
    /// <summary>
    /// Модель предствления информации чата
    /// </summary>
    [DataContract]
    public class ChatInfoDto
    {
        /// <summary>
        /// Собеседник
        /// </summary>
        [DataMember]
        public string Companion { get; set; }

        /// <summary>
        /// Id чата
        /// </summary>
        [DataMember]
        public Guid ChatId { get; set; }
    }
}
