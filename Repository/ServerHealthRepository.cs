using Microsoft.EntityFrameworkCore;
using Serverlytics.Context;

namespace Serverlytics.Repository;

public class ServerHealthRepository : IServerHealthRepository
{
    private readonly ServerlyticsContext _context;

    public ServerHealthRepository(ServerlyticsContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ServerHealth>> Get(string appName, int page, int pageSize)
    {
        var query = _context.ServerHealth
            .Where(s => s.AppName == appName)
            .OrderBy(s => s.SerialNum)
            .Skip((page - 1) * pageSize)
            .Take(pageSize);

        return await query.ToListAsync();
    }

    public async Task<IEnumerable<ServerHealth>> Get(string appName, string region, int page, int pageSize)
    {
        var query = _context.ServerHealth
            .Where(s => s.AppName == appName && s.Region == region)
            .OrderBy(s => s.SerialNum)
            .Skip((page - 1) * pageSize)
            .Take(pageSize);

        return await query.ToListAsync();
    }

    public async Task<IEnumerable<ServerHealth>> Get(string appName, string region, string primaryServer, int page, int pageSize)
    {
        var query = _context.ServerHealth
            .Where(s => s.AppName == appName && s.Region == region && s.PrimaryServer == primaryServer)
            .OrderBy(s => s.SerialNum)
            .Skip((page - 1) * pageSize)
            .Take(pageSize);

        return await query.ToListAsync();
    }
    
    public async Task<IEnumerable<ServerHealth>> GetMultiple(string[] appName, string[] region, int page, int pageSize)
    {
        var query = _context.ServerHealth
            .Where(s => appName.Contains(s.AppName) || region.Contains(s.Region))
            .OrderBy(s => s.SerialNum)
            .Skip((page - 1) * pageSize)
            .Take(pageSize);

        return await query.ToListAsync();
    }
}