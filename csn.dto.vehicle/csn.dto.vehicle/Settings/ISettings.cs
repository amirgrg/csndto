using Microsoft.Extensions.Options;

namespace csn.dto.vehicle.Settings
{
    public interface ISettings
    {
        ConnectionStrings GetConnectionStrings();

    }

    class StockSavingSettings : ISettings
    {   
        private readonly IOptions<ConnectionStrings> _connectionStrings;

        public StockSavingSettings(IOptions<ConnectionStrings> connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }


        public ConnectionStrings GetConnectionStrings()
        {
            return _connectionStrings.Value;
        }
    }
}
