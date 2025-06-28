using System.ComponentModel.DataAnnotations;

namespace RemoteWorker.Models
{
    public class TaskModel
    {
        [Key] 
        public Guid TaskId { get; set; }

        public Guid? ProjectId { get; set; }

        public Guid? AssignedTo { get; set; }

        [MaxLength(100)]
        public string? Title { get; set; }

        public string? Description { get; set; }

        [MaxLength(50)]
        public string? Status { get; set; }

        [MaxLength(50)] 
        public string? Priority { get; set; }

        public DateTime? DueDate { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
