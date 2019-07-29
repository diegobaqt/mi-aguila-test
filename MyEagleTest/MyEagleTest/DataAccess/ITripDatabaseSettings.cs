namespace MyEagleTest.DataAccess
{
    public interface ITripDatabaseSettings
    {
        /// <summary>
        /// Collection name to connect
        /// </summary>
        string TripsCollectionName { get; set; }

        /// <summary>
        /// Server information to connect
        /// </summary>
        string ConnectionString { get; set; }

        /// <summary>
        /// Database name to connect
        /// </summary>
        string DatabaseName { get; set; }
    }
}
