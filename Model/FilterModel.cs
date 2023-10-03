using Swashbuckle.AspNetCore.Annotations;

namespace Serverlytics;

public class FilterModel
{
    [SwaggerSchema("Array of application names to filter by")]
    public string[] AppNames { get; set; }

    [SwaggerSchema("Array of regions to filter by")]
    public string[] Regions { get; set; }

    [SwaggerSchema("Page number")]
    public int Page { get; set; }

    [SwaggerSchema("Page size")]
    public int PageSize { get; set; }
}