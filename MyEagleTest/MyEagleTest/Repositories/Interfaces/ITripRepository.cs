using System.Collections.Generic;
using System.Linq;
using MyEagleTest.Models;

namespace MyEagleTest.Repositories.Interfaces
{
    public interface ITripRepository
    {
        #region Get

        /// <summary>
        /// Finds all trips stored on database
        /// </summary>
        /// <returns>
        /// Collection of Trip
        /// </returns>
        IQueryable<Trip> FindAll();

        /// <summary>
        /// Finds a trip by id stored on database
        /// </summary>
        /// <param name="id">Id of trip to find</param>
        /// <returns>
        /// Trip object
        /// </returns>
        Trip FindById(string id);

        #endregion

        #region Post

        /// <summary>
        /// Adds a trip on database 
        /// </summary>
        /// <param name="trip">Trip to add on database</param>
        /// <returns>
        /// Added trip object
        /// </returns>
        Trip Add(Trip trip);

        /// <summary>
        /// Adds many trips on database
        /// </summary>
        /// <param name="travels">Trips list to add on database</param>
        void AddAll(List<Trip> travels);

        #endregion

        #region Put

        /// <summary>
        /// Updates a trip object stored on database
        /// </summary>
        /// <param name="id">Trip id to update</param>
        /// <param name="tripIn">Trip to update</param>
        void Update(string id, Trip tripIn);

        #endregion

        #region Delete

        /// <summary>
        /// Removes a trip on database
        /// </summary>
        /// <param name="tripIn">Trip to remove on database</param>
        void Remove(Trip tripIn);

        /// <summary>
        /// Removes a trip on database by id
        /// </summary>
        /// <param name="id">Id trip to remove on database</param>
        void RemoveById(string id);

        #endregion

    }
}
