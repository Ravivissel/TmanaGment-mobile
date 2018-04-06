using Microsoft.EntityFrameworkCore;
using ActualTasks.Models;
using Employees.Models;
using Projects.Models;
using Requests.Models;
using ActualProjectsTasks.Models;

namespace DBServices.Models
{
    public class DBservice : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {   
        modelBuilder.Entity<ActualProjectTask>()
            .HasKey(apt => new { apt.Actual_task , apt.Project });

       
      
    }

        public DBservice(DbContextOptions<DBservice> options)
            : base(options)
        {
        }
        public virtual DbSet<ActualTask> ActualTasks { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<ActualProjectTask> ActualProjectsTasks { get; set; }
    }

}
