using System.Linq;

namespace MyEagleTest.ViewModels.Trip
{
    public class QuantityRecordsVm
    {
        public IQueryable<Models.Trip> Trips { get; set; }

        public int Quantity { get; set; }
    }
}
