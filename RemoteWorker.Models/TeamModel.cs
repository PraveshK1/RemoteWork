using System.ComponentModel.DataAnnotations;

namespace RemoteWorker.Models
{
    public class TeamModel
    {
        [Key] 
        public Guid TeamId { get; set; }

        [Required, MaxLength(100)]
        public required string Name { get; set; }

        public string? Description { get; set; }

        public Guid? CreatedBy { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
