using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmailSystem.Domain;

namespace EmailSystem.Application.Interfaces
{
    public interface IEmailSystemDbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Email> Emails { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}