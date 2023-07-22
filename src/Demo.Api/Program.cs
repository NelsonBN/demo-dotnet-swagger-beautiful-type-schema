using System.Reflection;
using SwaggerBeautifulTypeSchema;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen(options =>
    {
        options.AddBeautifulTypeSchema();

        var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? default!;
        foreach(var fileName in Directory.GetFiles(path, "*.xml", SearchOption.AllDirectories))
        {
            options.IncludeXmlComments(fileName);
        }
    });

var app = builder.Build();

app.UseSwagger()
   .UseSwaggerUI();

app.MapControllers();

app.Run();
