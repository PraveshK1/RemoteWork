using System.ComponentModel.DataAnnotations;

namespace RemoteWorker.DTOs
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        [Required, MaxLength(100)]
        public required string FullName { get; set; }

        [Required, MaxLength(100)]
        public required string Email { get; set; }

        [Required, MaxLength(255)]
        public required string PasswordHash { get; set; }

        [MaxLength(50)]
        public string? Role { get; set; }

        [MaxLength(50)]
        public string? Status { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? LastLogin { get; set; }
    }
}
