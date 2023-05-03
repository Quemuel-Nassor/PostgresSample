using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PostgresSample.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class PostgresSampleDbContextFactory : IDesignTimeDbContextFactory<PostgresSampleDbContext>
{
    public PostgresSampleDbContext CreateDbContext(string[] args)
    {
        PostgresSampleEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<PostgresSampleDbContext>()
            //.UseSqlServer(configuration.GetConnectionString("Default"));
            .UseNpgsql(configuration.GetConnectionString("Default"));

        return new PostgresSampleDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../PostgresSample.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
