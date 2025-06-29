using Microsoft.EntityFrameworkCore;
using RemoteWorker.Data;
using RemoteWorker.Extensions;
using RemoteWorker.Repositories.Abstract;
using RemoteWorker.Repositories.Concrete;
using RemoteWorker.Services.Abstract;
using RemoteWorker.Services.Concrete;
using RemoteWorker.Mappings;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

//Register Interfaces and Repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped(typeof(IGenericRemoteWorkerRepository<>), typeof(GenericRemoteWorkerRepository<>));
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();

//Register Services
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProjectService, ProjectService>();


//Register DbContext before building app
builder.Services.AddDbContext<RemoteWorkerDbContext>(options => options.
UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseApiExceptionMiddleware();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
