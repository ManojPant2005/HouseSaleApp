using HomePropertiesProject.Server.Data;
using HomePropertiesProject.Server.Repositories.HouseRepositories;
using HomePropertiesProject.Server.Repositories.ModeRepositories;
using HomePropertiesProject.Shared.Converters;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("HouseConn") ??
    throw new InvalidOperationException("Database connection string 'DefaultConnection' doesnt not exist"));
});

builder.Services.AddScoped<IHouseRepo, HouseRepo>();
builder.Services.AddScoped<IModeRepository, ModeRepository>();
builder.Services.AddScoped<IFromDtoToEntity, FromDtoToEntity>();
builder.Services.AddScoped<IFromEntityToDto, FromEntityToDto>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
