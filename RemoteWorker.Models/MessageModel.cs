using System.ComponentModel.DataAnnotations;

namespace RemoteWorker.Models
{
    public class MessageModel
    {
        [Key] 
        public Guid MessageId { get; set; }

        public Guid? SenderId { get; set; }

        public Guid? TeamId { get; set; }

        public string? Content { get; set; }

        [Required] 
        public DateTime SentAt { get; set; }
    }
}
