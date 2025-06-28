using System.ComponentModel.DataAnnotations;

namespace RemoteWorker.Models
{
    public class MeetingModel
    {
        [Key] 
        public Guid MeetingId { get; set; }

        [MaxLength(100)] 
        public string? Title { get; set; }

        public Guid? OrganizerId { get; set; }

        public Guid? TeamId { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        [Required, MaxLength(255)] 
        public string VideoLink { get; set; }
    }
}
