namespace MyEagleTest.ViewModels.Shared
{
    public class PagedListVm
    {
        public PagedListVm()
        {
            Page = 0;
            PageSize = 0;
            RowCount = 0;
        }

        public int Page { get; set; }

        public int PageSize { get; set; }

        public int RowCount { get; set; }

        public object Collection { get; set; }
    }
}
