namespace MyEagleTest.ViewModels.Shared
{
    public class ReportPagedVm
    {
        public string CountryFilter { get; set; }

        public string CityFilter { get; set; }

        public string StatusFilter { get; set; }

        public int Page { get; set; }

        public int PageSize { get; set; }
    }
}
