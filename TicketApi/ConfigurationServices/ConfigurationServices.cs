using SterenTicketsBE.Persistence.DapperConnection;
using SterenTicketsBE.Persistence.Repositories;
using SterenTicketsBE.Persistence.Interfaces;
//using SterenTicketsBE.Security.token;

namespace SterenTicketsBE.ConfigurationServices{
    public static class ConfigurationServices
    {
        public static IServiceCollection AddInjectionDependencies(this IServiceCollection services)
		{
            /*
			** ***********************    Inicialización Inyección de dependencia    ***************************
			*/
            services.AddTransient<IFactoryConnection, FactoryConnection>();
            // services.AddScoped<JwtGenerateInterface, JwtGenerate>();
             services.AddScoped<AuthInterface, AuthRepository>();
            // services.AddScoped<ProcessedProductInterface, ProcessedProductRepository>();
            // services.AddScoped<CronJobInterface, CronJobRepository>();            
            // services.AddScoped<UserInterface, UserRepository>();
            // services.AddScoped<OrderInterface, OrderRepository>();
            return services;
        }
    }

}


