namespace FVenue.API.Models
{
    public class PaginationModel<T>
    {
        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int TotalPages { get; private set; }
        public List<T> Result { get; private set; }

        public PaginationModel(List<T> items, int pageIndex, int pageSize)
        {
            var totalPages = (int)Math.Ceiling(items.Count / (double)pageSize);
            PageIndex = pageIndex <= 0 ? 1 : pageIndex > totalPages ? totalPages : pageIndex;
            PageSize = pageSize;
            TotalPages = totalPages;
            Result = items.Skip((PageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
