namespace CommunityTrainingAPI.Filter
{
    public class GenericQueryOptions<TFilter>
    {
        public TFilter Filter { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 8;
        public SortOrder SortOrder { get; set; } = SortOrder.Ascending;
    }

    public enum SortOrder
    {
        Ascending = 1,
        Descending = 2
    }
}
