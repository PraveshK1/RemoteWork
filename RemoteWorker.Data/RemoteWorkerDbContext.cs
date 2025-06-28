using Microsoft.EntityFrameworkCore;
using RemoteWorker.Models;

namespace RemoteWorker.Data
{
    public class RemoteWorkerDbContext(DbContextOptions<RemoteWorkerDbContext> options) : DbContext(options)
    {
        public DbSet<UserModel> User { get; set; }
        public DbSet<TimeLogModel> TimeLog { get; set; }
        public DbSet<TeamModel> Team { get; set; }
        public DbSet<TeamMemberModel> TeamMember { get; set; }
        public DbSet<TaskModel> Task { get; set; } 
        public DbSet<ProjectModel> Project { get; set; }
        public DbSet<MessageModel> Message { get; set; }
        public DbSet<MeetingModel> Meeting { get; set; }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
