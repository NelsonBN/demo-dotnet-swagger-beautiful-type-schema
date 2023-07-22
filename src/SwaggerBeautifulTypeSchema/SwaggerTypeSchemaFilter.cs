using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SwaggerBeautifulTypeSchema;

internal class SwaggerTypeSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        schema.Title = context.Type.BeautifulName();
        schema.Nullable = context.Type.IsNullable();
    }
}
