using BikeStores.API.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BikeStoresContext>(x => x.UseSqlServer());
builder.Services.AddCors();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    //c.CustomOperationIds(e => $"{e.HttpMethod?.ToLower()}{e.ActionDescriptor.RouteValues["controller"]}{(e.RelativePath!.Contains("id")? "Id" : "" )}");
    c.CustomOperationIds(e => $"{e.HttpMethod?.ToLower()}{char.ToUpper(e.RelativePath![0]) + e.RelativePath.Substring(1)}");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x => x
     .AllowAnyMethod()
     .AllowAnyHeader()
     .SetIsOriginAllowed(origin => true)
     .AllowCredentials());

app.UseAuthorization();

app.MapControllers();

app.Run();
