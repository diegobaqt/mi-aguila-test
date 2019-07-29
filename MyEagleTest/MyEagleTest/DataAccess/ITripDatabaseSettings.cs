namespace MyEagleTest.DataAccess
{
    public interface ITripDatabaseSettings
    {
        string TripsCollectionName { get; set; }

        string ConnectionString { get; set; }

        string DatabaseName { get; set; }
    }
}
