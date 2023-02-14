namespace CopywritingWebSite.MVS.Configurations.LayerConfiguration
{
    public static class WebConfiguration
    {
        public static void AddWeb(this IServiceCollection service, IConfiguration configuration)
        {
            service.ConfigureAuth(configuration);
        }
    }
}


