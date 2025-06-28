using System.ComponentModel.DataAnnotations;

namespace RemoteWorker.Models
{
    public class TimeLogModel
    {
        [Key] public Guid LogId { get; set; }

        public Guid? UserId { get; set; }

        public Guid? TaskId { get; set; }

        [Required] public DateTime ClockIn { get; set; }

        public DateTime? ClockOut { get; set; }

        public string? Notes { get; set; }
    }
}
