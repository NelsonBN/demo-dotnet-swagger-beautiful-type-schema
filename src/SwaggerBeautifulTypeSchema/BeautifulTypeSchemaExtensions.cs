using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SwaggerBeautifulTypeSchema;

public static class BeautifulTypeSchemaExtensions
{
    public static SwaggerGenOptions AddBeautifulTypeSchema(this SwaggerGenOptions options)
    {
        options.CustomSchemaIds(type => type.FullName!.Replace('+', '.'));
        options.SchemaFilter<SwaggerTypeSchemaFilter>();

        return options;
    }
}
