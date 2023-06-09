using SterenTicketsBE.Persistence.DapperConnection;
using SterenTicketsBE.Persistence.Repositories;
using SterenTicketsBE.Persistence.Interfaces;
using SterenTicketsBE.Security.token;

namespace SterenTicketsBE.ConfigurationServices
{
    public static class ConfigurationServices
    {
        public static IServiceCollection AddInjectionDependencies(this IServiceCollection services)
        {
            /*
			** ***********************    Inicialización Inyección de dependencia    ***************************
			*/
            services.AddTransient<IFactoryConnection, FactoryConnection>();
            services.AddScoped<JwtGenerateInterface, JwtGenerate>();
            services.AddScoped<AuthInterface, AuthRepository>();
            services.AddScoped<ErrorInterface, ErrorRepository>();
            services.AddScoped<DepartamentInterface, DepartamentRepository>();
            services.AddScoped<TicketInterface, TicketRepository>();
            services.AddScoped<DashboardTicketInterface, DashboardTicketRepository>();

            return services;
        }
    }

}


