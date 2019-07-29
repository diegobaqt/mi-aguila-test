using System.Collections.Generic;
using System.Linq;
using MyEagleTest.Models;

namespace MyEagleTest.Repositories.Interfaces
{
    public interface ITripRepository
    {
        IQueryable<Trip> FindAll();

        Trip FindById(string id);

        Trip Add(Trip trip);

        void AddAll(List<Trip> travels);

        void Update(string id, Trip tripIn);

        void Remove(Trip tripIn);

        void RemoveById(string id);
    }
}
