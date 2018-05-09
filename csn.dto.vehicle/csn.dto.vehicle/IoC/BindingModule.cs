using csn.dto.vehicle.Repository;
using csn.dto.vehicle.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace csn.dto.vehicle.IoC
{
    /// <summary>
    /// THis is to hide all the dependency registrations from the startup class
    /// </summary>
    public class BindingModule
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Bind(IServiceCollection services)
        {
            services.AddSingleton<IVehicleRepository, VehicleRepository>();
            services.AddSingleton<ISettings, StockSavingSettings>();
        }
    }
}