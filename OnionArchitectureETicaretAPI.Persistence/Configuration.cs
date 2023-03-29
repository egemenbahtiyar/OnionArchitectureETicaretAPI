using Microsoft.Extensions.Configuration;

namespace OnionArchitectureETicaretAPI.Persistence;

public static class Configuration
{
    public static string ConnectionString
    {
        get
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(System.IO.Path.Combine(System.AppContext.BaseDirectory, "..", "..", "OnionArchitectureETicaretAPI.API"))
                .AddJsonFile("appsettings.json")
                .Build();
            return configuration.GetConnectionString("MSSQLServer");
        }
    }
}