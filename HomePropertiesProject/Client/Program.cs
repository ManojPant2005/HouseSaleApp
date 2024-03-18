using HomePropertiesProject.Client;
using HomePropertiesProject.Client.Services.HouseService;
using HomePropertiesProject.Client.Services.ModeService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IHouseService, HouseService>();
builder.Services.AddScoped<IModeService, ModeService>();

await builder.Build().RunAsync();
