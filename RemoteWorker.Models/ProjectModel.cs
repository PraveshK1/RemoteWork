using System.ComponentModel.DataAnnotations;

namespace RemoteWorker.Models
{
    public class ProjectModel
    {
        [Key] 
        public Guid ProjectId { get; set; }

        [Required, MaxLength(100)]
        public required string Name { get; set; }

        public string? Description { get; set; }

        public Guid? OwnerId { get; set; }

        [MaxLength(50)] 
        public string? Status { get; set; }

        [Required] 
        public DateTime CreatedAt { get; set; }
    }
}
