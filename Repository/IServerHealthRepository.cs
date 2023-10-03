namespace Serverlytics.Repository;

public interface IServerHealthRepository
{
    Task<IEnumerable<ServerHealth>> Get(string appName, int page, int pageSize);
    Task<IEnumerable<ServerHealth>> Get(string appName, string region, int page, int pageSize);
    Task<IEnumerable<ServerHealth>> Get(string appName, string region, string primaryServer, int page, int pageSize);
}