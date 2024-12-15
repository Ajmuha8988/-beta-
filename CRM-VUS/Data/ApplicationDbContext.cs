using CRM_VUS.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRM_VUS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<ClassRoom> classRooms { get; set; }
        public DbSet<ClassLessons> classLessons { get; set; }
        public DbSet<PSchedule> pschedules { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
