using System.Data.SqlClient;
using csn.dto.vehicle.Settings;
using Csn.Public.Dto.Vehicle;
using Dapper;

namespace csn.dto.vehicle.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class VehicleRepository : IVehicleRepository
    {
        private readonly string _tpdConnectionString;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        public VehicleRepository(ISettings settings)
        {
            _tpdConnectionString = settings.GetConnectionStrings().ThirdPartyData;
        }

        public void Add(Vehicle data)
        {
            using (var conn = new SqlConnection(_tpdConnectionString))
            {
                string sqlQuery = "Insert into CsnDto (IdentifierID,SellerID,data) Values (@Identifier,@Seller,@data)";

                conn.Execute(sqlQuery, data);
            }

        }

    }
}
