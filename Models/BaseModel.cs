using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProjectOffice.Desktop.Models
{
    public partial class BaseModel : DbContext
    {
        public BaseModel()
            : base("name=ModelBase")
        {
        }

        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Emploeyy> Emploeyy { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<StoryTaskStatus> StoryTaskStatus { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskStatus> TaskStatus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .Property(e => e.SendTime)
                .IsFixedLength();

            modelBuilder.Entity<Emploeyy>()
                .HasMany(e => e.Comment)
                .WithRequired(e => e.Emploeyy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Emploeyy>()
                .HasMany(e => e.Project)
                .WithOptional(e => e.Emploeyy)
                .HasForeignKey(e => e.ResponsibleEmployeeId);

            modelBuilder.Entity<Emploeyy>()
                .HasMany(e => e.Project1)
                .WithRequired(e => e.Emploeyy1)
                .HasForeignKey(e => e.CreatorEmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Emploeyy>()
                .HasMany(e => e.Task)
                .WithOptional(e => e.Emploeyy)
                .HasForeignKey(e => e.ExecutiveEmployeeId);

            modelBuilder.Entity<Emploeyy>()
                .HasMany(e => e.Task1)
                .WithOptional(e => e.Emploeyy1);

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Task)
                .WithRequired(e => e.Project)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.Attachment)
                .WithRequired(e => e.Task)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.Comment)
                .WithRequired(e => e.Task)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.StoryTaskStatus)
                .WithRequired(e => e.Task)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.Task1)
                .WithOptional(e => e.Task2)
                .HasForeignKey(e => e.PreviosTaskId);

            modelBuilder.Entity<TaskStatus>()
                .HasMany(e => e.StoryTaskStatus)
                .WithRequired(e => e.TaskStatus)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaskStatus>()
                .HasMany(e => e.Task)
                .WithRequired(e => e.TaskStatus)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);
        }
    }
}
