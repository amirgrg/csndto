using System;
using csn.dto.vehicle.Models.Vehicle;
using Csn.Public.Dto.Vehicle;

namespace csn.dto.vehicle.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public interface IVehicleRepository
    {
        /// <summary>
        /// Save a csndto based vehicle to db
        /// </summary>
        /// <param name="data"></param>
        Guid Save(Vehicle data);

        Vehicle ListIdData(Guid identifier);
    }
}
