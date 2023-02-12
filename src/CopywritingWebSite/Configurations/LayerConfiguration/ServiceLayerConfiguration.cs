using CopywritingWebSite.MVS.Configurations;
using CopywritingWebSite.Service.Interfaces;
using CopywritingWebSite.Service.Services;
using MailKit;

namespace CopywritingWebSite.MVS.Configurations.LayerConfiguration
{
    public static class ServiceLayerConfiguration
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICopywritingStatusService, CopywritingStatusService>();
            services.AddScoped<ICustomerTheEmpolyeerService, CustomerTheEmpolyeerService>();
            services.AddScoped<ICustomerWorkerService, CustomerWorkerService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IPriceStatusService, PriceStatusService>();
            services.AddScoped<ITermAccountService, TermAccountService>();
            services.AddScoped<ITestService, TestService>();
        }
    }
}

