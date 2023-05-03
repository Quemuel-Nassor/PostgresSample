using System.Threading.Tasks;

namespace PostgresSample.Data;

public interface IPostgresSampleDbSchemaMigrator
{
    Task MigrateAsync();
}
