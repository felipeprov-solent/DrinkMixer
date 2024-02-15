using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DrinkMixer.Lib.Service;
using DrinkMixer.Data.Service;
using DrinkMixer.Exec;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<IMixerService, MixerService>();
builder.Services.AddTransient<ExempleClient>();

using IHost host = builder.Build();

ExempleService(host.Services, 1, "Expresso");
ExempleService(host.Services, 2, "Allongé");
ExempleService(host.Services, 3, "3");
ExempleService(host.Services, 4, null); 

await host.RunAsync();

static void ExempleService(IServiceProvider hostProvider, int call, string arg)
{   
    try
    {
        using IServiceScope serviceScope = hostProvider.CreateScope();
        IServiceProvider provider = serviceScope.ServiceProvider;
        ExempleClient exemple = provider.GetRequiredService<ExempleClient>();

        exemple.Do(call, arg);

        Console.WriteLine();
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    } 
}