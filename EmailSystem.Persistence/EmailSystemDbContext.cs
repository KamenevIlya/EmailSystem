using Microsoft.EntityFrameworkCore;
using EmailSystem.Application.Interfaces;
using EmailSystem.Domain;
using EmailSystem.Persistence.EntityTypeConfigurations;

namespace EmailSystem.Persistence
{
    public sealed class EmailSystemDbContext : DbContext, IEmailSystemDbContext
    {
        public DbSet<Email> Emails { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public EmailSystemDbContext(DbContextOptions<EmailSystemDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmailConfiguration());
            builder.ApplyConfiguration(new EmployeeConfiguration());
            base.OnModelCreating(builder);
        }
    }
}