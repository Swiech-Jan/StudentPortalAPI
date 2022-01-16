using Microsoft.EntityFrameworkCore;
using StudentPortalAPI.Models;
using StudentPortalAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<StudentPortalContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("StudentPortalDb"));
});

builder.Services.AddCors((options) =>
{
    options.AddPolicy("angularApplication", (builder)=>
    {
        builder.WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .WithMethods("GET", "POST", "PUT", "DELETE")
        .WithExposedHeaders("*");
    });
});

builder.Services.AddScoped<IStudentRepository, SqlStudentRepository>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("angularApplication");

app.UseAuthorization();

app.MapControllers();

app.Run();
