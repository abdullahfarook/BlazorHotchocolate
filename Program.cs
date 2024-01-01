using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorHotchocolate;
using StrawberryShake;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddRedApi(ExecutionStrategy.CacheFirst).ConfigureHttpClient(client =>
{
    client.BaseAddress = new Uri("https://api-red.metaphorltd.com/graphql");
});

await builder.Build().RunAsync();