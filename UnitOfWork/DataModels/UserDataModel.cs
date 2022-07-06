using System;
using System.Runtime.Serialization;

namespace UnitOfWork.DataModels
{
    [DataContract]
    public class UserDataModel
    {
        /// <summary>
        /// Id 
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }

        ///<summary>
        /// Почта
        /// </summary>
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        [DataMember]
        public string Password { get; set; }
    }
}
