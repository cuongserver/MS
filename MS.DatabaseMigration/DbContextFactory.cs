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
            optionsBuilder.UseSqlServer(
                connectionString: @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=University;",
                sqlServerOptionsAction: builder => builder.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName)
            );
            return new UniversityContext(optionsBuilder.Options);
        }
    }
}
