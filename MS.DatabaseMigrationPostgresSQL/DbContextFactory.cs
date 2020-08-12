using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MS.DataAccess.DatabaseContext;

namespace MS.DatabaseMigration
{
    public class DbContextFactory: IDesignTimeDbContextFactory<UniversityContext>
    {
        public UniversityContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
            optionsBuilder.UseNpgsql(
                connectionString: @"Port=5432;Host=localhost;Username=postgres;Password=admin;Persist Security Info=True;Database=University",
                npgsqlOptionsAction: builder => builder.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName)
            );
            return new UniversityContext(optionsBuilder.Options);
        }
    }
}
