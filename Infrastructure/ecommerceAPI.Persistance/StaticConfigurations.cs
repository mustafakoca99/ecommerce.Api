using Microsoft.Extensions.Configuration;

namespace ecommerceAPI.Persistance
{
    static class StaticConfigurations
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ecommerceAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("MsSQL");
            }
        }
    }
}
