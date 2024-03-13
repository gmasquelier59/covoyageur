using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EVS.Front;
using MudBlazor.Services;
using EVS.Front.Services;
using Blazor.Component.Maps;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazorBootstrap();
builder.Services.AddMudServices();
builder.Services.AddMapsServices();
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7014")
});
builder.Services.AddScoped<IRideService, RideService>();

await builder.Build().RunAsync();
