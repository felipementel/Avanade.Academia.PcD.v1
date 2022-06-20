
//using Avanade.Academia.PcD.Infra.Database;
using Avanade.Academia.PcD.Application.Interfaces;
using Avanade.Academia.PcD.Application.Services;
using Avanade.Academia.PcD.Domain.Interfaces;
using Avanade.Academia.PcD.Domain.Repositories;
using Avanade.Academia.PcD.Infra.Database;
using Avanade.Academia.PcD.Infra.Database.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IProfessorAppService, ProfessorAppService>();
builder.Services.AddScoped<IProfessorService, ProfessorService>();
builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();
builder.Services.AddDbContext<ProjetoContext>(p =>
{
    p.UseSqlServer(connectionString: @"Data Source='localhost, 1433';User ID=sa;Database=Avanade; Password=yourStrong@Password;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False", sql =>
    {
        //sql.MigrationsAssembly("Avanade.Academia.PcD.Infra.Database");
        sql.CommandTimeout(commandTimeout: 60);
        sql.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(2),
            errorNumbersToAdd: null);
    });
    p.EnableDetailedErrors(true);
    p.EnableThreadSafetyChecks(true);
    p.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
