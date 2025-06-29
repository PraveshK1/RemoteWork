﻿namespace RemoteWorker.DTOs
{
    public class ProjectWithOwnerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid OwnerId { get; set; }
        public string OwnerName { get; set; }

        public string OwnerDescription { get; set; }

        public Guid OwnerOwnerId { get; set; }
    }
}
