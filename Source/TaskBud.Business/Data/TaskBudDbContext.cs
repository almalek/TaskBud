﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TaskBud.Business.Data
{
    public class TaskBudDbContext : IdentityDbContext
    {
        public TaskBudDbContext(DbContextOptions<TaskBudDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApiToken> ApiTokens { get; set; }
        public DbSet<InvitationCode> InvitationCodes { get; set; }
        public DbSet<TaskGroup> TaskGroups { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<TaskHistory> TaskHistory { get; set; }
    }
}
