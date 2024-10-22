
namespace mbadmin.Models
{
    public class LogPaginationViewModel<T>
    {
        public IEnumerable<T> Logs { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;
    }

}
