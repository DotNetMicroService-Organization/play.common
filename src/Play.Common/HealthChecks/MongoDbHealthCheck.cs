using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;

namespace Play.Common.HealthChecks;

public class MongoDbHealthCheck : IHealthCheck
{
    private readonly MongoClient client;
    private readonly ILogger<MongoDbHealthCheck> logger;


    public MongoDbHealthCheck(MongoClient client, ILogger<MongoDbHealthCheck> logger)
    {
        this.client = client;
        this.logger = logger;
    }

    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        logger.LogInformation(
                            "AAAA Receiving mongodbclient {MongoClient}",
                            this.client);
        try
        {
            await client.ListDatabaseNamesAsync(cancellationToken);
            return HealthCheckResult.Healthy();
        }
        catch (System.Exception ex)
        {

            return HealthCheckResult.Unhealthy(exception: ex);
        }
    }

}
