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
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(items.Count / (double)pageSize);
            Result = items.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
