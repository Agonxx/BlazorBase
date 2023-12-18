using BlazorBase.Web;
using BlazorBase.Web.Service;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

builder.Services.AddScoped<IUsuarioService, UsuarioService>();

builder.Services.AddHttpClient("BlazorBase.Api", opts =>
{
    opts.BaseAddress = new Uri("https://localhost:44359/");
});

await builder.Build().RunAsync();
