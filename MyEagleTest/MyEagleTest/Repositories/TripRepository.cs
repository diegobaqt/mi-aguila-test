using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MyEagleTest.DataAccess;
using MyEagleTest.Models;
using MyEagleTest.Repositories.Interfaces;

namespace MyEagleTest.Repositories
{
    public class TripRepository : ITripRepository
    {
        private readonly IMongoCollection<Trip> _trip;
        
        #region Constructor

        public TripRepository(ITripDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _trip = database.GetCollection<Trip>(settings.TripsCollectionName);
        }

        #endregion

        #region Get

        public IQueryable<Trip> FindAll() => _trip.AsQueryable<Trip>();

        public Trip FindById(string id) => _trip.Find<Trip>(t => t.Id == id).FirstOrDefault();

        #endregion

        #region Post

        public Trip Add(Trip trip)
        {
            _trip.InsertOne(trip);
            return trip;
        }

        public void AddAll(List<Trip> travels)
        {
            _trip.InsertMany(travels);
        }

        #endregion

        #region Put

        public void Update(string id, Trip tripIn) =>
            _trip.ReplaceOne(t => t.Id == id, tripIn);

        #endregion

        #region Delete

        public void Remove(Trip tripIn) =>
            _trip.DeleteOne(t => t.Id == tripIn.Id);

        public void RemoveById(string id) =>
            _trip.DeleteOne(t => t.Id == id);

        #endregion
    }
}
