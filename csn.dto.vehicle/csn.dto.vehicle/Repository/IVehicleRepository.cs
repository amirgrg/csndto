using Csn.Public.Dto.Vehicle;

namespace csn.dto.vehicle.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public interface IVehicleRepository
    {
        /// <summary>
        /// Add a csndto based vehicle to db
        /// </summary>
        /// <param name="data"></param>
        void Add(Vehicle data);
    }
}
