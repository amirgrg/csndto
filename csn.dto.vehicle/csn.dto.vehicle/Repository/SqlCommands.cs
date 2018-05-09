namespace csn.dto.vehicle.Repository
{
    /// <summary>
    /// Provides access to all the sql commands for sql repository
    /// </summary>
    public static class SqlCommands
    {
        /// <summary>
        /// Inert vehicle with generated guid
        /// </summary>
        public static string InsertVehicleNewGuidCommand = @"Insert into CsnDtoVehicle (IdentifierID,SellerID,data)
                                                      Values (@vehicleGuid,@sellerId,@data)";
        public static string InsertVehicleCommand = @"Insert into CsnDtoVehicle (IdentifierID,SellerID,data)
                                                      Values (@Identifier,@sellerId,@data)";
    }
}