using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.DataModels
{
    [DataContract]
    public class ChatsInfoDto
    {
        public ChatsInfoDto()
        {
            Chats = new List<ChatInfoDto>();
        }

        /// <summary>
        /// Чаты
        /// </summary>
        [DataMember]
        public List<ChatInfoDto> Chats { get; set; }
    }
}
