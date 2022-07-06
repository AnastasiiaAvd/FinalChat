using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels
{
    /// <summary>
    /// Модель сообщения
    /// </summary>
    [Table("Messages")]
    public class Message
    {
        public Message()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
        }

        /// <summary>
        /// Id сообщения
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// /Id чата
        /// </summary>
        [ForeignKey("Chat")]
        [Required]
        public Guid ChatId { get; set; }

        /// <summary>
        /// Чат
        /// </summary>
        public virtual Chat Chat { get; set; }

        /// <summary>
        /// Id автора сообщения
        /// </summary>
        [ForeignKey("MessageAuthor")]
        [Required]
        public Guid MessageAuthorId { get; set; }

        /// <summary>
        /// Автор сообщения
        /// </summary>
        public virtual ApplicationUser MessageAuthor { get; set; }

        /// <summary>
        /// Текст сообщения
        /// </summary>
        [Required]
        public string Text { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; set; }
    }
}