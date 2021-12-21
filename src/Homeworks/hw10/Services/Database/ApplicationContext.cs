using Microsoft.EntityFrameworkCore;

namespace hw10.Services.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<CalculatingExpression> CalculatingExpressions { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}