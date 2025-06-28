
using System.ComponentModel.DataAnnotations;

namespace RemoteWorker.Models
{
    public class TeamMemberModel
    {
        [Key][Required]
        public Guid TeamId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [MaxLength(50)] 
        public string? RoleInTeam { get; set; }

        public DateTime? JoinedAt { get; set; }
    }
}
