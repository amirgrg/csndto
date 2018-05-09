using System;
using System.Data.SqlClient;
using System.Linq;
using csn.dto.vehicle.Models.Vehicle;
using csn.dto.vehicle.Settings;
using Csn.Public.Dto.Vehicle;
using Dapper;
using Microsoft.Extensions.Options;

namespace csn.dto.vehicle.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class VehicleRepository : IVehicleRepository
    {
        //private readonly string _tpdConnectionString;

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="settings"></param>
        //public VehicleRepository(ISettings settings)
        //{
        //    _tpdConnectionString = settings.GetConnectionStrings().ThirdPartyData;
        //}
        private ConnectionStrings _connectionString;
        public VehicleRepository( IOptions<ConnectionStrings> connectionString)
        {
            _connectionString = connectionString.Value;

        }

        public Guid Save(Vehicle data)
        {
           
            var sellerId = data.Seller.Identifier;
            var vehicleData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            if (data.Identifier == Guid.Empty)
            {
                var vehicleGuid = Guid.NewGuid();
                
            }
            else
            {
                var vehicleGuid = data.Identifier;

            }

            using (var conn = new SqlConnection(_connectionString.ThirdPartyData))
            {
             
               
                     string InsertVehicleCommand = @"Insert into CsnDtoVehicle (IdentifierID,SellerID, data)
                                                      Values (@Identifier,@sellerId,@vehicleData )";
                        conn.Execute(InsertVehicleCommand, new {data.Identifier, sellerId, vehicleData });
                    return Guid.Empty;
                

            }
            



        }

        public Vehicle ListIdData(Guid identifier)
        {
            Vehicle listData = new Vehicle();
            using (var conn = new SqlConnection(_connectionString.ThirdPartyData))
            {
                listData = conn.Query<Vehicle>("Select data from CsnDtoVehicle WHERE IdentifierID = @IdentifierID",
                    new {identifier}).SingleOrDefault();
            }

            return listData;

        }

    }
}
