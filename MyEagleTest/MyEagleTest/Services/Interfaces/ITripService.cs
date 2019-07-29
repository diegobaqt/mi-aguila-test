using System.Collections.Generic;
using MyEagleTest.Models;
using MyEagleTest.ViewModels.Shared;
using MyEagleTest.ViewModels.Trip;

namespace MyEagleTest.Services.Interfaces
{
    public interface ITripService
    {
        #region Get

        /// <summary>
        /// Finds all trips stored on database
        /// </summary>
        /// <returns>
        /// List of Trip
        /// </returns>
        List<Trip> FindAll();

        /// <summary>
        /// Finds a trip by id stored on database
        /// </summary>
        /// <param name="id">Id of trip to find</param>
        /// <returns>
        /// Trip object
        /// </returns>
        Trip FindById(string id);

        /// <summary>
        /// Filters and paged all trips by filter and paged settings
        /// </summary>
        /// <param name="reportPagedVm">Filter and paged settings</param>
        /// <returns>
        /// PagedListVm (It contains: page, page size, records quantity and trips collection)
        /// </returns>
        PagedListVm FilteredAndPaged(ReportPagedVm reportPagedVm);

        /// <summary>
        /// Finds a quantity records by filter and paged settings
        /// </summary>
        /// <param name="reportPagedVm">Filter and paged settings</param>
        /// <returns>
        /// QuantityRecordsVm (It contains: records quantity and trips collection)
        /// </returns>
        QuantityRecordsVm FindQuantityRecords(ReportPagedVm reportPagedVm);

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
