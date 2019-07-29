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
            var filteredRecords = FindAllByReportFilter(reportPagedVm.ReportFilterVm, records);

            var quantityRecordsVm = new QuantityRecordsVm
            {
                Quantity = filteredRecords.Count(),
                Trips = filteredRecords
            };

            return quantityRecordsVm;
        }

        public PagedListVm FilteredAndPaged(ReportPagedVm reportPagedVm)
        {
            if (reportPagedVm?.PaginationVm == null) return new PagedListVm();

            var paginationVm = reportPagedVm.PaginationVm;

            var page = paginationVm.Page;
            var pageSize = paginationVm.PageSize;
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
            return _tripRepository.FindById(id);
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

        public IQueryable<Trip> FindAllByReportFilter(ReportFilterVm reportFilterVm, IQueryable<Trip> trips)
        {
            if (reportFilterVm == null)
            {
                return trips;
            }

            if (!string.IsNullOrWhiteSpace(reportFilterVm.CountryFilter))
            {
                trips = trips.Where(t => t.Country.Name == reportFilterVm.CountryFilter);
            }

            if (!string.IsNullOrWhiteSpace(reportFilterVm.CityFilter))
            {
                trips = trips.Where(t => t.City.Name == reportFilterVm.CityFilter);
            }

            if (!string.IsNullOrWhiteSpace(reportFilterVm.StatusFilter))
            {
                trips = trips.Where(t => t.Status == reportFilterVm.StatusFilter);
            }

            return trips;
        }

        #endregion
    }
}
