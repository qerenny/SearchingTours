#pragma warning disable CA1506
using Itmo.Dev.Platform.Common.Extensions;
using Itmo.Dev.Platform.Logging.Extensions;
using SearchingTours.Application.Extensions;
using SearchingTours.Presentation.Http.Extensions;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using SearchingTours.Infrastructure.Persistence.Extensions;

using Testcontainers.PostgreSql;
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddUserSecrets<Program>();

builder.Services.AddOptions<JsonSerializerSettings>();
builder.Services.AddSingleton(sp => sp.GetRequiredService<IOptions<JsonSerializerSettings>>().Value);

builder.Services.AddApplication();

PostgreSqlContainer postgres = new PostgreSqlBuilder().WithImage("postgres:16.2-alpine").Build();

await postgres.StartAsync();

builder.Configuration["Infrastructure:Persistence:Postgres:ConnectionString"] = postgres.GetConnectionString();
builder.Services.AddInfrastructurePersistence(builder.Configuration);


builder.Services
    .AddControllers()
    .AddNewtonsoftJson()
    .AddPresentationHttp();

builder.Services.AddSwaggerGen().AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Host.AddPlatformSerilog(builder.Configuration);
builder.Services.AddUtcDateTimeProvider();

WebApplication app = builder.Build();

app.UseRouting();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

await app.RunAsync();
#pragma warning restore CA1506
