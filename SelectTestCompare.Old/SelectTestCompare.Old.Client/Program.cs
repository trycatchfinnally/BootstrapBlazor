using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace SelectTestCompare.Old.Client;

class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.Services.AddBootstrapBlazor();
        await builder.Build().RunAsync();
    }
}
