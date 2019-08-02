using System;
using System.Collections.Generic;
using System.Linq;
using MyEagleTest.Models;
using MyEagleTest.Repositories.Interfaces;
using MyEagleTest.Services.Interfaces;
using MyEagleTest.ViewModels.Shared;
using MyEagleTest.ViewModels.Trip;

namespace MyEagleTest.Services
{
    public class TripService : ITripService
    {
        private readonly ITripRepository _tripRepository;

        #region Constructor

        public TripService(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        #endregion

        #region Get

        public List<Trip> FindAll()
        {
            return _tripRepository.FindAll().ToList();
        }

        public QuantityRecordsVm FindQuantityRecords(ReportPagedVm reportPagedVm)
        {
            var records = _tripRepository.FindAll();
            var filteredRecords = FindAllByReportFilter(reportPagedVm, records).ToList();

            var quantityRecordsVm = new QuantityRecordsVm
            {
                Quantity = filteredRecords.Count,
                Trips = filteredRecords
            };

            return quantityRecordsVm;
        }

        public PagedListVm FilteredAndPaged(ReportPagedVm reportPagedVm)
        {
            var page = reportPagedVm.Page > 0 ? reportPagedVm.Page : 1;
            var pageSize = reportPagedVm.PageSize > 0 ? reportPagedVm.PageSize : 10;
            var skip = (page - 1) * pageSize;

            var quantityRecordsVm = FindQuantityRecords(reportPagedVm);
            var rowCount = quantityRecordsVm.Quantity;

            var trips = quantityRecordsVm.Trips.ToList();

            return new PagedListVm
            {
                Page = page,
                PageSize = pageSize,
                RowCount = rowCount,
                Collection = trips.Skip(skip).Take(pageSize)
            };
        }

        public Trip FindById(string id)
        {
            var trip = _tripRepository.FindById(id);
            if (trip == null) throw new NullReferenceException();

            return trip;
        }

        #endregion

        #region Post

        public Trip Add(Trip trip)
        {
            _tripRepository.Add(trip);
            return trip;
        }

        public void AddAll(List<Trip> travels)
        {
            _tripRepository.AddAll(travels);
        }

        #endregion

        #region Put

        public void Update(string id, Trip tripIn)
        {
            _tripRepository.Update(id, tripIn);
        }

        #endregion

        #region Delete

        public void Remove(Trip trip)
        {
            _tripRepository.Remove(trip);
        }

        public void RemoveById(string id)
        {
            _tripRepository.RemoveById(id);
        }

        #endregion

        #region Utils

        public IQueryable<Trip> FindAllByReportFilter(ReportPagedVm reportPagedVm, IQueryable<Trip> trips)
        {
            if (reportPagedVm == null)
            {
                return trips;
            }

            if (!string.IsNullOrWhiteSpace(reportPagedVm.CountryFilter))
            {
                trips = trips.Where(t => t.Country.Name == reportPagedVm.CountryFilter);
            }

            if (!string.IsNullOrWhiteSpace(reportPagedVm.CityFilter))
            {
                trips = trips.Where(t => t.City.Name == reportPagedVm.CityFilter);
            }

            if (!string.IsNullOrWhiteSpace(reportPagedVm.StatusFilter))
            {
                trips = trips.Where(t => t.Status == reportPagedVm.StatusFilter);
            }

            return trips;
        }

        #endregion
    }
}
