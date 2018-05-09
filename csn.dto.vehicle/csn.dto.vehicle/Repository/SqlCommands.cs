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
        public static string InsertVehicleCommand = @"Insert into CsnDto (IdentifierID,SellerID,data)
                                                      Values (@Identifier,@Seller,@data)";
    }
}