using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels
{
    /// <summary>
    /// Модель пользователя
    /// </summary>
    [Table("ApplicationUsers")]
    public class ApplicationUser
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
            OwnerChats = new List<Chat>();
            GuestChats = new List<Chat>();
        }

        /// <summary>
        /// Id 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        ///<summary>
        /// Почта
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        [Required]
        public string Password { get; set; }

        public string Color { get; set; }

        public virtual ICollection<Chat> OwnerChats { get; set; }
        public virtual ICollection<Chat> GuestChats { get; set; }

        /// <summary>
        /// Сообщения
        /// </summary>
        public virtual ICollection<Message> Messages { get; set; }
    }
}