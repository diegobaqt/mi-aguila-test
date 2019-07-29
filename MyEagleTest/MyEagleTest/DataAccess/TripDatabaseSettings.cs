namespace MyEagleTest.DataAccess
{
    public class TripDatabaseSettings : ITripDatabaseSettings
    {
        public string TripsCollectionName { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
