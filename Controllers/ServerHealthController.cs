using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serverlytics.Context;
using Serverlytics.Repository;

namespace Serverlytics.Controllers;

[ApiController]
[Route("[controller]")]
public class ServerHealthController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ServerHealthController> _logger;
    private readonly IServerHealthRepository _repository;
    
    public ServerHealthController(ILogger<ServerHealthController> logger, IServerHealthRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }
    
    [HttpGet("by-appname")]
    public async Task<ActionResult<IEnumerable<ServerHealth>>> Get(string appName, int page = 1, int pageSize = 10)
    {
        var results = await _repository.Get(appName, page, pageSize);
        return Ok(results);
    }

    [HttpGet("by-appname-and-region")]
    public async Task<ActionResult<IEnumerable<ServerHealth>>> Get(string appName, string region, int page = 1, int pageSize = 10)
    {
        var results = await _repository.Get(appName, region, page, pageSize);
        return Ok(results);
    }

    [HttpGet("by-primaryserver")]
    public async Task<ActionResult<IEnumerable<ServerHealth>>> Get(string appName, string region, string primaryServer, int page = 1, int pageSize = 10)
    {
        var results = await _repository.Get(appName, region, primaryServer, page, pageSize);
        return Ok(results);
    }
}