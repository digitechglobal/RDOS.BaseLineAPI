namespace RDOS.BaseLine.Models
{
    public class Results
    {
        public class EcoParameters
        {
            const int maxPageSize = 50;
            public int PageNumber { get; set; } = 1;
            private int _pageSize = 10;
            public int PageSize
            {
                get
                {
                    return _pageSize;
                }
                set
                {
                    _pageSize = (value > maxPageSize) ? maxPageSize : value;
                }
            }
            public int? Skip { get; set; }
            public int? Top { get; set; }
            public string? OrderBy { get; set; }
            public string? Filter { get; set; }
            public bool IsDropdown { get; set; }
            public DateTime? FromDate { get; set; }
            public DateTime? ToDate { get; set; }
            public string? SearchValue { get; set; }
            public string? SearchText { get; set; }
            public string? PrincipleCode { get; set; }
            public int? LogLevel { get; set; }
        }
        public class MetaData
        {
            public int CurrentPage { get; set; }
            public int TotalPages { get; set; }
            public int PageSize { get; set; }
            public int TotalCount { get; set; }

            public bool HasNext
            {

                get { return PageSize * (CurrentPage - 1) < TotalCount; }
            }

            public bool HasPrevious
            {
                get { return PageSize * (CurrentPage - 1) > 0; }
            }
        }
        public class BaseResultModel
        {
            public int ObjectId { get; set; } = 0;
            public Guid ObjectGuidId { get; set; }
            public int Code { get; set; } = 0;
            public string Message { get; set; } = "";
            public bool IsSuccess { get; set; } = true;
            public object Data { get; set; }
        }
        public class ResultModelWithObject<T>
        {
            public int ObjectId { get; set; } = 0;
            public Guid ObjectGuidId { get; set; }
            public int Code { get; set; } = 0;
            public string Message { get; set; } = "";
            public bool IsSuccess { get; set; } = true;
            public T Data { get; set; }
        }

        public class PagedList<T> : List<T>
        {
            public MetaData MetaData { get; set; }
            public PagedList()
            {
                // Just come here in case Exception
            }
            public PagedList(List<T> items, int count, int pageNumber, int pageSize)
            {
                MetaData = new MetaData
                {
                    TotalCount = count,
                    PageSize = pageSize,
                    CurrentPage = pageNumber,
                    TotalPages = (int)Math.Ceiling(count / (double)pageSize)
                };
                AddRange(items);
            }
            public static PagedList<T> ToPagedList(List<T> source, int skip, int top)
            {
                if (top == 0) top = 99999;
                var count = source.Count();
                var items = source
                  .Skip(skip)
                  .Take(top).ToList();
                return new PagedList<T>(items, count, (skip / top) + 1, top);
            }
        }
    }
}
