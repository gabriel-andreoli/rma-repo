using Microsoft.EntityFrameworkCore;
using RMAProject.Domain.SeedWork;
using RMAProject.Infrastructure;
using RMAProject.Infrastructure.Repositories.Implementations;
using RMAProject.Infrastructure.Repositories.Interfaces;
using RMAProject.Presentation.Services.Implementations;
using RMAProject.Presentation.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("RMACon");
builder.Services.AddDbContext<RmaDbContext>(op => op.UseNpgsql(connectionString));

//Register DPI
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();


builder.Services.AddScoped<ISecurityService, SecurityService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.MapControllers();

app.Run();
