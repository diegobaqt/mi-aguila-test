using System.Collections.Generic;
using MyEagleTest.Models;
using MyEagleTest.ViewModels.Shared;
using MyEagleTest.ViewModels.Trip;

namespace MyEagleTest.Services.Interfaces
{
    public interface ITripService
    {
        List<Trip> FindAll();

        Trip FindById(string id);

        PagedListVm FilteredAndPaged(ReportPagedVm reportPagedVm);

        QuantityRecordsVm FindQuantityRecords(ReportPagedVm reportPagedVm);

        Trip Add(Trip trip);

        void AddAll(List<Trip> travels);

        void Update(string id, Trip tripIn);

        void Remove(Trip tripIn);

        void RemoveById(string id);
    }
}
