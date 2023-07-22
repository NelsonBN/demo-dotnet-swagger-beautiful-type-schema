# Swagger Beautiful Type Schema Library

## Description

This library allows us to use DTOs with the same name in different namespaces and also beautifully display them in Swagger UI.

## Example

This example is not possible by default in `Swashbuckle.AspNetCore`

```csharp
namespace Api.Customers;

public class ListResponse
{
    // ...
}
```

```csharp
namespace Api.Products;

public class ListResponse
{
    // ...
}
```

## Usage

With this library, we can overcome that limitation.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen(options =>
    {
        options.AddBeautifulTypeSchema();
    });
```

## Solution

The solution is simple, we just need to add this code to SwaggerGenOptions:
```csharp
builder.Services
    .AddSwaggerGen(options =>
    {
        options.CustomSchemaIds(type => type.FullName!.Replace('+', '.'));
        options.SchemaFilter<SwaggerTypeSchemaFilter>();
    });
```

The remaining code is just for displaying the type names in a more user-friendly way. After applying the previous code, the type names may not be displayed in an aesthetically pleasing manner, so the additional code addresses this issue.
